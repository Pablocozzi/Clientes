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
    public partial class frmListadoDeSocios : Form
    {
        public frmListadoDeSocios()
        {
            InitializeComponent();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
                clsCliente cliente = new clsCliente();
                cliente.ListarClientes(dgvGrilla);

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
            cliente.GenerarReporte();
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
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings; //al objeto documento le asignamos la impresora que fue asignada en prtVentana
            prtDocumento.Print();//ejecuta el metodo PrintPage que esta seleccionado cuando hacemos doble click al prtDocumento
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
            cliente.Imprimir(e);
            
        }
    }
}
