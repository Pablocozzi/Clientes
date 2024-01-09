using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_CozziPablo
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            clsBarrio barrio = new clsBarrio();
            barrio.Cargar(cmbBarrio);
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            clsCliente cli = new clsCliente();
            cli.idSocio = Convert.ToInt32(txtIdSocio.Text);
            cli.Nombre = txtNombre.Text;
            cli.Direccion = txtDireccion.Text;
            cli.idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            cli.idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            cli.DeudaCliente = Convert.ToDecimal(txtDeuda.Text);
            cli.AgregarClienteNuevo();
            MessageBox.Show("Datos grabados!");
            txtIdSocio.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            cmbBarrio.SelectedIndex = 0;
            cmbActividad.SelectedIndex = 0;
            txtDeuda.Text = "";
        }

        private void frmAltaCliente_Load_1(object sender, EventArgs e)
        {
            clsBarrio barrio = new clsBarrio();
            barrio.Cargar(cmbBarrio);
            clsActividad actividad = new clsActividad();
            actividad.Cargar(cmbActividad);
        }
    }
}
