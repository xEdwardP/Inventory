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
    public partial class FrmPurchases : Form
    {
        public FrmPurchases()
        {
            InitializeComponent();
        }

        private void FrmPurchases_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Compras | ";
        }
    }
}
