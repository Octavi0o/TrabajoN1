using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2Vehiculos : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public Form2Vehiculos()
        {
            InitializeComponent();
        }

        void ListarVehiculos()
        {
            tx_listadovehiculos.Clear();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                tx_listadovehiculos.AppendText(vehiculo.mostrarDatos() + System.Environment.NewLine);
            }
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tx_marca.Text))
            {
                MessageBox.Show("Debe ingresar la Marca");
                tx_marca.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_modelo.Text))
            {
                MessageBox.Show("Debe ingresar el modelo");
                tx_modelo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_año.Text))
            {
                MessageBox.Show("Debe ingresar el año");
                tx_año.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_precio.Text))
            {
                MessageBox.Show("Debe ingresar el precio");
                tx_precio.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_kilometraje.Text))
            {
                MessageBox.Show("Debe ingresar el kilometraje");
                tx_kilometraje.Focus();
                return;
            }

            decimal lucas;
            bool isOk = decimal.TryParse(tx_precio.Text, out lucas);

            if (!isOk)
            {
                MessageBox.Show("Ingresa precio valido");
                tx_precio.Focus();
                return;
            }

            int año;
            bool isAñoOk = int.TryParse(tx_año.Text, out año);

            if (!isAñoOk)
            {
                MessageBox.Show("Ingresa un año valido");
                tx_año.Focus();
                return;
            }

            int kilometraje;
            bool isKilometrajeOk = int.TryParse(tx_kilometraje.Text, out kilometraje);

            if (!isKilometrajeOk)
            {
                MessageBox.Show("Ingresa un kilometraje valido");
                tx_kilometraje.Focus();
                return;
            }


            Vehiculo vehiculo = new Vehiculo()
            {
                Marca = tx_marca.Text,
                Modelo = tx_modelo.Text,
                Año = año,
                Precio = lucas,
                Kilometraje = kilometraje
            };

            vehiculos.Add(vehiculo);
            GlobalVar.Inventario.AgregarVehiculo(vehiculo);

            MessageBox.Show("Vehículo almacenado y listo para ventas.");
            ListarVehiculos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
