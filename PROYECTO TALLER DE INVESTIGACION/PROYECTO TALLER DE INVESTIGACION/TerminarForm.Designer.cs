namespace PROYECTO_TALLER_DE_INVESTIGACION
{
    partial class TerminarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminarForm));
            this.panel_Inicio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Inicio
            // 
            this.panel_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel_Inicio.Controls.Add(this.pictureBox1);
            this.panel_Inicio.Controls.Add(this.label2);
            this.panel_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Inicio.Location = new System.Drawing.Point(0, 0);
            this.panel_Inicio.Name = "panel_Inicio";
            this.panel_Inicio.Size = new System.Drawing.Size(796, 75);
            this.panel_Inicio.TabIndex = 14;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos Guardados";
            // 
            // btnTerminar
            // 
            this.btnTerminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnTerminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminar.BorderRadius = 5;
            this.btnTerminar.ButtonText = "Menu Principal";
            this.btnTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTerminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnTerminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTerminar.Iconimage = null;
            this.btnTerminar.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnTerminar.Iconimage_right")));
            this.btnTerminar.Iconimage_right_Selected = null;
            this.btnTerminar.Iconimage_Selected = null;
            this.btnTerminar.IconMarginLeft = 0;
            this.btnTerminar.IconMarginRight = 0;
            this.btnTerminar.IconRightVisible = true;
            this.btnTerminar.IconRightZoom = 0D;
            this.btnTerminar.IconVisible = true;
            this.btnTerminar.IconZoom = 50D;
            this.btnTerminar.IsTab = false;
            this.btnTerminar.Location = new System.Drawing.Point(315, 237);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnTerminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(170)))));
            this.btnTerminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTerminar.selected = false;
            this.btnTerminar.Size = new System.Drawing.Size(146, 48);
            this.btnTerminar.TabIndex = 15;
            this.btnTerminar.Text = "Menu Principal";
            this.btnTerminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTerminar.Textcolor = System.Drawing.Color.White;
            this.btnTerminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TerminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 445);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.panel_Inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TerminarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerminarForm";
            this.panel_Inicio.ResumeLayout(false);
            this.panel_Inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton btnTerminar;
    }
}