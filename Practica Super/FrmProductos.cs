using ImageMagick;
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
    public partial class FrmProductos : Form
    {

        int id = -1;
        string ruta;
        Datos datos = new Datos();
        private void mostrarDatos()
        {
            DataSet ds = datos.getAlldata("select id, id_proveedor, codigo, nombre, marca, tipo, grupo," +
                "peso, precio_unidad, stock from productos order by id");
            if (ds != null)
            {
                dgvDatos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnAggImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.Title = "Seleccionar imagen del producto";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ruta = ofd.FileName;

                try
                {
                    // Mostrar la imagen en el PictureBox
                    using (var image = new MagickImage(ruta))
                    {
                        using (var ms = new System.IO.MemoryStream(image.ToByteArray(MagickFormat.Bmp)))
                        {
                            pbImagen.Image = new Bitmap(ms);
                        }
                    }

                    // Guardar la ruta en la base de datos
                    if (id != -1) // Si estamos editando un producto existente
                    {
                        string query = $"UPDATE productos SET imagen = '{ruta.Replace("'", "''")}' WHERE id = {id}";
                        Datos data = new Datos();
                        bool resultado = data.ExecuteQuery(query);

                        if (resultado)
                        {
                            MessageBox.Show("Imagen actualizada correctamente", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la imagen", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Si es un nuevo producto, solo guardamos la ruta para usarla al guardar
                        MessageBox.Show("Imagen cargada. Se guardará al crear el producto.",
                            "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message,
                        "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarImagen(string query)
        {
            try
            {
                using (var image = new MagickImage(query))
                {
                    using (var ms = new System.IO.MemoryStream(image.ToByteArray(MagickFormat.Bmp)))
                    {
                        pbImagen.Image = new Bitmap(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen" + ex.Message, "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void CargarDatos(int id)
        {
            DataSet ds = datos.getAlldata("SELECT * FROM productos WHERE id = " + id);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtIdProveedor.Text = ds.Tables[0].Rows[0]["id_proveedor"].ToString();
                txtCodigo.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtMarca.Text = ds.Tables[0].Rows[0]["marca"].ToString();
                txtTipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString();
                txtGrupo.Text = ds.Tables[0].Rows[0]["grupo"].ToString();
                txtPeso.Text = ds.Tables[0].Rows[0]["peso"].ToString();
                txtPrecioUnidad.Text = ds.Tables[0].Rows[0]["precio_unidad"].ToString();
                txtStock.Text = ds.Tables[0].Rows[0]["stock"].ToString();
                CargarImagen(ds.Tables[0].Rows[0]["imagen"].ToString()); //ponemos la imagen
            }
            else
            {
                MessageBox.Show("No se encontró el cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmProductos_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data = new Datos();

            if (id == -1)
            {
                string query = "INSERT INTO productos (id_proveedor, codigo, imagen, nombre, marca, tipo, grupo, peso, precio_unidad, stock) " +
                     "VALUES (" + txtIdProveedor.Text + ", '" + txtCodigo.Text + "', '" + ruta.Replace("'", "''") + "', '" + txtNombre.Text + "', '" +
                     txtMarca.Text + "', '" + txtTipo.Text + "', '" + txtGrupo.Text + "', " + txtPeso.Text + ", " +
                     txtPrecioUnidad.Text + ", " + txtStock.Text + ")";
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
                string query = "UPDATE productos SET " +
                     "id_proveedor = " + txtIdProveedor.Text + ", " +
                     "codigo = '" + txtCodigo.Text + "', " +
                     "imagen = '" + ruta + "', " +
                     "nombre = '" + txtNombre.Text + "', " +
                     "marca = '" + txtMarca.Text + "', " +
                     "tipo = '" + txtTipo.Text + "', " +
                     "grupo = '" + txtGrupo.Text + "', " +
                     "peso = " + txtPeso.Text + ", " +
                     "precio_unidad = " + txtPrecioUnidad.Text + ", " +
                     "stock = " + txtStock.Text + " " +
                     "WHERE id = " + id;
                ;
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
                string query = "Delete from productos where id = " + id;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            txtIdProveedor.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtGrupo.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtPrecioUnidad.Text = string.Empty;
            txtStock.Text = string.Empty;
            pbImagen.Image = null;
            ruta = String.Empty;
            id = -1;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            DataSet ds = datos.getAlldata("select * from productos where " +
            "CAST(id_proveedor AS text) ilike '%" + txtBuscar.Text + "%' or " +
            "codigo ilike '%" + txtBuscar.Text + "%' or " +
            "imagen ilike '%" + txtBuscar.Text + "%' or " +
            "nombre ilike '%" + txtBuscar.Text + "%' or " +
            "marca ilike '%" + txtBuscar.Text + "%' or " +
            "tipo ilike '%" + txtBuscar.Text + "%' or " +
            "grupo ilike '%" + txtBuscar.Text + "%' or " +
            "peso::text ilike '%" + txtBuscar.Text + "%' or " +
            "precio_unidad::text ilike '%" + txtBuscar.Text + "%' or " +
            "stock::text ilike '%" + txtBuscar.Text + "%'");
            if (ds != null)
            {
                dgvDatos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
