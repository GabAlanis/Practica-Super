namespace Practica_Super
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbPaginacion = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFactura = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbVenta = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregarCompra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVentaCliente = new System.Windows.Forms.ComboBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.cmsEditarEliminarVentas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarTsmiVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTsmiVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditarEliminarCompras = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiEditarCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiEliminarCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditarEliminarDetalles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiEditarDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEliminarDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPaginacion.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.cmsEditarEliminarVentas.SuspendLayout();
            this.cmsEditarEliminarCompras.SuspendLayout();
            this.cmsEditarEliminarDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPaginacion
            // 
            this.tbPaginacion.Controls.Add(this.tabPage2);
            this.tbPaginacion.Controls.Add(this.tabPage3);
            this.tbPaginacion.Controls.Add(this.tabPage1);
            this.tbPaginacion.Location = new System.Drawing.Point(18, 18);
            this.tbPaginacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPaginacion.Name = "tbPaginacion";
            this.tbPaginacion.SelectedIndex = 0;
            this.tbPaginacion.Size = new System.Drawing.Size(1284, 608);
            this.tbPaginacion.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAgregarVenta);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbFactura);
            this.tabPage2.Controls.Add(this.cbEmpleado);
            this.tabPage2.Controls.Add(this.dgvVentas);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1276, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.Location = new System.Drawing.Point(982, 271);
            this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(128, 51);
            this.btnAgregarVenta.TabIndex = 5;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(976, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Factura ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(976, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empleado ID:";
            // 
            // cbFactura
            // 
            this.cbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactura.FormattingEnabled = true;
            this.cbFactura.Location = new System.Drawing.Point(982, 174);
            this.cbFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(224, 37);
            this.cbFactura.TabIndex = 2;
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(982, 69);
            this.cbEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(224, 37);
            this.cbEmpleado.TabIndex = 1;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.ContextMenuStrip = this.cmsEditarEliminarVentas;
            this.dgvVentas.Location = new System.Drawing.Point(4, 132);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.Size = new System.Drawing.Size(861, 388);
            this.dgvVentas.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAgregarDetalle);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtCantidad);
            this.tabPage3.Controls.Add(this.cbProducto);
            this.tabPage3.Controls.Add(this.cbVenta);
            this.tabPage3.Controls.Add(this.dgvDetalles);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1276, 575);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detalles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(992, 392);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(128, 51);
            this.btnAgregarDetalle.TabIndex = 8;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(986, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(986, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Producto ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(986, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Venta ID:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(992, 292);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(224, 35);
            this.txtCantidad.TabIndex = 4;
            // 
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(992, 183);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(224, 37);
            this.cbProducto.TabIndex = 3;
            // 
            // cbVenta
            // 
            this.cbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVenta.FormattingEnabled = true;
            this.cbVenta.Location = new System.Drawing.Point(992, 78);
            this.cbVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVenta.Name = "cbVenta";
            this.cbVenta.Size = new System.Drawing.Size(224, 37);
            this.cbVenta.TabIndex = 2;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.ContextMenuStrip = this.cmsEditarEliminarDetalles;
            this.dgvDetalles.Location = new System.Drawing.Point(4, 135);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 62;
            this.dgvDetalles.Size = new System.Drawing.Size(846, 389);
            this.dgvDetalles.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnAgregarCompra);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbCliente);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbVentaCliente);
            this.tabPage1.Controls.Add(this.dgvCompras);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1276, 575);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Compras";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(970, 349);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(204, 86);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir informe de Compras";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAgregarCompra
            // 
            this.btnAgregarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompra.Location = new System.Drawing.Point(970, 274);
            this.btnAgregarCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCompra.Name = "btnAgregarCompra";
            this.btnAgregarCompra.Size = new System.Drawing.Size(128, 51);
            this.btnAgregarCompra.TabIndex = 10;
            this.btnAgregarCompra.Text = "Agregar";
            this.btnAgregarCompra.UseVisualStyleBackColor = true;
            this.btnAgregarCompra.Click += new System.EventHandler(this.btnAgregarCompra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(964, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cliente ID:";
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(970, 186);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(224, 37);
            this.cbCliente.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(964, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Venta ID:";
            // 
            // cbVentaCliente
            // 
            this.cbVentaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVentaCliente.FormattingEnabled = true;
            this.cbVentaCliente.Location = new System.Drawing.Point(970, 77);
            this.cbVentaCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVentaCliente.Name = "cbVentaCliente";
            this.cbVentaCliente.Size = new System.Drawing.Size(224, 37);
            this.cbVentaCliente.TabIndex = 6;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.ContextMenuStrip = this.cmsEditarEliminarCompras;
            this.dgvCompras.Location = new System.Drawing.Point(4, 132);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 62;
            this.dgvCompras.Size = new System.Drawing.Size(872, 392);
            this.dgvCompras.TabIndex = 2;
            // 
            // cmsEditarEliminarVentas
            // 
            this.cmsEditarEliminarVentas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEditarEliminarVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarTsmiVentas,
            this.eliminarTsmiVentas});
            this.cmsEditarEliminarVentas.Name = "cmsEditarEliminar";
            this.cmsEditarEliminarVentas.Size = new System.Drawing.Size(147, 68);
            // 
            // editarTsmiVentas
            // 
            this.editarTsmiVentas.Name = "editarTsmiVentas";
            this.editarTsmiVentas.Size = new System.Drawing.Size(146, 32);
            this.editarTsmiVentas.Text = "Editar";
            this.editarTsmiVentas.Click += new System.EventHandler(this.editarTsmiVentas_Click);
            // 
            // eliminarTsmiVentas
            // 
            this.eliminarTsmiVentas.Name = "eliminarTsmiVentas";
            this.eliminarTsmiVentas.Size = new System.Drawing.Size(146, 32);
            this.eliminarTsmiVentas.Text = "Eliminar";
            this.eliminarTsmiVentas.Click += new System.EventHandler(this.eliminarTsmiVentas_Click);
            // 
            // cmsEditarEliminarCompras
            // 
            this.cmsEditarEliminarCompras.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEditarEliminarCompras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiEditarCompras,
            this.TsmiEliminarCompras});
            this.cmsEditarEliminarCompras.Name = "cmsEditarEliminar";
            this.cmsEditarEliminarCompras.Size = new System.Drawing.Size(147, 68);
            // 
            // TsmiEditarCompras
            // 
            this.TsmiEditarCompras.Name = "TsmiEditarCompras";
            this.TsmiEditarCompras.Size = new System.Drawing.Size(146, 32);
            this.TsmiEditarCompras.Text = "Editar";
            this.TsmiEditarCompras.Click += new System.EventHandler(this.TsmiEditarCompras_Click);
            // 
            // TsmiEliminarCompras
            // 
            this.TsmiEliminarCompras.Name = "TsmiEliminarCompras";
            this.TsmiEliminarCompras.Size = new System.Drawing.Size(146, 32);
            this.TsmiEliminarCompras.Text = "Eliminar";
            this.TsmiEliminarCompras.Click += new System.EventHandler(this.TsmiEliminarCompras_Click);
            // 
            // cmsEditarEliminarDetalles
            // 
            this.cmsEditarEliminarDetalles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEditarEliminarDetalles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiEditarDetalles,
            this.TsmEliminarDetalles});
            this.cmsEditarEliminarDetalles.Name = "cmsEditarEliminar";
            this.cmsEditarEliminarDetalles.Size = new System.Drawing.Size(147, 68);
            // 
            // TsmiEditarDetalles
            // 
            this.TsmiEditarDetalles.Name = "TsmiEditarDetalles";
            this.TsmiEditarDetalles.Size = new System.Drawing.Size(146, 32);
            this.TsmiEditarDetalles.Text = "Editar";
            this.TsmiEditarDetalles.Click += new System.EventHandler(this.TsmiEditarDetalles_Click);
            // 
            // TsmEliminarDetalles
            // 
            this.TsmEliminarDetalles.Name = "TsmEliminarDetalles";
            this.TsmEliminarDetalles.Size = new System.Drawing.Size(146, 32);
            this.TsmEliminarDetalles.Text = "Eliminar";
            this.TsmEliminarDetalles.Click += new System.EventHandler(this.TsmEliminarDetalles_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 697);
            this.Controls.Add(this.tbPaginacion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            this.tbPaginacion.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.cmsEditarEliminarVentas.ResumeLayout(false);
            this.cmsEditarEliminarCompras.ResumeLayout(false);
            this.cmsEditarEliminarDetalles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbPaginacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFactura;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbVenta;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAgregarCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVentaCliente;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.ContextMenuStrip cmsEditarEliminarVentas;
        private System.Windows.Forms.ToolStripMenuItem editarTsmiVentas;
        private System.Windows.Forms.ToolStripMenuItem eliminarTsmiVentas;
        private System.Windows.Forms.ContextMenuStrip cmsEditarEliminarCompras;
        private System.Windows.Forms.ToolStripMenuItem TsmiEditarCompras;
        private System.Windows.Forms.ToolStripMenuItem TsmiEliminarCompras;
        private System.Windows.Forms.ContextMenuStrip cmsEditarEliminarDetalles;
        private System.Windows.Forms.ToolStripMenuItem TsmiEditarDetalles;
        private System.Windows.Forms.ToolStripMenuItem TsmEliminarDetalles;
    }
}