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
    public partial class FrmVentas : Form
    {
        int idVenta = -1;
        int idDetalle = -1;
        int idCompra = -1;
        Datos datos = new Datos();

        private void reiniciar()
        {
            idVenta = -1;
            idDetalle = -1;
            idCompra = -1;
            btnAgregarVenta.Text = "Agregar";
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarCompra.Text = "Agregar";

            cbCliente.SelectedIndex = 0;
            cbEmpleado.SelectedIndex = 0;
            cbFactura.SelectedIndex = 0;
            cbProducto.SelectedIndex = 0;
            cbVenta.SelectedIndex = 0;
            cbVentaCliente.SelectedIndex = 0;
            txtCantidad.Text = string.Empty;
        }
        private void mostrarDatos()
        {
            DataSet ds = datos.getAlldata("select * from ventas order by id");
            DataSet ds2 = datos.getAlldata("select * from ventas_productos order by id");
            DataSet ds3 = datos.getAlldata("select * from compras_clientes order by id");
            if (ds != null)
            {
                dgvVentas.DataSource = ds.Tables[0];
                dgvDetalles.DataSource = ds2.Tables[0];
                dgvCompras.DataSource = ds3.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void CargarDatosVentas(int id)
        {
            DataSet ds = datos.getAlldata("SELECT * FROM ventas WHERE id = " + id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cbEmpleado.Text = ds.Tables[0].Rows[0]["id_empleado"].ToString();
                cbFactura.Text = ds.Tables[0].Rows[0]["id_factura"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró la venta_detalle", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarDatosDetalles(int id)
        {
            DataSet ds = datos.getAlldata("SELECT * FROM ventas_productos WHERE id = " + id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cbVenta.Text = ds.Tables[0].Rows[0]["id_venta"].ToString();
                cbProducto.Text = ds.Tables[0].Rows[0]["id_producto"].ToString();
                txtCantidad.Text = ds.Tables[0].Rows[0]["cantidad"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró la venta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarDatosCompras(int id)
        {
            DataSet ds = datos.getAlldata("SELECT * FROM compras_clientes WHERE id = " + id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cbVentaCliente.Text = ds.Tables[0].Rows[0]["id_venta"].ToString();
                cbCliente.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró la compra", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmVentas_Activated(object sender, EventArgs e)
        {
            mostrarDatos();

            try
            {
                //Empleados
                DataSet dsEmp = datos.getAlldata("SELECT id FROM empleados ORDER BY id");
                cbEmpleado.DataSource = dsEmp.Tables[0];
                cbEmpleado.DisplayMember = "id";
                cbEmpleado.ValueMember = "id";

                //Facturas
                DataSet dsFact = datos.getAlldata("SELECT id FROM facturas ORDER BY id");
                cbFactura.DataSource = dsFact.Tables[0];
                cbFactura.DisplayMember = "id";
                cbFactura.ValueMember = "id";

                //Productos
                DataSet dsProd = datos.getAlldata("SELECT id FROM productos ORDER BY id");
                cbProducto.DataSource = dsProd.Tables[0];
                cbProducto.DisplayMember = "id";
                cbProducto.ValueMember = "id";

                //Clientes
                DataSet dsCli = datos.getAlldata("SELECT id FROM clientes ORDER BY id");
                cbCliente.DataSource = dsCli.Tables[0];
                cbCliente.DisplayMember = "nombre";
                cbCliente.ValueMember = "id";

                //ventas
                DataSet dsVen = datos.getAlldata("SELECT id FROM ventas ORDER BY id");
                cbVenta.DataSource = dsVen.Tables[0];
                cbVenta.DisplayMember = "id";
                cbVenta.ValueMember = "id";

                cbVentaCliente.DataSource = dsVen.Tables[0];
                cbVentaCliente.DisplayMember = "id";
                cbVentaCliente.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Sistema");
            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data = new Datos();

            if (idVenta == -1)
            {
                string query = "INSERT INTO ventas (id_empleado, id_factura) VALUES (" +
                Convert.ToInt32(cbEmpleado.SelectedValue) + ", " +
                Convert.ToInt32(cbFactura.SelectedValue) + ");";

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
                string query = "UPDATE ventas SET " +
                    "id_empleado = " + Convert.ToInt32(cbEmpleado.SelectedValue) + ", " +
                    "id_factura = " + Convert.ToInt32(cbFactura.SelectedValue) +
                    " WHERE id = " + idVenta;
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
            reiniciar();
        }

        private void editarTsmiVentas_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvVentas[0, dgvVentas.CurrentCell.RowIndex].Value);
                CargarDatosVentas(id);
                btnAgregarVenta.Text = "Actualizar";
                this.idVenta = id;
            }
        }

        private void eliminarTsmiVentas_Click(object sender, EventArgs e)
        {
            string id = dgvVentas[0, dgvVentas.CurrentCell.RowIndex].Value.ToString();
            bool resultado;
            Datos datos = new Datos();
            if (MessageBox.Show("¿estas seguro de Borrar?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = "Delete from ventas where id = " + id;
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

        private void TsmiEditarDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDetalles[0, dgvDetalles.CurrentCell.RowIndex].Value);
                CargarDatosDetalles(id);
                btnAgregarDetalle.Text = "Actualizar";
                this.idDetalle = id;
            }
        }

        private void TsmEliminarDetalles_Click(object sender, EventArgs e)
        {
            string id = dgvDetalles[0, dgvDetalles.CurrentCell.RowIndex].Value.ToString();
            bool resultado;
            Datos datos = new Datos();
            if (MessageBox.Show("¿estas seguro de Borrar?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = "Delete from ventas_productos where id = " + id;
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

        private void TsmiEditarCompras_Click(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvCompras[0, dgvCompras.CurrentCell.RowIndex].Value);
                CargarDatosCompras(id);
                btnAgregarCompra.Text = "Actualizar";
                this.idCompra = id;
            }
        }

        private void TsmiEliminarCompras_Click(object sender, EventArgs e)
        {
            string id = dgvCompras[0, dgvCompras.CurrentCell.RowIndex].Value.ToString();
            bool resultado;
            Datos datos = new Datos();
            if (MessageBox.Show("¿estas seguro de Borrar?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = "Delete from compras_clientes where id = " + id;
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

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data = new Datos();

            if (idVenta == -1)
            {
                string query = "INSERT INTO ventas (id_empleado, id_factura) VALUES (" +
                Convert.ToInt32(cbEmpleado.SelectedValue) + ", " +
                Convert.ToInt32(cbFactura.SelectedValue) + ");";

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
                string query = "UPDATE ventas SET " +
                    "id_empleado = " + Convert.ToInt32(cbEmpleado.SelectedValue) + ", " +
                    "id_factura = " + Convert.ToInt32(cbFactura.SelectedValue) +
                    " WHERE id = " + idVenta;
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
            reiniciar();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data = new Datos();

            if (idCompra == -1)
            {
                string query = "INSERT INTO compras_clientes (id_venta, id_cliente) VALUES (" +
                Convert.ToInt32(cbVentaCliente.SelectedValue) + ", " +
                Convert.ToInt32(cbCliente.SelectedValue) + ");";

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
                string query = "UPDATE compras_clientes SET " +
                    "id_venta = " + Convert.ToInt32(cbVentaCliente.SelectedValue) + ", " +
                    "id_cliente = " + Convert.ToInt32(cbCliente.SelectedValue) +
                    " WHERE id = " + idCompra;
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
            reiniciar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.ShowDialog();
        }
    }
}
