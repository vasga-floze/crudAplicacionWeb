using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace crudAplicacionWeb
{
    public class Crud
    {
        //varibles que nos serviran para generar consultas a la base de datos
        public SqlConnection conexion = new SqlConnection
          (@"Data Source=DESKTOP-N9NF705;Initial Catalog=bdTallerMecanico;Integrated Security=True");
        public SqlDataAdapter da;
        public SqlCommand comando;
        public SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataReader dr;

        //metodo para conectar a la base de datos
        public void ConectarBD()
        {
            try
            {
                conexion.Open();
                // MessageBox.Show("Conexion Exitosa");
            }
            catch
            {
                conexion.Close();
            }
            finally
            {
                conexion.Close();
            }

        }

        public void cerrarConn()
        {
            conexion.Close();
        }


        //funcion para generar clave shah
        public string generarClaveSHA1(string cadena)
        {
            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            //Devolvemos la cadena con el hash en minúsculas
            return sb.ToString().ToLower();
        }
        /* función para consultar o leer un registro o texto 
         En el caso del login solo se utiliza para validar que 
         la consulta devuelva datos, en este caso True.
         */

        public void ConsultarTexto(string Cadenasql)
        {
            conexion.Open();
            comando = new SqlCommand(Cadenasql, conexion);
            dr = comando.ExecuteReader();
        }

        // CRUD: create, read, update, delete.
        public bool operacion(string sql)
        {
            conexion.Close();
            conexion.Open();
            comando = new SqlCommand(sql, conexion);
            int i = comando.ExecuteNonQuery();
            conexion.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Esta consulta es para llenar el control DataGridView
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conexion);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

    }
}
