using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Mwnu Principal | ";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            var purchases = new Inventory.Purchases.FrmPurchases();
            purchases.MdiParent = this;
            purchases.Show();
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            var sales = new Inventory.Sales.FrmSales();
            sales.MdiParent = this;
            sales.Show();
        }

        private void BtnMovements_Click(object sender, EventArgs e)
        {
            var movements = new Inventory.Movements.FrmMovements();
            movements.MdiParent = this;
            movements.Show();
        }
    }
}
