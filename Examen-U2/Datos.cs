using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen_U2
{
    class Datos
    {
        String cadenaConexion = "Data Source=THINKPAD_CJ\\SQLEXPRESS;" +
            "integrated security=true;initial catalog=agenda; encrypt=false";
        SqlConnection conexion;

        private SqlConnection AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open(); //Abrir conexion a base de datos
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool prueba()
        {
            try
            {
                AbrirConexion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public DataSet consulta(String consulta)
        {
            try
            {
                DataSet dS = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, AbrirConexion());
                sqlDataAdapter.Fill(dS);
                return dS;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString);
                return null;
            }
        }

        public bool cmd(string consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, AbrirConexion());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }
    }
}
