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
    public partial class frmBusquedaNombre : Form
    {
        public frmBusquedaNombre()
        {
            InitializeComponent();
        }
        clsCliente socio = new clsCliente();

        public static string Soc;
        public static Int32 Barr;
        public static Int32 Act;
        private void frmBusquedaNombre_Load(object sender, EventArgs e)
        {
            socio.CargarComboNombre(cmbNombre);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String Nombre = cmbNombre.Text;
            clsCliente cliente = new clsCliente();
            clsBarrio barrio = new clsBarrio();
            clsActividad actividad = new clsActividad();
            cliente.BuscarPorNombre(Nombre);
            barrio.Buscar(cliente.idBarrio);
            actividad.Buscar(cliente.idActividad);
            if (cliente.Nombre != "")
            {

                lblSocio.Text = Convert.ToString( cliente.idSocio);
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
        }
    }
}
