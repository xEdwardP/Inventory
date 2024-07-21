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
        private string code, client, rtn, product;

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
            InventoryManagement();
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

            //Seed();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

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
            DgvData.Rows.Clear();
            StateButtons(true, false, false, false, true, true, true, true);
            StateControls(false);
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
        private void ValidateInfo()
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

            if (TxtQuantity.Text.Trim().Length == 0 || Convert.ToDouble(TxtRTN.Text.Trim()) <= 0 )
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
            client = Helpers.CleanStr(TxtClient.Text.Trim());
            rtn = Helpers.CleanStr(TxtRTN.Text.Trim());
            product = CmbProduct.Text != "" ? CmbProduct.SelectedValue.ToString() : "";
            quantity = Convert.ToInt16(TxtQuantity.Text.Trim());
        }

        private void InventoryManagement()
        {
            product = "PRD000001";
            string condition = "IDPRODUCTO='" + product + "' AND ESTADO='DISPONIBLE'";
            string firstreg = Repository.Harpoon("IDLOTE", "LOTES", "IDLOTE", condition, "first");
            int stockl1 = Convert.ToInt16(Repository.Hook("STOCK", "LOTES", "IDLOTE='" + firstreg + "'"));
            // Helpers.MsgInfo(fistreg.ToString());

            int currentbalance = Convert.ToInt32(Repository.Hook("SALDOACTUAL", "PRODUCTOS", "IDPRODUCTO='" + product + "'"));

            var lastreg = Repository.Harpoon("STOCK", "LOTES", "IDLOTE", "IDPRODUCTO='" + product + "' AND ESTADO='DISPONIBLE'", "last");
            // Helpers.MsgInfo(lastreg.ToString());

            if (currentbalance > quantity)
            {
                if (RbPEPS.Checked == true)
                {
                    if (stockl1 > 0)
                    {
                        DataTable data = Repository.Find("LOTES", "IDPRODUCTO, PRECIO, STOCK", condition);
                        if (data != null)
                        {
                            foreach (DataRow row in data.Rows)
                            {
                                if (Convert.ToInt16(row[0]) > quantity)
                                {
                                    int decrease = stockl1 - quantity;
                                    if (Repository.Update("LOTES", "STOCK='" + stockl1 + "'", "IDLOTE='" + firstreg + "'") > 0)
                                    {
                                        //
                                    }
                                    if (stockl1 == 0)
                                    {
                                        if(Repository.Update("LOTES", "ESTADO='AGOTADO'", "IDLOTE='" + row[0] +"'", "true") > 0)
                                        {
                                            //
                                        }
                                    }
                                }
                                else
                                {
                                    int diference = 0;

                                    for(int i = 0; quantity > 0; i++)
                                    {
                                       diference = quantity - Convert.ToInt16(data.Rows[1][i]);
                                    }
                                }
                            }
                        }
                        



                        //if (stockl1 > quantity)
                        //{
                        //    int decrease = stockl1 - quantity;
                        //    if (Repository.Update("LOTES", "STOCK='" + stockl1 + "'", "IDLOTE='" + firstreg + "'") > 0)
                        //    {
                        //        //
                        //    }
                        //    else
                        //    {
                        //        DataTable data = Repository.Find("LOTES", "IDPRODUCTO, PRECIO, STOCK", condition);
                        //        if (data != null)
                        //        {
                        //            foreach(DataRow dr in data.Rows)
                        //            {
                        //                if(stockl1 > quantity)
                        //                {
                        //                    int decrease = stockl1 - quantity;
                        //                    if (Repository.Update("LOTES", "STOCK='" + stockl1 + "'", "IDLOTE='" + firstreg + "'") > 0)
                        //                    {
                        //                        //
                        //                    }
                        //                }
                        //            }
                        //        }
                        //        int dif = quantity - stockl1;

                        //    }
                        //}
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
                    //
                }
            }
            else
            {
                Helpers.MsgWarning($"NO HAY SUFICIENTE CANTIDAD EN STOCK, LA CANTIDAD EN ESTOCK ES {currentbalance}");
                return;
            }
        }
    }
}
