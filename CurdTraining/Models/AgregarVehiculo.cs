using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdTraining.Models
{
    internal class AgregarVehiculo
    {
        private SqlCommand _command;
        private SqlDataReader _reader;
        private string userNameDB;
        private string passwordDB;

        public SqlCommand Command { get => _command; set => _command = value; }
        public SqlDataReader Reader { get => _reader; set => _reader = value; }

        public void AgregarVehiculoDB(string placa, int fabricante,string referencia,string modelo,string foto,string precio,string propietario, SqlConnection conexion)
        {


            try
            {
                string query = "insert into vehiculos (placa,fabricante,referencia,modelo,foto,precio,propietario) values" +
                    "(@placa,@fabricante,@referencia,@modelo,@foto,@precio,@propietario)";
                Command = new SqlCommand(query, conexion);
                Command.Parameters.AddWithValue("@placa", placa);
                Command.Parameters.AddWithValue("@fabricante", fabricante);
                Command.Parameters.AddWithValue("@referencia", referencia);
                Command.Parameters.AddWithValue("@modelo", modelo);
                Command.Parameters.AddWithValue("@foto", foto);
                Command.Parameters.AddWithValue("@precio", precio);
                Command.Parameters.AddWithValue("@propietario", propietario);

                Command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
