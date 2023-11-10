using CurdTraining.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurdTraining.Views
{
    public partial class AddCar : UserControl
    {

        private string urlImage = string.Empty;
        private Dictionary<string, int> fabricantesDict = new Dictionary<string, int>();

        public AddCar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AgregarVehiculo oAgregarVehiculo = new AgregarVehiculo();
            AbrirConexionDB oConexion = new AbrirConexionDB();
            SqlConnection currentConxeion = oConexion.abrirConexion();


            string placa = txtBoxPlaca.Text;
            string referencia = txtBoxReferencia.Text;
            string modelo = txtBoxModelo.Text;
            string foto = urlImage;
            string precio = txtBoxPrecio.Text;
            string propietario = txtBoxPropietario.Text;
            int fabricante = -1;

            foreach (var kvp in fabricantesDict) 
            {
                if (cbBoxFabricantes.SelectedItem.ToString() == kvp.Key)
                {
                    fabricante = kvp.Value;
                    break;
                }
            }

            oAgregarVehiculo.AgregarVehiculoDB(placa,fabricante,referencia,modelo,foto,precio,propietario,currentConxeion);
            currentConxeion.Close();


        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                urlImage = OpenFile.FileName;
                pbCar.Image = Image.FromFile(urlImage);
                pbCar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            CargarItemsFabricantes oLoadFabricantes = new CargarItemsFabricantes();
            AbrirConexionDB oConexion = new AbrirConexionDB();
            SqlConnection currentConexion = oConexion.abrirConexion();
            List<string> listFabricantes = oLoadFabricantes.CargarFabricantesDB(currentConexion);

            for (int i = 0; i < listFabricantes.Count;i++) 
            {
                fabricantesDict.Add(listFabricantes[i],i+1);
            }

            cbBoxFabricantes.Items.AddRange(listFabricantes.ToArray());
            currentConexion.Close();



        }

        private void cbBoxFabricantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbCar_Click(object sender, EventArgs e)
        {

        }
    }
}
