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
    public partial class frmListadoSocioBarrio : Form
    {
        public frmListadoSocioBarrio()
        {
            InitializeComponent();
        }

        private void frmListadoSocioBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio barrio = new clsBarrio();
            barrio.CargarCombo(cmbBarrio);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            clsCliente cliente = new clsCliente();
            cliente.ListarClienteBarrio(dgvGrilla, idBarrio);          
            lblCantidadSocios.Text = cliente.Cantidad.ToString();
            lblTotalDeuda.Text = cliente.Deuda.ToString("0.00");
            btnGenerarReporte.Enabled = true;
            btnImprimir.Enabled = true;
            cmbBarrio.SelectedIndex = 0;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            clsBarrio barrio = new clsBarrio();

            Int32 idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            barrio.ObtenerSeleccionCombo(cmbBarrio);
            string nombreBarrio = barrio.nombreBarrioSeleccionado;
            cliente.GenerarReporteBarrio(idBarrio, nombreBarrio);
            MessageBox.Show("Reporte generado exitosamente!");
            dgvGrilla.Rows.Clear();
            lblCantidadSocios.Text = "";
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
            lblCantidadSocios.Text = "";
            lblTotalDeuda.Text = "";
            btnImprimir.Enabled = false;
            btnGenerarReporte.Enabled = false;
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsCliente cliente = new clsCliente();
            clsBarrio barrio = new clsBarrio();

            Int32 idBarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            barrio.ObtenerSeleccionCombo(cmbBarrio);
            string nombreBarrio = barrio.nombreBarrioSeleccionado;

            cliente.ImprimirSocioBarrio(e, dgvGrilla, idBarrio, nombreBarrio);
        }
    }
}
