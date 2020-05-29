namespace PROYECTO_TALLER_DE_INVESTIGACION
{
    partial class ResultadosFinalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadosFinalesForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Inicio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResultadosFinalesVolver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CE_EmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CE_Seccion_IBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CE_Seccion_IIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CE_Seccion_IIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CE_Seccion_IVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_EmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados Finales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_Inicio
            // 
            this.panel_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel_Inicio.Controls.Add(this.pictureBox1);
            this.panel_Inicio.Controls.Add(this.label1);
            this.panel_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Inicio.Location = new System.Drawing.Point(0, 0);
            this.panel_Inicio.Name = "panel_Inicio";
            this.panel_Inicio.Size = new System.Drawing.Size(796, 75);
            this.panel_Inicio.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(709, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnResultadosFinalesVolver
            // 
            this.btnResultadosFinalesVolver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnResultadosFinalesVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnResultadosFinalesVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResultadosFinalesVolver.BorderRadius = 5;
            this.btnResultadosFinalesVolver.ButtonText = "Volver";
            this.btnResultadosFinalesVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultadosFinalesVolver.DisabledColor = System.Drawing.Color.Gray;
            this.btnResultadosFinalesVolver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnResultadosFinalesVolver.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnResultadosFinalesVolver.Iconimage")));
            this.btnResultadosFinalesVolver.Iconimage_right = null;
            this.btnResultadosFinalesVolver.Iconimage_right_Selected = null;
            this.btnResultadosFinalesVolver.Iconimage_Selected = null;
            this.btnResultadosFinalesVolver.IconMarginLeft = 0;
            this.btnResultadosFinalesVolver.IconMarginRight = 0;
            this.btnResultadosFinalesVolver.IconRightVisible = true;
            this.btnResultadosFinalesVolver.IconRightZoom = 0D;
            this.btnResultadosFinalesVolver.IconVisible = true;
            this.btnResultadosFinalesVolver.IconZoom = 50D;
            this.btnResultadosFinalesVolver.IsTab = false;
            this.btnResultadosFinalesVolver.Location = new System.Drawing.Point(621, 373);
            this.btnResultadosFinalesVolver.Name = "btnResultadosFinalesVolver";
            this.btnResultadosFinalesVolver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnResultadosFinalesVolver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnResultadosFinalesVolver.OnHoverTextColor = System.Drawing.Color.White;
            this.btnResultadosFinalesVolver.selected = false;
            this.btnResultadosFinalesVolver.Size = new System.Drawing.Size(133, 37);
            this.btnResultadosFinalesVolver.TabIndex = 36;
            this.btnResultadosFinalesVolver.Text = "Volver";
            this.btnResultadosFinalesVolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResultadosFinalesVolver.Textcolor = System.Drawing.Color.White;
            this.btnResultadosFinalesVolver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_Empleado";
            reportDataSource1.Value = this.CE_EmpleadoBindingSource;
            reportDataSource2.Name = "DataSet_Seccion_I";
            reportDataSource2.Value = this.CE_Seccion_IBindingSource;
            reportDataSource3.Name = "DataSet_Seccion_II";
            reportDataSource3.Value = this.CE_Seccion_IIBindingSource;
            reportDataSource4.Name = "DataSet_Seccion_III";
            reportDataSource4.Value = this.CE_Seccion_IIIBindingSource;
            reportDataSource5.Name = "DataSet_Seccion_IV";
            reportDataSource5.Value = this.CE_Seccion_IVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_TALLER_DE_INVESTIGACION.reporte_Empleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(578, 316);
            this.reportViewer1.TabIndex = 37;
            // 
            // CE_EmpleadoBindingSource
            // 
            this.CE_EmpleadoBindingSource.DataSource = typeof(CapaEntidades.CE_Empleado);
            // 
            // CE_Seccion_IBindingSource
            // 
            this.CE_Seccion_IBindingSource.DataSource = typeof(CapaEntidades.CE_Seccion_I);
            // 
            // CE_Seccion_IIBindingSource
            // 
            this.CE_Seccion_IIBindingSource.DataSource = typeof(CapaEntidades.CE_Seccion_II);
            // 
            // CE_Seccion_IIIBindingSource
            // 
            this.CE_Seccion_IIIBindingSource.DataSource = typeof(CapaEntidades.CE_Seccion_III);
            // 
            // CE_Seccion_IVBindingSource
            // 
            this.CE_Seccion_IVBindingSource.DataSource = typeof(CapaEntidades.CE_Seccion_IV);
            // 
            // ResultadosFinalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 445);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnResultadosFinalesVolver);
            this.Controls.Add(this.panel_Inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultadosFinalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadosFinalesForm";
            this.Load += new System.EventHandler(this.ResultadosFinalesForm_Load);
            this.panel_Inicio.ResumeLayout(false);
            this.panel_Inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_EmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_Seccion_IVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuFlatButton btnResultadosFinalesVolver;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CE_EmpleadoBindingSource;
        private System.Windows.Forms.BindingSource CE_Seccion_IBindingSource;
        private System.Windows.Forms.BindingSource CE_Seccion_IIBindingSource;
        private System.Windows.Forms.BindingSource CE_Seccion_IIIBindingSource;
        private System.Windows.Forms.BindingSource CE_Seccion_IVBindingSource;
    }
}