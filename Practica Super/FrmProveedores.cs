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
    public partial class FrmProveedores : Form
    {
        int id = -1;
        Datos datos = new Datos();
        private void mostrarDatos()
        {
            DataSet ds = datos.getAlldata("select * from proveedores order by id");
            if (ds != null)
            {
                dgvDatos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void CargarDatos(int id)
        {
            DataSet ds = datos.getAlldata("SELECT * FROM proveedores entes WHERE id = " + id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtEmpresa.Text = ds.Tables[0].Rows[0]["empresa"].ToString();
                txtTipoProducto.Text = ds.Tables[0].Rows[0]["tipo_producto"].ToString();
                txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                mtbNroTelPrinc.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                mtbNroTelSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void frmProveedores_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAlldata("select * from proveedores where " +
            "empresa ilike '%" + txtBuscar.Text + "%' or " +
            "tipo_producto ilike '%" + txtBuscar.Text + "%' or " +
            "direccion ilike '%" + txtBuscar.Text + "%' or " +
            "nro_tel_princ ilike '%" + txtBuscar.Text + "%' or " +
            "nro_tel_sec ilike '%" + txtBuscar.Text + "%' or " +
            "email ilike '%" + txtBuscar.Text + "%'");
            if (ds != null)
            {
                dgvDatos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data = new Datos();

            if (id == -1)
            {
                string query = "INSERT INTO proveedores (empresa, tipo_producto, direccion, nro_tel_princ, nro_tel_sec, email) " +
                    "VALUES ('" + txtEmpresa.Text + "', '" + txtTipoProducto.Text + "','" + txtDireccion.Text + "','" + mtbNroTelPrinc.Text
                    + "', '" + mtbNroTelSec.Text + "', '" + txtEmail.Text + "')";
                resultado = data.ExecuteQuery(query);
                if (resultado)
                {
                    MessageBox.Show("Registro agregado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string query = "UPDATE proveedores SET " +
                     "empresa = '" + txtEmpresa.Text + "', " +
                     "tipo_producto = '" + txtTipoProducto.Text + "', " +
                     "direccion = '" + txtDireccion.Text + "', " +
                     "nro_tel_princ = '" + mtbNroTelPrinc.Text + "', " +
                     "nro_tel_sec = '" + mtbNroTelSec.Text + "', " +
                     "email = '" + txtEmail.Text + "' " +
                     "WHERE id = " + id;
                resultado = data.ExecuteQuery(query);
                if (resultado)
                {
                    MessageBox.Show("Registro Acutalizdo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Actualizar el registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            txtEmpresa.Text = string.Empty;
            txtTipoProducto.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            mtbNroTelPrinc.Text = string.Empty;
            mtbNroTelSec.Text = string.Empty;
            txtEmail.Text = string.Empty;
            id = -1;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value);
                CargarDatos(id);
                tbPaginacion.SelectedTab = tabPage1;
                btnGuardar.Text = "Actualizar";
                this.id = id;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            bool resultado;
            Datos datos = new Datos();
            if (MessageBox.Show("¿estas seguro de Borrar?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = "Delete from proveedores where id = " + id;
                resultado = datos.ExecuteQuery(query);
                if (resultado)
                {
                    MessageBox.Show("Registro Eliminado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }
    }
}
