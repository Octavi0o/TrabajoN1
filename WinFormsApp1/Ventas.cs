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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cargaClientes();
            cargaVehiculos();
        }

        void cargaClientes()
        {
            cb_clientes.Items.AddRange(GlobalVar.clientes.ToArray());
        }

        void cargaVehiculos()
        {
            cb_vehiculo.Items.Clear(); 
            cb_vehiculo.Items.AddRange(GlobalVar.Inventario.Lista().ToArray()); // Agregar vehículos al ComboBox
        }

        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este evento se dispara cuando se selecciona un vehículo en el ComboBox
            if (cb_vehiculo.SelectedItem != null)
            {
                Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;
                if (vehiculoSeleccionado != null)
                {
                    MessageBox.Show($"Vehículo seleccionado: {vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar selección de cliente y vehículo
            Cliente clienteSeleccionado = cb_clientes.SelectedItem as Cliente;
            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;

            // Validar si el precio fue ingresado
            if (string.IsNullOrWhiteSpace(tx_precio.Text))
            {
                MessageBox.Show("Debe ingresar el precio");
                return;
            }

            if (clienteSeleccionado != null && vehiculoSeleccionado != null)
            {
                decimal precio;
                bool isPrecioOk = decimal.TryParse(tx_precio.Text, out precio);

                if (!isPrecioOk)
                {
                    MessageBox.Show("Debe ingresar un precio valido.");
                    return;
                }

                // Registrar la venta
                GlobalVar.concesionario.RegistrarVenta(vehiculoSeleccionado, clienteSeleccionado);

                // Agregar los datos al ListBox
                string datosVenta = $"{clienteSeleccionado.Nombre}\t{vehiculoSeleccionado.Marca} {vehiculoSeleccionado.Modelo}\t${precio}";
                listBox1.Items.Add(datosVenta);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente y un vehículo.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
