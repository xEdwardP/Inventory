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
        public FrmMovements()
        {
            InitializeComponent();
        }

        private void FrmMovements_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Movimientos | ";
        }
    }
}
