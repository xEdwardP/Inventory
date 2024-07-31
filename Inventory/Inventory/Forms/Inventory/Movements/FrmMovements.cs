using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms.Inventory.Movements
{
    public partial class FrmMovements : Form
    {
        // INSTANCIAS
        Clases.Helpers Helpers = new Clases.Helpers();
        Clases.Repository Repository = new Clases.Repository();

        public FrmMovements()
        {
            InitializeComponent();
        }

        private void FrmMovements_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Movimientos | ";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            if (Helpers.MsgQuestion(Clases.Messages.MsgCancel) == "S")
            {
                DgvData.Rows.Clear();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetMovements()
        {
            string query = "";
            DataTable data = new DataTable();
            data = Repository.JoinTables(query);
        }
    }
}
