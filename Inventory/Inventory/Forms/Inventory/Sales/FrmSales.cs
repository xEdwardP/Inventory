using Inventory.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Inventory.Forms.Inventory.Sales
{
    public partial class FrmSales : Form
    {
        // Instancias
        Clases.Repository Repository = new Clases.Repository();
        Clases.Helpers Helpers = new Clases.Helpers();

        // Variables
        private string code, client, rtn, product, nfact;

        private string datetoday = DateTime.Today.ToShortDateString().ToString();

        private int errors = 0, quantity;

        private string idmodule = "VNT";

        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Ventas | ";
            StartForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Clean();
            AutoGenCode();
            StateButtons(false, true, false, false, true, false, false, false);
            StateControls(true);

            TxtSearch.Clear();
            TxtSearch.Enabled = false;
            BtnSearch.Enabled = false;

            Seed();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            if (errors == 0)
            {
                SetValues();
                InventoryManagement2(product,quantity);
                if(errors == 0)
                {
                    string fields = "IDVENTA, NFACTV, CLIENTE, RTN, IDPRODUCTO, CANTIDAD";
                    string values = "'" + code + "', '" + nfact + "', '" + client + "', '" + rtn + "', '" + product + "', " + quantity + "";

                    if(Repository.Save("VENTAS", fields, values)> 0)
                    {
                        Helpers.MsgSuccess(Clases.Messages.MsgSave);
                        Repository.SetLast(idmodule);
                        //InventoryManagement(product, quantity);

                        // SALDO
                        string condition = "IDPRODUCTO='" + product + "'";
                        int st = Convert.ToInt16(Repository.Hook("SALDOACTUAL", "PRODUCTOS", condition));
                        st -= quantity;
                        Repository.Update("PRODUCTOS", "SALDOACTUAL='" + st + "'", condition);
                        
                        Clean();
                        StartForm();
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (Helpers.MsgQuestion(Clases.Messages.MsgCancel) == "S")
            {
                Clean();
                StartForm();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Helpers.GetOnlyNumbers(e) ? false : true;
        }

        private void TxtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Helpers.GetOnlyNumbers(e) ? false : true;
        }

        // Metodo StartForm -> Estado por defecto del formulario
        private void StartForm()
        {
            LblDate.Text = datetoday.ToString();
            LblNFact.Text = "FAC000000";
            DgvData.Rows.Clear();
            StateButtons(true, false, false, false, true, true, true, true);
            StateControls(false);
            GetProducts();
        }

        // Metodo StateButtons -> Habilita y deshabilita los botones
        private void StateButtons(bool stnew, bool stsave, bool stupdate, bool stdelete, bool stcancel, bool stexit, bool stsearch, bool inventory)
        {
            BtnNew.Enabled = stnew;
            BtnSave.Enabled = stsave;
            //BtnUpdate.Enabled = stupdate;
            BtnDelete.Enabled = stdelete;
            BtnCancel.Enabled = stcancel;
            BtnClose.Enabled = stexit;
            BtnSearch.Enabled = stsearch;
            //BtnCancelSearch.Enabled = stsearch;

            RbPEPS.Enabled = inventory;
            RbUEPS.Enabled = inventory;
            RbAverageCost.Enabled = inventory;
        }

        // Metodo StateControls -> Habilita y deshabilita los controles
        private void StateControls(bool state)
        {
            TxtClient.Enabled = state;
            TxtRTN.Enabled = state;
            CmbProduct.Enabled = state;
            TxtQuantity.Enabled = state;
        }

        // Metodo AutoGenCode -> Genera los codigos para autores
        private void AutoGenCode()
        {
            code = "VNT" + Repository.GetNext(idmodule);
        }

        // Metodo Clean -> Limpia los controles
        private void Clean()
        {
            TxtClient.Clear();
            TxtRTN.Clear();
            CmbProduct.SelectedIndex = -1;
            TxtQuantity.Clear();

            DgvData.Rows.Clear();
            TxtSearch.Clear();
        }

        // Metodo ValidateInfo -> Valida la informacion ingresada en los campos
        private void ValidateData()
        {
            errors = 0;
            
            if (TxtClient.Text.Trim().Length == 0)
            {
                Helpers.MsgWarning("INGRESE EL NOMBRE DEL CLIENTE!");
                TxtClient.Focus();
                errors++;
                return;
            }

            if (TxtRTN.Text.Trim().Length < 13 )
            {
                Helpers.MsgWarning("INGRESE UN NUMERO DE RTN VALIDO!");
                TxtRTN.Focus();
                errors++;
                return;
            }

            if (CmbProduct.Text == "")
            {
                Helpers.MsgWarning("SELECCION EL PRODUCTO!");
                CmbProduct.Focus();
                errors++;
                return;
            }

            if (TxtQuantity.Text.Trim().Length == 0 || Convert.ToDouble(TxtQuantity.Text.Trim()) <= 0 )
            {
                Helpers.MsgWarning("INGRESE LA CANTIDAD!");
                TxtQuantity.Focus();
                errors++;
                return;
            }
        }

        // Metodo SetValues -> Almacenada la informacion de los campos en variables
        private void SetValues()
        {
            nfact = LblNFact.Text;
            client = Helpers.CleanStr(TxtClient.Text.Trim());
            rtn = Helpers.CleanStr(TxtRTN.Text.Trim());
            product = CmbProduct.Text != "" ? CmbProduct.SelectedValue.ToString() : "";
            quantity = Convert.ToInt16(TxtQuantity.Text.Trim());
        }

        private void InventoryManagement(string producto, int cantidad)
        {
            string condition = "IDPRODUCTO='" + producto + "' AND ESTADO='DISPONIBLE'";
            string firstreg = Repository.Harpoon("IDLOTE", "LOTES", "IDLOTE", condition, "first");
            int stockl1 = Convert.ToInt16(Repository.Hook("STOCK", "LOTES", "IDLOTE='" + firstreg + "'"));
            int currentbalance = Convert.ToInt32(Repository.Hook("SALDOACTUAL", "PRODUCTOS", "IDPRODUCTO='" + producto + "'"));
            var lastreg = Repository.Harpoon("STOCK", "LOTES", "IDLOTE", "IDPRODUCTO='" + producto + "' AND ESTADO='DISPONIBLE'", "last");

            if (currentbalance > cantidad)
            {
                if (RbPEPS.Checked == true)
                {
                    DataTable data = Repository.Find("LOTES", "IDLOTE, PRECIO, STOCK", condition);
                    if (data != null)
                    {
                        bool response = false;

                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            int _quantity = Convert.ToInt16(data.Rows[2][i]);

                            if (cantidad == 0)
                            {
                                response = true;
                                break;
                            }

                            if (cantidad > _quantity)
                            {
                                cantidad -= _quantity;
                                Repository.Update("LOTES", "ESTADO='AGOTADO'", "IDLOTE='" + data.Rows[0][i] + "'");
                                Repository.Update("LOTES", "STOCK = 0", "IDLOTE='" + data.Rows[3][i] + "'");
                            }
                            else
                            {
                                _quantity -= cantidad;
                                cantidad = 0;
                                Repository.Update("LOTES", "STOCK=" + _quantity, "IDLOTE='" + data.Rows[3][i] + "'");
                            }
                        }
                    }
                }
                else if (RbUEPS.Checked == true)
                {
                    // Implement UEPS logic
                }
                else if (RbAverageCost.Checked == true)
                {
                    // Implement average cost logic
                }
                else
                {
                    Helpers.MsgInfo("HA OCURRIDO UN ERROR AL INDICAR EL TIPO DE INVENTARIO.");
                    errors++;
                    return;
                }
            }
            else
            {
                Helpers.MsgWarning($"NO HAY SUFICIENTE CANTIDAD EN STOCK, LA CANTIDAD EN STOCK ES {currentbalance}");
                errors++;
                return;
            }
        }

        private void InventoryManagement2(string producto, int cantidad)
        {
            string condition = "IDPRODUCTO='" + producto + "' AND ESTADO='DISPONIBLE'";
            //Primer Lote


            string firstreg = Repository.Harpoon("IDLOTE", "LOTES", "IDLOTE", condition, "first");
            int stockl1 = Convert.ToInt16(Repository.Hook("STOCK", "LOTES", "IDLOTE='" + firstreg + "'"));


            int currentbalance = Convert.ToInt32(Repository.Hook("SALDOACTUAL", "PRODUCTOS", "IDPRODUCTO='" + producto + "'"));
            var lastreg = Repository.Harpoon("STOCK", "LOTES", "IDLOTE", "IDPRODUCTO='" + producto + "' AND ESTADO='DISPONIBLE'", "last");

            if (currentbalance >= cantidad)
            {
                if (RbPEPS.Checked == true)
                {
                    DataTable data = Repository.Find("LOTES", "IDLOTE, PRECIO, STOCK", condition);
                    if (data.Rows.Count > 0)
                    {
                        if (stockl1 > 0 && stockl1 > cantidad)
                        {
                            stockl1 = stockl1 - cantidad;

                            if (stockl1 == 0)
                            {
                                Repository.Update("LOTES", "ESTADO='AGOTADO'", "IDLOTE='" + firstreg + "'", "true");
                                Repository.Update("LOTES", "STOCK=0", "IDLOTE='" + firstreg + "'", "true");
                            }
                            else
                            {
                                Repository.Update("LOTES", "STOCK='" + stockl1 + "'", "IDLOTE='" + firstreg + "'", "true");
                            }
                        }
                        else
                        {
                            int _quantity;

                            for (int i = 0; i < data.Rows.Count; i++)
                            {
                                //_quantity = data.Rows[2][i];
                                _quantity = Convert.ToInt16(Helpers.ReturnsNumber(data.Rows[i][2].ToString()));
                                
                                if(cantidad == 0)
                                {
                                    break;
                                }

                                else if (cantidad > _quantity)
                                {
                                    cantidad = cantidad - _quantity;
                                    Repository.Update("LOTES", "ESTADO='AGOTADO'", "IDLOTE='" + data.Rows[i][0] + "'");
                                    Repository.Update("LOTES", "STOCK=0", "IDLOTE='" + data.Rows[i][0] + "'");
                                }
                                else
                                {
                                    _quantity = _quantity - cantidad;
                                    cantidad = 0;
                                    Repository.Update("LOTES", "STOCK=" + _quantity + "", "IDLOTE='" + data.Rows[i][0] + "'");
                                    if (_quantity == 0)
                                    {
                                        Repository.Update("LOTES", "ESTADO='AGOTADO'", "IDLOTE='" + data.Rows[i][0] + "'", "true");
                                        Repository.Update("LOTES", "STOCK=0", "IDLOTE='" + data.Rows[i][0] + "'", "true");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Helpers.MsgWarning("NO HAY UNIDADES DISPONIBLES DEL PRODUCTO SOLICITADO, CONTACTE AL PROVEEDOR!");
                        return;
                    }
                }
                else if (RbUEPS.Checked == true)
                {
                    //
                }
                else if (RbAverageCost.Checked == true)
                {
                    //
                }
                else
                {
                    Helpers.MsgInfo("HA OCURRIDO UN ERROR AL INDICAR EL TIPO DE INVENTARIO!");
                    errors++;
                    return;
                }
            }
            else
            {
                Helpers.MsgWarning($"NO HAY SUFICIENTE CANTIDAD EN STOCK, LA CANTIDAD EN ESTOCK ES {currentbalance}");
                errors++;
                return;
            }
        }



        private void GetProducts()
        {
            DataTable data = Repository.Find("PRODUCTOS", "IDPRODUCTO, PRODUCTO", "", "PRODUCTO");
            CmbProduct.DataSource = data;
            CmbProduct.ValueMember = "IDPRODUCTO";
            CmbProduct.DisplayMember = "PRODUCTO";
            CmbProduct.SelectedIndex = -1;
        }

        private void Seed()
        {
            TxtClient.Text = "JUAN CARLOS BODOQUE";
            TxtRTN.Text = "0401-2000-128859";
            CmbProduct.Text = "PRD000001";
        }
    }
}
