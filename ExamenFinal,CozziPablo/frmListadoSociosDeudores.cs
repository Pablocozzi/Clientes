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
    public partial class frmListadoSociosDeudores : Form
    {
        public frmListadoSociosDeudores()
        {
            InitializeComponent();
        }
        private void btnListar_Click_1(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            cliente.ListarClientesDeudores(dgvGrilla);

            lblMayor.Text = cliente.DeudaMayor.ToString("0.00");
            lblMenor.Text = cliente.DeudaMenor.ToString("0.00");
            lblPromedioDeuda.Text = cliente.Promedio.ToString("0.00");
            lblTotalDeuda.Text = cliente.Deuda.ToString("0.00");
            btnGenerarReporte.Enabled = true;
            btnImprimir.Enabled = true;
            
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            clsCliente cliente = new clsCliente();
            cliente.GenerarReporteDeudores();
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
            cliente.ImprimirDeudores(e, dgvGrilla);
            
        }
    }
}
