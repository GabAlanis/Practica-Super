using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Super
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void CrvReporte_Load(object sender, EventArgs e)
        {
            GenerarReporte reporte = new GenerarReporte();
            ReportDocument imprime;
            imprime = reporte.CrearReporte();
            CrvReporte.ReportSource = imprime;
            CrvReporte.RefreshReport();
        }
    }
}
