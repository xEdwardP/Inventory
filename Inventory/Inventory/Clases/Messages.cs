using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Clases
{
    public class Messages
    {
        // DELETE
        public static string MsgDelete = "¿DESEA ELIMINAR EL REGISTRO SELECCIONADO?";

        public static string MsgDeletedSuccessfully = "EL REGISTRO SE ELIMINO CORRECTAMENTE DE LA BASE DE DATOS!";

        // CANCEL
        public static string MsgCancel = "¿DESEA CANCELAR LA OPERACION EN CURSO?";

        // UPDATE
        public static string MsgUpdate = "¿DESEA GUARDAR LOS CAMBIOS EN EL REGISTRO SELECCIONADO?";

        public static string MsgUpdatedSuccessfully = "LOS CAMBIOS SE APLICARON CORRECTAMENTE!";

        // SAVE
        public static string MsgSave = "REGISTRADO CREADO CON EXITO!";

        // ERRORS
        public static string MsgErrorInfo = "ERROR AL RECUPERAR LOS DATOS DEL REGISTRO SELECCIONADO!";

        public static string MsgNotFound = "NO SE ENCONTRARON COINCIDENCIAS!";
    }
}