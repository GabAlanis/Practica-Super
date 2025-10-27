using ImageMagick.Drawing;
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
    public partial class FrmEmpleados : Form
    {
        int id = -1;
        Datos datos = new Datos();
        private void mostrarDatos()
        {
            DataSet ds = datos.getAlldata("select * from empleados order by id");
            if (ds != null)
            {
                dgvDatos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void CargarDatos(int id)
        {
            DataSet ds = datos.getAlldata("SELECT * FROM empleados WHERE id = " + id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                txtEdad.Text = ds.Tables[0].Rows[0]["edad"].ToString();
                dtpFechaNac.Text = ds.Tables[0].Rows[0]["fecha_nac"].ToString();
                txtTipoDoc.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
                txtNroDoc.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
                txtCuli.Text = ds.Tables[0].Rows[0]["cuil"].ToString();
                txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                mtbNroTelPrinc.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
                mtbNroTelSec.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                txtCargo.Text = ds.Tables[0].Rows[0]["cargo"].ToString();
                txtAntiguedad.Text = ds.Tables[0].Rows[0]["antiguedad"].ToString();
                dtpFechaIngreso.Text = ds.Tables[0].Rows[0]["fecha_ingreso"].ToString();
                txtSalarioAnual.Text = ds.Tables[0].Rows[0]["salario_anual"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el Empleado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmEmpleados_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
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
                string query = "Delete from empleados where id = " + id;
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

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = datos.getAlldata("select * from empleados where " +
            "nombre ilike '%" + txtBuscar.Text + "%' or " +
            "apellido ilike '%" + txtBuscar.Text + "%' or " +
            "edad::text ilike '%" + txtBuscar.Text + "%' or " +
            "fecha_nac::text ilike '%" + txtBuscar.Text + "%' or " +
            "tipo_doc ilike '%" + txtBuscar.Text + "%' or " +
            "nro_doc ilike '%" + txtBuscar.Text + "%' or " +
            "cuil ilike '%" + txtBuscar.Text + "%' or " +
            "direccion ilike '%" + txtBuscar.Text + "%' or " +
            "nro_tel_princ ilike '%" + txtBuscar.Text + "%' or " +
            "nro_tel_sec ilike '%" + txtBuscar.Text + "%' or " +
            "email ilike '%" + txtBuscar.Text + "%' or " +
            "cargo ilike '%" + txtBuscar.Text + "%' or " +
            "antiguedad ilike '%" + txtBuscar.Text + "%' or " +
            "fecha_ingreso::text ilike '%" + txtBuscar.Text + "%' or " +
            "salario_anual::text ilike '%" + txtBuscar.Text + "%'");
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
                string query = "INSERT INTO empleados (nombre, apellido, edad, fecha_nac, tipo_doc, nro_doc, cuil, direccion, nro_tel_princ, nro_tel_sec, email, cargo, antiguedad, fecha_ingreso, salario_anual) " +
                     "VALUES ('" + txtNombre.Text + "', " +
                     "'" + txtApellido.Text + "', " +
                    Convert.ToInt32(txtEdad.Text) + ", " +
                    "'" + dtpFechaNac.Value.ToString("yyyy-MM-dd") + "', " +
                    "'" + txtTipoDoc.Text + "', " +
                    "'" + txtNroDoc.Text + "', " +
                    "'" + txtCuli.Text + "', " +
                    "'" + txtDireccion.Text + "', " +
                    "'" + mtbNroTelPrinc.Text + "', " +
                    "'" + mtbNroTelSec.Text + "', " +
                    "'" + txtEmail.Text + "', " +
                    "'" + txtCargo.Text + "', " +
                    "'" + txtAntiguedad.Text + "', " +
                    "'" + dtpFechaIngreso.Value.ToString("yyyy-MM-dd") + "', " +
                    Convert.ToDecimal(txtSalarioAnual.Text) + ")";
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
                string query = "UPDATE empleados SET " +
                     "nombre = '" + txtNombre.Text + "', " +
                     "apellido = '" + txtApellido.Text + "', " +
                     "edad = " + txtEdad.Text + ", " +
                     "fecha_nac = '" + dtpFechaNac.Value.ToString("yyyy-MM-dd") + "', " +
                     "tipo_doc = '" + txtTipoDoc.Text + "', " +
                     "nro_doc = '" + txtNroDoc.Text + "', " +
                     "cuil = '" + txtCuli.Text + "', " +
                     "direccion = '" + txtDireccion.Text + "', " +
                     "nro_tel_princ = '" + mtbNroTelPrinc.Text + "', " +
                     "nro_tel_sec = '" + mtbNroTelSec.Text + "', " +
                     "email = '" + txtEmail.Text + "', " +
                     "cargo = '" + txtCargo.Text + "', " +
                     "antiguedad = '" + txtAntiguedad.Text + "', " +
                     "fecha_ingreso = '" + dtpFechaIngreso.Value.ToString("yyyy-MM-dd") + "', " +
                     "salario_anual = " + txtSalarioAnual.Text + " " +
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
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEdad.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Now;
            txtTipoDoc.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            txtCuli.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            mtbNroTelPrinc.Text = string.Empty;
            mtbNroTelSec.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtAntiguedad.Text = string.Empty;
            dtpFechaIngreso.Value = DateTime.Now;
            txtSalarioAnual.Text = string.Empty;
            id = -1;
        }

        private void CmsEditarEliminar_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
