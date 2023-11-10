using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurdTraining.Models
{
    internal class IniciarSesion
    {
        private SqlCommand _command;
        private SqlDataReader _reader;
        private string userNameDB;
        private string passwordDB;

        public SqlCommand Command { get => _command; set => _command = value; }
        public SqlDataReader Reader { get => _reader; set => _reader = value; }

        public bool IniciarSesionDB(string currentUserName,string currentPassword,SqlConnection conexion) 
        {
            

            try
            {
                string query = "SELECT UserName, CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('password', password)) as password FROM profiles";
                Command = new SqlCommand(query, conexion);

                Reader = Command.ExecuteReader();

                while (Reader.Read()) 
                {
                    userNameDB = Reader.GetString(0);
                    passwordDB = Reader.GetString(1);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            if (userNameDB == currentUserName && passwordDB == currentPassword) { return true; }
            else { return false; }


        }
    }
}
