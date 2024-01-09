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
    public partial class frmListadoSocioActividad : Form
    {
        public frmListadoSocioActividad()
        {
            InitializeComponent();
        }
        private void frmListadoSocioActividad_Load(object sender, EventArgs e)
        {
            clsActividad actividad = new clsActividad();
            actividad.CargarCombo(cmbActividad);
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            clsCliente cliente = new clsCliente();
            cliente.ListarClienteActividad(dgvGrilla, idActividad);

            lblMayor.Text = cliente.DeudaMayor.ToString("0.00");
            lblMenor.Text = cliente.DeudaMenor.ToString("0.00");
            lblPromedioDeuda.Text = cliente.Promedio.ToString("0.00");
            lblTotalDeuda.Text = cliente.Deuda.ToString("0.00");
            btnGenerarReporte.Enabled = true;
            btnImprimir.Enabled = true;
            cmbActividad.SelectedIndex = 0;
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            clsActividad actividad = new clsActividad();

            Int32 idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            actividad.ObtenerSeleccionCombo(cmbActividad);
            string nombreActividad = actividad.nombreActividadSeleccionado;
            cliente.GenerarReporteActividad(idActividad, nombreActividad);
            MessageBox.Show("Reporte generado exitosamente!");
            dgvGrilla.Rows.Clear();
            lblMayor.Text = "";
            lblMenor.Text = "";
            lblPromedioDeuda.Text = "";
            lblTotalDeuda.Text = "";
            btnImprimir.Enabled = false;
            btnGenerarReporte.Enabled = false;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {

            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Reporte impreso con exito!");
            dgvGrilla.Rows.Clear();
            lblMayor.Text = "";
            lblMenor.Text = "";
            lblPromedioDeuda.Text = "";
            lblTotalDeuda.Text = "";
            btnImprimir.Enabled = false;
            btnGenerarReporte.Enabled = false;
        }
        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsCliente cliente = new clsCliente();
            clsActividad actividad = new clsActividad();

            Int32 idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
            actividad.ObtenerSeleccionCombo(cmbActividad);
            string nombreActividad = actividad.nombreActividadSeleccionado;
            
            cliente.ImprimirSocioActividad(e, dgvGrilla, idActividad, nombreActividad);
        }
    }
}
