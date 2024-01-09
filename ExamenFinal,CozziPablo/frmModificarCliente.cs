using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_CozziPablo
{
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }
        //buscamos traer de el formulario busquedacliente el valor que selecciono el usuario
        Int32 Socio = Convert.ToInt32(frmBusquedaCliente.Soc);

        clsCliente cliente = new clsCliente();
        clsBarrio barrio = new clsBarrio();
        clsActividad actividad = new clsActividad();
        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            lblSocio.Text = Socio.ToString();
            
            clsBarrio barrio = new clsBarrio();
            barrio.CargarCombo(cmbBarrio);
            clsActividad actividad = new clsActividad();
            actividad.CargarCombo(cmbActividad);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                cliente.Nombre = txtNombre.Text;
                cliente.ModificarNombre(Socio);
            }
            if (txtDireccion.Text != "")
            {
                cliente.Direccion = txtDireccion.Text;
                cliente.ModificarDireccion(Socio);
            }
            if (cmbBarrio.Enabled == true)
            {
                if (cmbBarrio.SelectedValue != null)
                {
                    Int32 IndiceBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
                    cliente.ModificarBarrio(Socio, IndiceBarrio);

                }
            }
            if (cmbActividad.Enabled == true)
            {
                if (cmbActividad.SelectedValue != null)
                {
                    Int32 IndiceActividad = Convert.ToInt32(cmbActividad.SelectedValue);
                    cliente.ModificarActividad(Socio, IndiceActividad);
                }
            }
            
            if (txtDeuda.Text != "")
            {
                cliente.DeudaCliente = Convert.ToDecimal( txtDeuda.Text);
                cliente.ModificarDeuda(Socio);
            }

            MessageBox.Show("Cambios guardados correctamente!");
            this.Close();
        }

        private void btnModBarrio_Click(object sender, EventArgs e)
        {
            cmbBarrio.Enabled = true;
        }

        private void btnModActividad_Click(object sender, EventArgs e)
        {
            cmbActividad.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelaron los cambios.");
            this.Close();
        }
    }
}
// ver si en barrio y actividad pongo combo box para que cambien de datos, sino me modifica todos los clientes