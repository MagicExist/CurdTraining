using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace CurdTraining.Models
{
    internal class AbrirConexionDB
    {
        private SqlConnection _connection;

        public SqlConnection Connection { get => _connection; set => _connection = value; }

        public AbrirConexionDB()
        {
            
        }

        public SqlConnection abrirConexion() 
        {
            try 
            {
                string conexion = ConfigurationManager.ConnectionStrings["ConexionDB"].ToString();
                Connection = new SqlConnection(conexion);
                Connection.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            



            return Connection;
        }
    }
}
