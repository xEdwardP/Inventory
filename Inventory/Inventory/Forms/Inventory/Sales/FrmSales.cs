using Inventory.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace Inventory.Forms.Inventory.Sales
{
    public partial class FrmSales : Form
    {
        // Instancias
        private Clases.Repository Repository = new Clases.Repository();

        private Clases.Helpers Helpers = new Clases.Helpers();

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
            //AutoGenCode();
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
                InventoryManagement();

                if (errors == 0)
                {
                    // SALDO
                    string condition = "IDPRODUCTO='" + product + "'";
                    int st = Convert.ToInt16(Repository.Hook("INVENTARIO", "PRODUCTOS", condition));
                    st -= quantity;
                    if (Repository.Update("PRODUCTOS", "SALDOACTUAL='" + st + "'", condition) > 0)
                    {
                        Helpers.MsgSuccess(Clases.Messages.MsgSave);
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
            //
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Buscador
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = Helpers.CleanStr(TxtSearch.Text.Trim());
            GetSales(search);
        }

        // Solo Permite Ingresar Numeros
        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Helpers.GetOnlyNumbers(e) ? false : true;
        }

        private void TxtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Helpers.GetOnlyNumbers(e) ? false : true;
        }
        // Fin

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
            BtnDelete.Enabled = stdelete;
            BtnCancel.Enabled = stcancel;
            BtnClose.Enabled = stexit;

            TxtSearch.Enabled = stsearch;
            BtnSearch.Enabled = stsearch;

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

            if (TxtRTN.Text.Trim().Length < 13)
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

            if (TxtQuantity.Text.Trim().Length == 0 || Convert.ToDouble(TxtQuantity.Text.Trim()) <= 0)
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

        // Metodo CalcInventory -> REALIZA LOS CALCULOS DE INVENTARIO
        private void CalcInventory(string producto, int cantidad, string orderby)
        {
            string condition = "IDPRODUCTO='" + producto + "' AND ESTADO='DISPONIBLE'";
            int currentbalance = Convert.ToInt32(Repository.Hook("INVENTARIO", "PRODUCTOS", "IDPRODUCTO='" + producto + "'")); // INVENTARIO ACTUAL

            if (currentbalance >= cantidad && cantidad > 0)
            {
                // Buscamos los lotes
                DataTable data = Repository.Find("LOTES", "IDLOTE, PRECIO, STOCK", condition, orderby);

                if (data.Rows.Count > 0)
                {
                    int _quantity;
                    double total, price, cant;
                    string fields = "", values = "";

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        _quantity = Convert.ToInt16(Helpers.ReturnsNumber(data.Rows[i][2].ToString())); // CANTIDAD EN LOTE

                        if (cantidad == 0)
                        {
                            break; // FIN DEL BUCLE
                        }
                        else if (cantidad > _quantity)
                        {
                            // RECUPERANDO LA INFORMACION DE LA VENTA
                            cant = 0;
                            price = Convert.ToDouble(data.Rows[i][1].ToString()); // PRECIO UND
                            cant = Convert.ToDouble(_quantity); // CANTIDAD VENDIDA DEL LOTE
                            total = cant * price;

                            //p
                            CalcBalance(producto, total);

                            // RESTANDO LA CANTIDAD SOLICITADA - LA CANTIDAD DISPONIBLE EN EL LOTE
                            cantidad = cantidad - _quantity;

                            // ACTUALIZANDO EL STOCK
                            Repository.Update("LOTES", "ESTADO='AGOTADO'", "IDLOTE='" + data.Rows[i][0] + "'");
                            Repository.Update("LOTES", "STOCK=0", "IDLOTE='" + data.Rows[i][0] + "'");

                            // GUARDANDO LA VENTA
                            AutoGenCode();
                            fields = "IDVENTA, NFACTV, CLIENTE, RTN, IDPRODUCTO, CANTIDAD, TOTAL, IDLOTE";
                            values = "'" + code + "', '" + nfact + "', '" + client + "', '" + rtn + "', '" + product + "', " + cant + ", " + total + ", '" + data.Rows[i][0] + "'";
                            Repository.Save("VENTAS", fields, values);
                            Repository.SetLast(idmodule);
                        }
                        else if (_quantity >= cantidad)
                        {
                            // RECUPERANDO LA INFORMACION DE LA VENTA
                            cant = 0;
                            price = Convert.ToDouble(data.Rows[i][1].ToString()); // PRECIO UND
                            cant = Convert.ToDouble(cantidad); // CANTIDAD VENDIDA DEL LOTE
                            total = cant * price;

                            // RESTANDO LA CANTIDAD DISPONIBLE EN EL LOTE - LA CANTIDAD SOLICITADA
                            _quantity = _quantity - cantidad;
                            cantidad = 0;

                            // ACTUALIZANDO EL STOCK
                            Repository.Update("LOTES", "STOCK=" + _quantity + "", "IDLOTE='" + data.Rows[i][0] + "'");
                            
                            // P
                            CalcBalance(producto, total);

                            // GUARDANDO LA VENTA
                            AutoGenCode();
                            fields = "IDVENTA, NFACTV, CLIENTE, RTN, IDPRODUCTO, CANTIDAD, TOTAL, IDLOTE";
                            values = "'" + code + "', '" + nfact + "', '" + client + "', '" + rtn + "', '" + product + "', " + cant + ", " + total + ", '" + data.Rows[i][0] + "'";
                            Repository.Save("VENTAS", fields, values);
                            Repository.SetLast(idmodule);

                            if (_quantity == 0)
                            {
                                // ACTUALIZANDO EL STOCK
                                Repository.Update("LOTES", "ESTADO='AGOTADO'", "IDLOTE='" + data.Rows[i][0] + "'", "true");
                                Repository.Update("LOTES", "STOCK=0", "IDLOTE='" + data.Rows[i][0] + "'", "true");
                            }
                        }
                        else
                        {
                            Helpers.MsgWarning("OCURRIO UN ERROR AL TRATAR DE REALIZAR LOS CALCULOS DE LOTES!");
                            return;
                        }
                    }
                }
                else
                {
                    Helpers.MsgWarning("NO HAY UNIDADES DISPONIBLES DEL PRODUCTO SOLICITADO, CONTACTE AL PROVEEDOR!");
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

        // METODO InventoryManagement -> MANEJO DE OPCIONES DE INVENTARIO
        private void InventoryManagement()
        {
            if(RbPEPS.Checked == true)
            {
                CalcInventory(product, quantity, "IDLOTE");
            }
            else if (RbUEPS.Checked == true)
            {
                CalcInventory(product, quantity, "IDLOTE DESC");
            }
            else if (RbAverageCost.Checked == true)
            {
                WeightedValues(product, quantity);
            }
            else
            {
                Helpers.MsgWarning("HA OCURRIDO UN ERROR CON EL TIPO DE INVENTARIO ELEGIDO!");
                StartForm();
            }
        }

        // METODO GetProducts -> TRAE LOS PRODUCTOS
        private void GetProducts()
        {
            DataTable data = Repository.Find("PRODUCTOS", "IDPRODUCTO, PRODUCTO", "", "PRODUCTO");
            CmbProduct.DataSource = data;
            CmbProduct.ValueMember = "IDPRODUCTO";
            CmbProduct.DisplayMember = "PRODUCTO";
            CmbProduct.SelectedIndex = -1;
        }

        // METODO Seed -> INFORMACION PARA CREAR UN EJEMPLO
        private void Seed()
        {
            TxtClient.Text = "JUAN CARLOS BODOQUE";
            TxtRTN.Text = "0401-2000-128859";
            CmbProduct.Text = "PRD000001";
        }

        // Metodo WeightedValues -> Calcular el promedio del valor del producto
        private void WeightedValues(string prod, double quant)
        {
            string condition = "ESTADO='DISPONIBLE'";
            double nlotes = Convert.ToDouble(Repository.GetNumRows("LOTES", condition));
            double sumpricebd = Convert.ToDouble(Repository.GetSumField("PRECIO", "LOTES", condition));

            double averageprice = sumpricebd / nlotes;

            double total = averageprice * quant;

            double inventory = Convert.ToDouble(Repository.Hook("INVENTARIO", "PRODUCTOS", "IDPRODUCTO='" + product + "'"));

            inventory -= quantity;

            if (Repository.Update("PRODUCTOS", "INVENTARIO=" + inventory + "", "IDPRODUCTO='" + product + "'") > 0)
            {
                Helpers.MsgSuccess("SE RESTARON UNIDADES DE INVENTARIO!");
            }

            // GUARDANDO LA VENTA
            AutoGenCode();
            string fields = "IDVENTA, NFACTV, CLIENTE, RTN, IDPRODUCTO, CANTIDAD, TOTAL";
            string values = "'" + code + "', '" + nfact + "', '" + client + "', '" + rtn + "', '" + product + "', " + quant + ", " + total + "";
            if (Repository.Save("VENTAS", fields, values) > 0)
            {
                Repository.SetLast(idmodule);
                Helpers.MsgSuccess("LA VENTA SE REGISTRO EXITOSAMENTE!");
            }
        }

        // Metodo GetSales -> Obtener los registros de ventas para mostrarlos en un data gried view
        private void GetSales(string search = "")
        {
            string condition = "";
            string query = "A.IDVENTA, A.NFACTV, A.CLIENTE, B.PRODUCTO, A.CANTIDAD, A.TOTAL, A.IDLOTE, A.FECHAVENTA FROM VENTAS A INNER JOIN PRODUCTOS B ON (A.IDPRODUCTO=B.IDPRODUCTO)";

            DataTable data = new DataTable();
            
            if(search != "")
            {
                data = Repository.JoinTables(query, condition);
            }
            else
            {
                data = Repository.JoinTables(query);
            }

            DgvData.Rows.Clear();

            string _idventa, _nfactv, _client, _product, _idlote, _datev;
            double _quantity, _total;

            if(data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    _idventa = data.Rows[i][0].ToString();
                    _nfactv = data.Rows[i][1].ToString();
                    _client = data.Rows[i][2].ToString();
                    _product = data.Rows[i][3].ToString();
                    _quantity = Helpers.ReturnsNumber(data.Rows[i][4].ToString());
                    _total = Helpers.ReturnsNumber(data.Rows[i][5].ToString());
                    _idlote = data.Rows[i][6].ToString();
                    _datev = data.Rows[i][7].ToString();

                    DgvData.Rows.Add(_idventa, _nfactv, _client, _product, _quantity, _total, _idlote, _datev);
                }
                data.Dispose();
            }
            else
            {
                Helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }

        // Metodo CalcBalance -> Actualiza el saldo actual del producto
        private void CalcBalance(string productsale, double totalsale)
        {
            string condition = "IDPRODUCTO='" + productsale + "'";
            double balance = Convert.ToDouble(Repository.Hook("SALDOACTUAL", "PRODUCTOS", condition));

            balance = balance - totalsale;

            if (Repository.Update("PRODUCTOS", "SALDOACTUAL=" + balance + "", condition) > 0)
            {
                Helpers.MsgSuccess("EL SALDO SE HA ACTUALIZADO!");
            }
        }
    }
}