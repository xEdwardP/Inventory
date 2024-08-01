using Inventory.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms.Inventory
{
    public partial class FrmInventory : Form
    {
        Clases.Repository Repository = new Clases.Repository();
        Clases.Helpers helpers = new Clases.Helpers();

        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = helpers.CleanStr(TxtSearch.Text.Trim());
            GetProducts(search);
        }

        private void BtnCleanSearch_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            DgvData.Rows.Clear();
        }

        private void GetProducts(string search = "")
        {
            string condition = "";
            string fields = "IDPRODUCTO, PRODUCTO, SALDOINICIAL, SALDOACTUAL, INVENTARIO";

            if (search != null)
            {
                condition = "PRODUCTO LIKE '%" + search + "%'";
            }

            DataTable data = Repository.Find("PRODUCTOS", fields, condition);
            DgvData.Rows.Clear();

            if(data.Rows.Count > 0)
            {
                string _idproduct, _product;
                double _sinicial, _sactual, _inventory;
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    _idproduct = data.Rows[i][0].ToString();
                    _product = data.Rows[i][1].ToString();
                    _sinicial = helpers.ReturnsNumber(data.Rows[i][2].ToString());
                    _sactual = helpers.ReturnsNumber(data.Rows[i][3].ToString());
                    _inventory = helpers.ReturnsNumber(data.Rows[i][4].ToString()); 

                    DgvData.Rows.Add(_idproduct, _product, _sinicial, _sactual, _inventory);
                }
                data.Dispose();
            }
            else
            {
                helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }
    }
}
