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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            LabHora.Text = DateTime.Now.ToString();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.Show();
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas frmFacturas = new FrmFacturas();
            frmFacturas.Show();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturas frmFacturas = new FrmFacturas();
            frmFacturas.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
