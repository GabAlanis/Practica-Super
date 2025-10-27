namespace Practica_Super
{
    partial class FrmFacturas
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
            this.label6 = new System.Windows.Forms.Label();
            this.mktHora = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregarFacturas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvDatosFacturas = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescPago = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtCostoAsoc = new System.Windows.Forms.TextBox();
            this.txtDescrFactura = new System.Windows.Forms.TextBox();
            this.cbMedioPago = new System.Windows.Forms.ComboBox();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.cbFactura = new System.Windows.Forms.ComboBox();
            this.btnAgregarDetalles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarDetalles = new System.Windows.Forms.TextBox();
            this.dgvDatosDetalles = new System.Windows.Forms.DataGridView();
            this.cmsEditarEliminarFacturas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiEditarFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiEliminarFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditarEliminarDetalles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditarDetallesFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarDetallesFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPaginacion.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosFacturas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDetalles)).BeginInit();
            this.cmsEditarEliminarFacturas.SuspendLayout();
            this.cmsEditarEliminarDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPaginacion
            // 
            this.tbPaginacion.Controls.Add(this.tabPage2);
            this.tbPaginacion.Controls.Add(this.tabPage1);
            this.tbPaginacion.Location = new System.Drawing.Point(18, 18);
            this.tbPaginacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPaginacion.Name = "tbPaginacion";
            this.tbPaginacion.SelectedIndex = 0;
            this.tbPaginacion.Size = new System.Drawing.Size(1442, 672);
            this.tbPaginacion.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.mktHora);
            this.tabPage2.Controls.Add(this.btnAgregarFacturas);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dtpFecha);
            this.tabPage2.Controls.Add(this.txtImporte);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.txtNumero);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.dgvDatosFacturas);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1434, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facturas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1016, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hora:";
            // 
            // mktHora
            // 
            this.mktHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktHora.Location = new System.Drawing.Point(1023, 435);
            this.mktHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mktHora.Mask = "00:00:00";
            this.mktHora.Name = "mktHora";
            this.mktHora.Size = new System.Drawing.Size(109, 35);
            this.mktHora.TabIndex = 17;
            // 
            // btnAgregarFacturas
            // 
            this.btnAgregarFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFacturas.Location = new System.Drawing.Point(1281, 242);
            this.btnAgregarFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarFacturas.Name = "btnAgregarFacturas";
            this.btnAgregarFacturas.Size = new System.Drawing.Size(140, 60);
            this.btnAgregarFacturas.TabIndex = 15;
            this.btnAgregarFacturas.Text = "Agregar";
            this.btnAgregarFacturas.UseVisualStyleBackColor = true;
            this.btnAgregarFacturas.Click += new System.EventHandler(this.btnAgregarFacturas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1016, 518);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1016, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Importe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1016, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1016, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(1020, 554);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(362, 30);
            this.dtpFecha.TabIndex = 10;
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(1022, 306);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(224, 35);
            this.txtImporte.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(1022, 186);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(224, 35);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(1022, 68);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(224, 35);
            this.txtNumero.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 82);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(523, 30);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvDatosFacturas
            // 
            this.dgvDatosFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosFacturas.ContextMenuStrip = this.cmsEditarEliminarFacturas;
            this.dgvDatosFacturas.Location = new System.Drawing.Point(4, 128);
            this.dgvDatosFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatosFacturas.Name = "dgvDatosFacturas";
            this.dgvDatosFacturas.RowHeadersWidth = 62;
            this.dgvDatosFacturas.Size = new System.Drawing.Size(970, 357);
            this.dgvDatosFacturas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtDescPago);
            this.tabPage1.Controls.Add(this.txtIva);
            this.tabPage1.Controls.Add(this.txtCostoAsoc);
            this.tabPage1.Controls.Add(this.txtDescrFactura);
            this.tabPage1.Controls.Add(this.cbMedioPago);
            this.tabPage1.Controls.Add(this.cbTipoFactura);
            this.tabPage1.Controls.Add(this.cbFactura);
            this.tabPage1.Controls.Add(this.btnAgregarDetalles);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtBuscarDetalles);
            this.tabPage1.Controls.Add(this.dgvDatosDetalles);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1434, 639);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Detalles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1194, 217);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 29);
            this.label14.TabIndex = 30;
            this.label14.Text = "Medio de pago:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1194, 117);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "Tipo Factura:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1194, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 29);
            this.label12.TabIndex = 28;
            this.label12.Text = "Factura ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(990, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "Pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(990, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(988, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 29);
            this.label9.TabIndex = 25;
            this.label9.Text = "Costo Asociado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(990, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Descripcion:";
            // 
            // txtDescPago
            // 
            this.txtDescPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescPago.Location = new System.Drawing.Point(994, 272);
            this.txtDescPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescPago.Name = "txtDescPago";
            this.txtDescPago.Size = new System.Drawing.Size(174, 35);
            this.txtDescPago.TabIndex = 23;
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(994, 160);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(174, 35);
            this.txtIva.TabIndex = 22;
            // 
            // txtCostoAsoc
            // 
            this.txtCostoAsoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoAsoc.Location = new System.Drawing.Point(994, 60);
            this.txtCostoAsoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostoAsoc.Name = "txtCostoAsoc";
            this.txtCostoAsoc.Size = new System.Drawing.Size(174, 35);
            this.txtCostoAsoc.TabIndex = 21;
            // 
            // txtDescrFactura
            // 
            this.txtDescrFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrFactura.Location = new System.Drawing.Point(994, 368);
            this.txtDescrFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescrFactura.Name = "txtDescrFactura";
            this.txtDescrFactura.Size = new System.Drawing.Size(174, 35);
            this.txtDescrFactura.TabIndex = 20;
            // 
            // cbMedioPago
            // 
            this.cbMedioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedioPago.FormattingEnabled = true;
            this.cbMedioPago.Location = new System.Drawing.Point(1200, 252);
            this.cbMedioPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMedioPago.Name = "cbMedioPago";
            this.cbMedioPago.Size = new System.Drawing.Size(180, 37);
            this.cbMedioPago.TabIndex = 19;
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Location = new System.Drawing.Point(1200, 152);
            this.cbTipoFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(180, 37);
            this.cbTipoFactura.TabIndex = 18;
            // 
            // cbFactura
            // 
            this.cbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactura.FormattingEnabled = true;
            this.cbFactura.Location = new System.Drawing.Point(1200, 57);
            this.cbFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(180, 37);
            this.cbFactura.TabIndex = 17;
            // 
            // btnAgregarDetalles
            // 
            this.btnAgregarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalles.Location = new System.Drawing.Point(1242, 491);
            this.btnAgregarDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarDetalles.Name = "btnAgregarDetalles";
            this.btnAgregarDetalles.Size = new System.Drawing.Size(140, 60);
            this.btnAgregarDetalles.TabIndex = 16;
            this.btnAgregarDetalles.Text = "Agregar";
            this.btnAgregarDetalles.UseVisualStyleBackColor = true;
            this.btnAgregarDetalles.Click += new System.EventHandler(this.btnAgregarDetalles_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Buscar(id_factura / tipo):";
            // 
            // txtBuscarDetalles
            // 
            this.txtBuscarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDetalles.Location = new System.Drawing.Point(4, 85);
            this.txtBuscarDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarDetalles.Name = "txtBuscarDetalles";
            this.txtBuscarDetalles.Size = new System.Drawing.Size(523, 30);
            this.txtBuscarDetalles.TabIndex = 7;
            this.txtBuscarDetalles.TextChanged += new System.EventHandler(this.txtBuscarDetalles_TextChanged);
            // 
            // dgvDatosDetalles
            // 
            this.dgvDatosDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDetalles.ContextMenuStrip = this.cmsEditarEliminarDetalles;
            this.dgvDatosDetalles.Location = new System.Drawing.Point(4, 132);
            this.dgvDatosDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatosDetalles.Name = "dgvDatosDetalles";
            this.dgvDatosDetalles.RowHeadersWidth = 62;
            this.dgvDatosDetalles.Size = new System.Drawing.Size(952, 357);
            this.dgvDatosDetalles.TabIndex = 1;
            // 
            // cmsEditarEliminarFacturas
            // 
            this.cmsEditarEliminarFacturas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEditarEliminarFacturas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiEditarFacturas,
            this.TsmiEliminarFacturas});
            this.cmsEditarEliminarFacturas.Name = "cmsEditarEliminar";
            this.cmsEditarEliminarFacturas.Size = new System.Drawing.Size(147, 68);
            // 
            // TsmiEditarFacturas
            // 
            this.TsmiEditarFacturas.Name = "TsmiEditarFacturas";
            this.TsmiEditarFacturas.Size = new System.Drawing.Size(146, 32);
            this.TsmiEditarFacturas.Text = "Editar";
            this.TsmiEditarFacturas.Click += new System.EventHandler(this.TsmiEditarFacturas_Click);
            // 
            // TsmiEliminarFacturas
            // 
            this.TsmiEliminarFacturas.Name = "TsmiEliminarFacturas";
            this.TsmiEliminarFacturas.Size = new System.Drawing.Size(146, 32);
            this.TsmiEliminarFacturas.Text = "Eliminar";
            this.TsmiEliminarFacturas.Click += new System.EventHandler(this.TsmiEliminarFacturas_Click);
            // 
            // cmsEditarEliminarDetalles
            // 
            this.cmsEditarEliminarDetalles.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEditarEliminarDetalles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditarDetallesFactura,
            this.EliminarDetallesFactura});
            this.cmsEditarEliminarDetalles.Name = "cmsEditarEliminar";
            this.cmsEditarEliminarDetalles.Size = new System.Drawing.Size(147, 68);
            // 
            // EditarDetallesFactura
            // 
            this.EditarDetallesFactura.Name = "EditarDetallesFactura";
            this.EditarDetallesFactura.Size = new System.Drawing.Size(146, 32);
            this.EditarDetallesFactura.Text = "Editar";
            this.EditarDetallesFactura.Click += new System.EventHandler(this.EditarDetallesFactura_Click);
            // 
            // EliminarDetallesFactura
            // 
            this.EliminarDetallesFactura.Name = "EliminarDetallesFactura";
            this.EliminarDetallesFactura.Size = new System.Drawing.Size(146, 32);
            this.EliminarDetallesFactura.Text = "Eliminar";
            this.EliminarDetallesFactura.Click += new System.EventHandler(this.EliminarDetallesFactura_Click);
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 692);
            this.Controls.Add(this.tbPaginacion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFacturas";
            this.Text = "Facturas";
            this.tbPaginacion.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosFacturas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDetalles)).EndInit();
            this.cmsEditarEliminarFacturas.ResumeLayout(false);
            this.cmsEditarEliminarDetalles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbPaginacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mktHora;
        private System.Windows.Forms.Button btnAgregarFacturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvDatosFacturas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescPago;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtCostoAsoc;
        private System.Windows.Forms.TextBox txtDescrFactura;
        private System.Windows.Forms.ComboBox cbMedioPago;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.ComboBox cbFactura;
        private System.Windows.Forms.Button btnAgregarDetalles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarDetalles;
        private System.Windows.Forms.DataGridView dgvDatosDetalles;
        private System.Windows.Forms.ContextMenuStrip cmsEditarEliminarFacturas;
        private System.Windows.Forms.ToolStripMenuItem TsmiEditarFacturas;
        private System.Windows.Forms.ToolStripMenuItem TsmiEliminarFacturas;
        private System.Windows.Forms.ContextMenuStrip cmsEditarEliminarDetalles;
        private System.Windows.Forms.ToolStripMenuItem EditarDetallesFactura;
        private System.Windows.Forms.ToolStripMenuItem EliminarDetallesFactura;
    }
}