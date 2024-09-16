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
    public partial class VehiculosForms : Form
    {
        public VehiculosForms()
        {
            InitializeComponent();
        }

        private void VehiculosForms_Load(object sender, EventArgs e)
        {

        }

        void Listar()
        {
            listView1.Items.Clear();
            foreach (Vehiculo vehiculo in GlobalVar.Inventario.Lista())
            {
                listView1.Items.Add(new ListViewItem(vehiculo.itemView()));
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {

            Vehiculo v = new Vehiculo();
            v.Año = Convert.ToInt16(tx_año.Text);
            v.Kilometraje = Convert.ToInt16(tx_km.Text);
            v.Precio = Convert.ToInt16(tx_km.Text);
            v.Marca = tx_marca.Text;
            v.Modelo = tx_modelo.Text;


            GlobalVar.Inventario.AgregarVehiculo(v);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
