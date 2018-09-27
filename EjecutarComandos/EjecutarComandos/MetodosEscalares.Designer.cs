namespace Ejecutar_comandos
{
    partial class MetodosEscalares
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
            this.lblTotalFilas = new System.Windows.Forms.Label();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.btnTotalFilas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalFilas
            // 
            this.lblTotalFilas.AutoSize = true;
            this.lblTotalFilas.Location = new System.Drawing.Point(8, 67);
            this.lblTotalFilas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalFilas.Name = "lblTotalFilas";
            this.lblTotalFilas.Size = new System.Drawing.Size(187, 25);
            this.lblTotalFilas.TabIndex = 0;
            this.lblTotalFilas.Text = "Total de Registros";
            // 
            // txtEscalar
            // 
            this.txtEscalar.Location = new System.Drawing.Point(210, 23);
            this.txtEscalar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEscalar.Multiline = true;
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEscalar.Size = new System.Drawing.Size(324, 121);
            this.txtEscalar.TabIndex = 1;
            // 
            // btnTotalFilas
            // 
            this.btnTotalFilas.Location = new System.Drawing.Point(550, 58);
            this.btnTotalFilas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTotalFilas.Name = "btnTotalFilas";
            this.btnTotalFilas.Size = new System.Drawing.Size(216, 44);
            this.btnTotalFilas.TabIndex = 2;
            this.btnTotalFilas.Text = "Contar Registros";
            this.btnTotalFilas.UseVisualStyleBackColor = true;
            this.btnTotalFilas.Click += new System.EventHandler(this.btnTotalFilas_Click);
            // 
            // MetodosEscalares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 175);
            this.Controls.Add(this.btnTotalFilas);
            this.Controls.Add(this.txtEscalar);
            this.Controls.Add(this.lblTotalFilas);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MetodosEscalares";
            this.Text = "Métodos Escalares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalFilas;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Button btnTotalFilas;
    }
}