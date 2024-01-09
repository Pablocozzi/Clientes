using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_CozziPablo
{
    public partial class frmSistemaGestionClientes : Form
    {
        public frmSistemaGestionClientes()
        {
            InitializeComponent();
        }

        private void acercaDelDesarrolladorDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventana = new frmAcercaDe();
            ventana.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCliente ventana = new frmAltaCliente();
            ventana.Show();
        }

        private void busquedaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente vetana = new frmBusquedaCliente();
            vetana.Show();
        }

        private void listarDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaNombre ventana = new frmBusquedaNombre();
            ventana.Show();
        }

        private void listadoPorCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeSocios ventana = new frmListadoDeSocios();
            ventana.Show();
        }

        private void listadoDeSociosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSociosDeudores ventana = new frmListadoSociosDeudores();
            ventana.Show();
        }

        private void listadoDeSociosDeUnaActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSocioActividad ventana = new frmListadoSocioActividad();
            ventana.Show();
        }

        private void listadoDeSociosDeUnBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSocioBarrio ventana = new frmListadoSocioBarrio();
            ventana.Show();
        }
    }
}
