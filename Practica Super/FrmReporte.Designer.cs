namespace Practica_Super
{
    partial class FrmReporte
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
            this.CrvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvReporte
            // 
            this.CrvReporte.ActiveViewIndex = -1;
            this.CrvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvReporte.Location = new System.Drawing.Point(0, 0);
            this.CrvReporte.Name = "CrvReporte";
            this.CrvReporte.Size = new System.Drawing.Size(1037, 562);
            this.CrvReporte.TabIndex = 0;
            this.CrvReporte.Load += new System.EventHandler(this.CrvReporte_Load);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 562);
            this.Controls.Add(this.CrvReporte);
            this.Name = "FrmReporte";
            this.Text = "Informe de Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporte;
    }
}