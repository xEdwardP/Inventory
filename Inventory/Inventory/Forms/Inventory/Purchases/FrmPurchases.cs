using Inventory.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms.Inventory.Purchases
{
    public partial class FrmPurchases : Form
    {
        // INSTANCIAS
        Clases.Helpers Helpers = new Clases.Helpers();
        Clases.Repository Repository = new Clases.Repository();

        private int errors = 0, quantity;
        string code, nfact, product, provider, datep;
        double price;
        private string idmodule = "CPR";

        public FrmPurchases()
        {
            InitializeComponent();
        }

        private void FrmPurchases_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Compras | ";
            StartForm();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Clean();
            AutoGenCode();
            StateButtons(false, true, false, false, true, false, false);
            StateControls(true);

            TxtSearch.Clear();
            TxtSearch.Enabled = false;
            BtnSearch.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateData();

            if (errors == 0)
            {
                SetValues();
                string fields = "IDCOMPRA, NFACTURAC, IDPRODUCTO, PRECIOCOMPRA, CANTPRODUCTO, IDPROVEEDOR, FECHACOMPRA";
                string values = "'" + code + "', '" + nfact + "', '" + product + "', " + price + ", " + quantity + ", '" + provider + "', '" + datep + "'";

                if (Repository.Save("COMPRAS", fields, values) > 0)
                {
                    Helpers.MsgSuccess(Messages.MsgSave);
                    Repository.SetLast(idmodule);
                    CreateLote(code);
                    BalanceUpdate();
                    Clean();
                    StartForm();
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

        }

        private void Clean()
        {
            TxtNFact.Clear();
            CmbProduct.SelectedIndex = -1;
            CmbProvider.SelectedIndex = -1;
            TxtPrice.Clear();
            TxtQuantity.Clear();
            DtpDate.Text = DateTime.Today.ToShortDateString().ToString();
        }


        // Metodo StartForm -> Estado por defecto del formulario
        private void StartForm()
        {
            DgvData.Rows.Clear();
            StateButtons(true, false, false, false, true, true, true);
            StateControls(false);
            GetProducts();
            GetProviders();
        }

        // Metodo StateButtons -> Habilita y deshabilita los botones
        private void StateButtons(bool stnew, bool stsave, bool stupdate, bool stdelete, bool stcancel, bool stexit, bool stsearch)
        {
            BtnNew.Enabled = stnew;
            BtnSave.Enabled = stsave;
            BtnDelete.Enabled = stdelete;
            BtnCancel.Enabled = stcancel;
            BtnClose.Enabled = stexit;
            BtnSearch.Enabled = stsearch;
        }

        // Metodo StateControls -> Habilita y deshabilita los controles
        private void StateControls(bool state)
        {
            TxtNFact.Enabled = state;
            CmbProduct.Enabled = state;
            TxtPrice.Enabled = state;
            TxtQuantity.Enabled = state;
            CmbProvider.Enabled = state;
            DtpDate.Enabled = state;
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Helpers.GetOnlyNumbers(e) ? false : true;
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Helpers.GetOnlyNumbers(e) ? false : true;
        }

        // Metodo AutoGenCode -> Genera los codigos para autores
        private void AutoGenCode()
        {
            code = "CPR" + Repository.GetNext(idmodule);
        }

        // Metodo ValidateInfo -> Valida la informacion ingresada en los campos
        private void ValidateData()
        {
            errors = 0;

            if(Helpers.CleanStr(TxtNFact.Text.Trim()).Length == 0)
            {
                Helpers.MsgWarning("INGRESE EL NUMERO DE FACTURA!");
                TxtNFact.Focus();
                errors++;
                return;
            }

            if(CmbProduct.Text == "")
            {
                Helpers.MsgWarning("SELECCION EK PRODUCTO!");
                CmbProduct.Focus();
                errors++;
                return;
            }

            if(TxtQuantity.Text.Trim().Length == 0)
            {
                Helpers.MsgWarning("INGRESE LA CANTIDAD DE PRODUCTO ADQUIRIDA!");
                TxtQuantity.Focus();
                errors++;
                return;
            }

            if(TxtPrice.Text.Trim().Length == 0)
            {
                Helpers.MsgWarning("INGRESE EL PRECIO POR UNIDAD DE PRODUCTO!");
                TxtPrice.Focus();
                errors++;
                return;
            }

            if(CmbProvider.Text.Trim().Length == 0)
            {
                Helpers.MsgWarning("SELECCIONE EL PROVEEDOR / DISTRIBUIDOR DEL PRODUCTO!");
                CmbProvider.Focus();
                errors++;
                return;
            }
        }

        // Metodo SetValues -> Almacenada la informacion de los campos en variables
        private void SetValues()
        {
            nfact = Helpers.CleanStr(TxtNFact.Text.Trim());
            product = CmbProduct.Text != "" ? CmbProduct.SelectedValue.ToString() : "";
            price = Convert.ToDouble(Helpers.CleanStr(TxtPrice.Text.Trim()));
            quantity = Convert.ToInt16(TxtQuantity.Text.Trim());
            provider = CmbProvider.Text != "" ? CmbProvider.SelectedValue.ToString() : "";
            datep = DtpDate.Text;
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

        // METODO GetProviders -> TRAE LOS PROVEEDORES
        private void GetProviders()
        {
            DataTable data = Repository.Find("PROVEEDORES", "IDPROVEEDOR, PROVEEDOR", "", "PROVEEDOR");
            CmbProvider.DataSource = data;
            CmbProvider.ValueMember = "IDPROVEEDOR";
            CmbProvider.DisplayMember = "PROVEEDOR";
            CmbProvider.SelectedIndex = -1;
        }

        // METODO Seed -> INFORMACION PARA CREAR UN EJEMPLO
        private void Seed()
        {
            //
        }

        private void CreateLote(string idpurchase)
        {
            // CODIGO LOTE
            string idlote = "LOT" + Repository.GetNext(idmodule);

            string fields = "IDLOTE, IDCOMPRA, IDPRODUCTO, PRECIO, STOCK";
            string values = "'" + idlote + "', '" + idpurchase + "', '" + product + "', " + price + ", " + quantity + "";

            if(Repository.Save("LOTES", fields, values) > 0)
            {
                Helpers.MsgSuccess("LOTES CREADOS EXITOSAMENTE!");
                Repository.SetLast(idlote);
            }
        }

        private void BalanceUpdate()
        {
            string condition = "IDPRODUCTO='" + product + "'";
            int inventory = Convert.ToInt16(Repository.Hook("INVENTARIO", "PRODUCTOS", condition));
            inventory += quantity;
            Repository.Update("PRODUCTOS", "INVENTARIO=" + inventory + "", condition);

            double sa = Convert.ToDouble(Repository.Hook("SALDOACTUAL", "PRODUCTOS", condition));
            sa = sa + (quantity * price);
            Repository.Update("PRODUCTOS", "SALDOACTUAL=" + sa + "", condition);
        }
    }
}
