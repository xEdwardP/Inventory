﻿using Inventory.Clases;
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
        Clases.Repository Repository { get; set; }
        Clases.Helpers Helpers { get; set; }

        // Variables
        private string code, client, rtn, product, quantity;

        private string datetoday = DateTime.Today.ToShortDateString().ToString();

        private int errors = 0;

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
            quantity = TxtQuantity.Text.Trim();
        }

        private void InventoryManagement()
        {
            var lastreg = Repository.Hook("ULTIMO", "CORRELATIVOS", "IDCORRE='" + idmodule + "'");
            //string condition = "ID"

            if(RbPEPS.Checked == true)
            {
                //
            }
            else if(RbUEPS.Checked == true)
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
    }
}
