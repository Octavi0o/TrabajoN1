using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 formcliente = new Form1();
            formcliente.MdiParent = this.MdiParent;
            formcliente.Show();





        }

        private void Principal_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "The quick brown fox. Jump!";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Alert!";
            notifyIcon1.ShowBalloonTip(2000);
            notifyIcon1.Visible = true;

        }

        private void crearVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas form = new Ventas();
            form.MdiParent = this.MdiParent;
            form.Show();

        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Vehiculos formVehiculo = new Form2Vehiculos();
            formVehiculo.MdiParent = this.MdiParent;
            formVehiculo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
