using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Forms.Auth
{
    public partial class FrmLogin : Form
    {
        //Instancias
        Clases.Helpers helpers = new Clases.Helpers();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Text = Clases.App.AppName + " | Iniciar Sesion | ";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var home = new Forms.FrmHome();
            home.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            string msg = "¿ESTA SEGURO QUE DESEA ABANDONAR LA APLICACION?";
            if (helpers.MsgQuestion(msg) == "S")
            {
                Application.Exit();
            }
        }
    }
}
