using System;
using System.Globalization;
using System.Windows.Forms;

namespace Inventory.Clases
{
    public class Helpers
    {
        //Metodo MsgWarning -> Muestra un cuadro de dialogo al usuario mostrando un mensaje de atencion
        public void MsgWarning(string msg, string title = "ATENCION")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Metodo MsgSuccess -> Muestra un cuadro de dialogo al usuario mostrando un mensaje de exito
        public void MsgSuccess(string msg, string title = "EXITO")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo MsgQuestion ->Muestra un cuadro de dialogo al usuario mostrando un mensaje de pregunta
        public string MsgQuestion(string msg)
        {
            string resp = "N";

            if (MessageBox.Show(msg, "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                resp = "S";
            }

            return resp;
        }

        //Metodo MsgError -> Muestra un cuadro de dialogo al usuario mostrando un mensaje de error
        public void MsgError(string msg)
        {
            MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo MsgInfo --> Muestra un cuadro de dialogo al usuario mostrando un mensaje de informacion
        public void MsgInfo(string msg)
        {
            MessageBox.Show(msg, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metodo CleanStr -> Limpia una cadena de Texto de caracteres quitando los no validos
        public string CleanStr(string str)
        {
            string strout = ""; //Cadena de salida
            //Arreglo caracteres prohibidos
            string[] forbiddenchars = { "'", "=", "<", ">", ";", "/", "!", "´", "$" };
            int i, j; //variables para iterar ciclos
            int coinc; //coincidencias

            for (i = 0; i < str.Length; i++)
            {
                coinc = 0;
                for (j = 0; j < forbiddenchars.Length; j++)
                {
                    coinc = str.Substring(i, 1) == forbiddenchars[j] ? coinc + 1 : coinc + 0;
                }
                strout = coinc == 0 ? strout + str.Substring(i, 1) : strout;
            }

            return strout;
        }

        //Fin SanitizeStr

        //Metodo GetOnlyNumbers -> Permite ingresar solo numeros
        public Boolean GetOnlyNumbers(KeyPressEventArgs e)
        {
            Boolean resp = false;
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                resp = true;
            }
            return resp;
        }

        public Boolean GetMoneyValue(KeyPressEventArgs e)
        {
            Boolean resp = false;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (Char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar == (char)8)
            {
                resp = true;
            }
            return resp;
        }

        public void AlertNotNumber(string numberstr)
        {
            double number;
            if (!double.TryParse(numberstr, out number))
            {
                MessageBox.Show("EL VALOR DEBE SER NUMERICO", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string ValidateNumber(string numberstr)
        {
            string resp = "N";
            double number;
            if (double.TryParse(numberstr, out number))
            {
                resp = "S";
            }

            return resp;
        }

        public double ReturnsNumber(string str)
        {
            double double_value = 0;
            if (double.TryParse(str, out double_value))
            {
                double_value = Convert.ToDouble(str);
            }
            else
            {
                double_value = 0;
            }
            return double_value;
        }
    }
}