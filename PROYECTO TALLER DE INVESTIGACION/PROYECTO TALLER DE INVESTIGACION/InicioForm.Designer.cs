namespace PROYECTO_TALLER_DE_INVESTIGACION
{
    partial class InicioForm
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
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResultados1 = new System.Windows.Forms.Button();
            this.btnResultadosFinales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(356, 67);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 0;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUESTIONARIO PARA IDENTIFICAR A LOS TRABAJADORES QUE FUERON SUJETOS A ACONTECIMIE" +
    "NTOS TRAUMÁTICOS SEVEROS";
            // 
            // btnResultados1
            // 
            this.btnResultados1.Location = new System.Drawing.Point(663, 67);
            this.btnResultados1.Name = "btnResultados1";
            this.btnResultados1.Size = new System.Drawing.Size(75, 23);
            this.btnResultados1.TabIndex = 2;
            this.btnResultados1.Text = "Resultados";
            this.btnResultados1.UseVisualStyleBackColor = true;
            // 
            // btnResultadosFinales
            // 
            this.btnResultadosFinales.Location = new System.Drawing.Point(339, 209);
            this.btnResultadosFinales.Name = "btnResultadosFinales";
            this.btnResultadosFinales.Size = new System.Drawing.Size(108, 47);
            this.btnResultadosFinales.TabIndex = 3;
            this.btnResultadosFinales.Text = "Consultar resultados finales";
            this.btnResultadosFinales.UseVisualStyleBackColor = true;
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 445);
            this.Controls.Add(this.btnResultadosFinales);
            this.Controls.Add(this.btnResultados1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEmpezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnResultados1;
        public System.Windows.Forms.Button btnResultadosFinales;
    }
}