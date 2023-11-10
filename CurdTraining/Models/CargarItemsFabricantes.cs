using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdTraining.Models
{
    internal class CargarItemsFabricantes
    {
        private SqlCommand _command;
        private SqlDataReader _reader;
        private string userNameDB;
        private string passwordDB;

        public SqlCommand Command { get => _command; set => _command = value; }
        public SqlDataReader Reader { get => _reader; set => _reader = value; }

        public List<string> CargarFabricantesDB(SqlConnection conexion) 
        {

            List<string> fabricantes = new List<string>();
            try
            {
                string query = "select nombre from fabricantes";
                Command = new SqlCommand(query, conexion);

                Reader = Command.ExecuteReader();

                while (Reader.Read()) 
                {
                    fabricantes.Add(Reader.GetString(0));
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            return fabricantes;


        }
    }
}
