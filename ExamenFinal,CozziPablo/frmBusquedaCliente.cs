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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }
        public static string Soc;
        public static Int32 Barr;
        public static Int32 Act;

        public static void Habilitar(Button boton)
        {
            boton.Enabled = true;
        }
        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Int32 idSocio = Convert.ToInt32(txtCodigo.Text);
            clsCliente cliente = new clsCliente();
            clsBarrio barrio = new clsBarrio();
            clsActividad actividad = new clsActividad();
            cliente.Buscar(idSocio);
            barrio.Buscar(cliente.idBarrio);
            actividad.Buscar(cliente.idActividad);
            if (cliente.idSocio != 0)
            {

                lblNombre.Text = cliente.Nombre;
                lblDireccion.Text = cliente.Direccion;
                lblDeuda.Text = Convert.ToString(cliente.DeudaCliente);
                if (cliente.idBarrio == barrio.idBarrio)
                {
                    lblBarrio.Text = Convert.ToString(barrio.Nombre);
                    Barr = cliente.idBarrio;
                }
                if (cliente.idActividad == actividad.idActividad)
                {
                    lblActividad.Text = Convert.ToString(actividad.Nombre);
                    Act = cliente.idActividad;
                }
                Soc = Convert.ToString(cliente.idSocio);
                
            }
            else
            {
                MessageBox.Show("Cliente no existe");
            }
            Habilitar(btnEliminar); 
            Habilitar(btnModificar);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarCliente ventana = new frmModificarCliente();
            ventana.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            cliente.Eliminar(Convert.ToInt32( Soc));
            txtCodigo.Text = "";
            lblNombre.Text = "";
            lblDireccion.Text = "";
            lblBarrio.Text = "";
            lblActividad.Text = "";
            lblDeuda.Text = "";
            MessageBox.Show("Socio eliminado correctamente!");
        }


    }
}
