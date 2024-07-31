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

namespace Inventory.Forms.Inventory.Purchases
{
    public partial class FrmLote : Form
    {
        // INSTANCIAS
        Clases.Helpers Helpers = new Clases.Helpers();
        Clases.Repository Repository = new Clases.Repository();

        public FrmLote()
        {
            InitializeComponent();
        }

        private void FrmLote_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Lotes | ";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // METODO GETLOTE -> TRAE LOS LOTES GUARDADOS EN LA BASE DE DATOS
        private void GetLotes(string search = "")
        {
            string condition = "";
            string query = "A.IDLOTE, A.IDCOMPRA, B.PRODUCTO, A.PRECIO, A.STOCK, A.FECHA FROM LOTES A INNER JOIN PRODUCTOS B ON (A.IDPRODUCTO = B.IDPRODUCTO)";

            DataTable data = new DataTable();

            if (search != "")
            {
                condition = "B.PRODUCTO LIKE '%" + search + "%'";
                data = Repository.JoinTables(query, condition);
            }
            else
            {
                data = Repository.JoinTables(query);
            }
            DgvData.Rows.Clear();

            string _idlote, _idpurchase, _product, _datep;
            double _price, _stock;

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    _idlote = data.Rows[i][0].ToString();
                    _idpurchase = data.Rows[i][1].ToString();
                    _product = data.Rows[i][2].ToString();
                    _price = Helpers.ReturnsNumber(data.Rows[i][3].ToString());
                    _stock = Helpers.ReturnsNumber(data.Rows[i][4].ToString());
                    _datep = data.Rows[i][5].ToString();

                    DgvData.Rows.Add(_idlote, _idpurchase, _product, _price.ToString("N2"), _stock, _datep);
                }
                data.Dispose();
            }
            else
            {
                Helpers.MsgWarning(Clases.Messages.MsgNotFound);
            }
        }

        // FILTRO DE BUSQUEDA
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search = Helpers.CleanStr(TxtSearch.Text.Trim());
            GetLotes(search);
        }

        // METODO CLEANSEARCH -> LIMPIA EL FILTRO DE BUSQUEDA
        private void BtnCleanSearch_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            DgvData.Rows.Clear();
        }
    }
}
