using CurdTraining.Models;
using CurdTraining.Views;
using Microsoft.Data.SqlClient;

namespace CurdTraining
{
    public partial class InicioSesionView : Form
    {
        public InicioSesionView()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            AbrirConexionDB oConexion = new AbrirConexionDB();
            IniciarSesion oIniciarSesion = new IniciarSesion();
            SqlConnection currentConexion = oConexion.abrirConexion();
            string currentUserName = txtBoxUserName.Text;
            string currentPassword = txtBoxPassword.Text;

            bool pass = oIniciarSesion.IniciarSesionDB(currentUserName, currentPassword, currentConexion);
            currentConexion.Close();

            if (pass) 
            {
                MessageBox.Show("Bienvenido");
                MainHubView mainHubView = new MainHubView();
                this.Hide();
                mainHubView.Show();
                
            }
            else 
            {
                MessageBox.Show("No puedes pasar");
            }

        }
    }
}