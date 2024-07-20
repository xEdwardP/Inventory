using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.Clases
{
    public class Repository
    {
        Clases.Helpers h = new Clases.Helpers();
        public SqlCommand com;
        SqlDataReader reader;
        DataTable recordset;
        string query;

        //Metodo Save
        //inserta registros en la base de datos
        public int Save(string table, string fields, string values, string debug = "")
        {
            int ra = 0; //rowsaffected
            query = "INSERT INTO " + table + "(" + fields + ") VALUES(" + values + ")";

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return ra;
        }
        //fin Metodo Save

        //Metodo Update
        //Actualizar los registros de la base de datos
        public int Update(string table, string values, string condition = "", string debug = "")
        {
            int ra = 0; //rowsaffected
            if (condition == "")
            {
                query = "UPDATE " + table + " SET " + values;
            }
            else
            {
                query = "UPDATE " + table + " SET " + values + " WHERE " + condition;
            }

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return ra;
        }
        //Actualiza registros existentes
        //Fin Metodo Update

        //Metodo Destroy
        //Elimina registros de la base de datos
        public int Destroy(string table, string condition = "")
        {
            int ra = 0;
            if (condition == "")
            {
                query = "DELETE FROM " + table;
            }
            else
            {
                query = "DELETE FROM " + table + " WHERE " + condition;
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                ra = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return ra;
        }
        //Fin Metodo Destroy

        //Metodo Delete
        //Marca como eliminado el registro seleccionado
        public int Delete(string table, string pk, string value)
        {
            int rd = 0;
            try
            {
                query = "UPDATE " + table + " SET DEL='S' WHERE " + pk + "='" + value + "'";
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();

                rd = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return rd;
        }
        //Fin Delete

        //Metodo Rocket utilizado para Agregar, Actualizar y Eliminar Registros de la Base de Datos
        public void Rocket(string Query, String Msg)
        {
            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                com.ExecuteNonQuery();

                MessageBox.Show(Msg, "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
        }
        //Fin Metodo Rocket


        public string CheckIfExists(string Tabla, string condition)
        {
            string Response = "N";
            try
            {
                query = "SELECT * FROM " + Tabla + " WHERE " + condition;

                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    Response = "S";
                }

                reader.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return Response;
        }

        //Verifica si un codigo ya existe
        public bool VerifyIfExists(string Tabla, string Pk, string Id)
        {
            bool Response = false;
            try
            {
                string Query = "SELECT * FROM " + Tabla + " WHERE " + Pk + "='" + Id + "'";

                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                SqlDataReader TableReader;
                Clases.Conexion.OpenConnection();
                TableReader = com.ExecuteReader();

                if (TableReader.Read())
                {
                    Response = true;
                }

                TableReader.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return Response;
        }

        //Metodo Hook, utilizado para traer un solo campo de la base de datos
        public string Hook(string Campo, string Tabla, string Condicion = "")
        {
            string Fish = "";
            try
            {
                if (Condicion == "")
                {
                    query = "SELECT " + Campo + " AS FISH FROM " + Tabla + " ";
                }
                else
                {
                    query = "SELECT " + Campo + " AS FISH FROM " + Tabla + " WHERE " + Condicion;
                }

                com = new SqlCommand(query, Clases.Conexion.ConSql);
                SqlDataReader Recordset;
                Clases.Conexion.OpenConnection();
                Recordset = com.ExecuteReader();
                if (Recordset.Read())
                {
                    Fish = Recordset["FISH"].ToString();
                }

                Recordset.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                string[,] parameters = new string[1, 2];
                parameters[0, 0] = "@log"; parameters[0, 1] = query;
                ExecSPInsert("SP_LogHook", parameters);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return Fish;
        }
        //fin metodo hook

        //Metodo GetDataRequired, utilizado para traer Informacion de la base de datos
        public DataTable RawSelect(string Query, string debug = "")
        {
            DataTable RecordSet = new DataTable();

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                SqlDataReader DrRecordSet;
                Clases.Conexion.OpenConnection();

                DrRecordSet = com.ExecuteReader();
                RecordSet.Load(DrRecordSet);

                DrRecordSet.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return RecordSet;
        }
        //Fin Metodo DataRequired

        //Metodo GetNext, Utilizado para Generar Correlativos
        public string GetNext(string Id)
        {
            string Next = "";
            string condition;
            condition = "WHERE IDCORRE ='" + Id + "'";


            string Query = "SELECT ULTIMO + 1 AS NEXT FROM CORRELATIVOS " + condition;
            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                SqlDataReader DrNext;
                DrNext = com.ExecuteReader();

                Int32 Corre = 0;
                if (DrNext.Read())
                {
                    Corre = Convert.ToInt32(DrNext["NEXT"].ToString());
                }
                else
                {
                    h.MsgWarning("ERROR AL GENERAR EL CORRELATIVO, CONTACTAR AL ADMINISTRADOR");
                }

                DrNext.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();

                if (Corre >= 1 && Corre <= 9)
                {
                    Next = "00000" + Corre.ToString();
                }
                else if (Corre >= 10 && Corre <= 99)
                {
                    Next = "0000" + Corre.ToString();
                }
                else if (Corre >= 100 && Corre <= 999)
                {
                    Next = "000" + Corre.ToString();
                }
                else if (Corre >= 1000 && Corre <= 9999)
                {
                    Next = "00" + Corre.ToString();
                }
                else if (Corre >= 10000 && Corre <= 99999)
                {
                    Next = "0" + Corre.ToString();
                }
                else if (Corre >= 100000 && Corre <= 999999)
                {
                    Next = Corre.ToString();
                }
                else
                {
                    h.MsgWarning("ERROR AL GENERAR EL CORRELATIVO, HA LLEGADO AL MÁXIMO!");
                }
            }
            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }

            return Next;
        }
        //Fin Metodo GetNext

        //Metodo SetLast, Utilizado para Establecer el ultimo Correlativo Asignado
        public void SetLast(string Id)
        {
            string condition;
            condition = "WHERE IDCORRE='" + Id + "'";


            string Query = "Update Correlativos set Ultimo = Ultimo + 1 where IdCorre='" + Id + "'";

            try
            {
                com = new SqlCommand(Query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                h.MsgWarning(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
        }
        //Fin Metodo SetLast;

        public DataTable Find(string table, string fields, string condition = "", string orderby = "", string debug = "")
        {
            recordset = new DataTable();

            if (condition == "" && orderby == "")
            {
                query = "SELECT " + fields + " FROM " + table;
            }
            else if (condition != "" && orderby == "")
            {
                query = "SELECT " + fields + " FROM " + table + " WHERE " + condition;
            }
            else if (condition == "" && orderby != "")
            {
                query = "SELECT " + fields + " FROM " + table + " ORDER BY " + orderby;
            }
            else if (condition != "" && orderby != "")
            {
                query = "SELECT " + fields + " FROM " + table + " WHERE " + condition + " ORDER BY " + orderby;
            }

            if (debug == "True")
            {
                MessageBox.Show(query);
                Clipboard.SetText(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();
                recordset.Load(reader);

                reader.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return recordset;
        }

        //Metodo JoinTables
        //Combinar los datos de más tablas
        public DataTable JoinTables(string data, string condition = "", string orderby = "", string debug = "")
        {
            recordset = new DataTable();
            if (condition == "" && orderby == "")
            {
                query = "SELECT " + data;
            }
            else if (condition != "" && orderby == "")
            {
                query = "SELECT " + data + " WHERE " + condition;
            }
            else if (condition != "" && orderby != "")
            {
                query = "SELECT " + data + " WHERE " + condition + " ORDER BY " + orderby;
            }
            else if (condition == "" && orderby != "")
            {
                query = "SELECT " + data + " ORDER BY " + orderby;
            }

            if (debug == "True")
            {
                MessageBox.Show(query);
            }

            try
            {
                com = new SqlCommand(query, Clases.Conexion.ConSql);
                Clases.Conexion.OpenConnection();
                reader = com.ExecuteReader();
                recordset.Load(reader);

                reader.Close();
                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return recordset;
        }
        //Fin JoinTables

        public int ExecSPInsert(string SPName, string[,] Params)
        {
            int rowsinserted = 0;
            try
            {
                com = new SqlCommand(SPName, Clases.Conexion.ConSql);
                com.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < Params.GetLength(0); i++)
                {
                    string paramname, value;
                    paramname = Params[i, 0];
                    value = Params[i, 1];
                    com.Parameters.AddWithValue(paramname, value);
                }
                Clases.Conexion.OpenConnection();
                rowsinserted = com.ExecuteNonQuery();

                com.Dispose();
                Clases.Conexion.CloseConnection();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                Clases.Conexion.EndsConnection();
            }
            return rowsinserted;
        }
    }
}
