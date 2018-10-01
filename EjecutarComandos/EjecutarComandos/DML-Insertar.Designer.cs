namespace Ejecutar_comandos
{
    partial class DML_Insertar
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
            this.gbInsertarMonedas = new System.Windows.Forms.GroupBox();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.btnInsertarMoneda = new System.Windows.Forms.Button();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.txtNombreMoneda = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigoMoneda = new System.Windows.Forms.TextBox();
            this.lblCodigoMoneda = new System.Windows.Forms.Label();
            this.lblEstadoInsercion = new System.Windows.Forms.Label();
            this.gbInsertarMonedas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInsertarMonedas
            // 
            this.gbInsertarMonedas.Controls.Add(this.dtpFechaModificacion);
            this.gbInsertarMonedas.Controls.Add(this.btnInsertarMoneda);
            this.gbInsertarMonedas.Controls.Add(this.lblFechaModificacion);
            this.gbInsertarMonedas.Controls.Add(this.txtNombreMoneda);
            this.gbInsertarMonedas.Controls.Add(this.lblNombre);
            this.gbInsertarMonedas.Controls.Add(this.txtCodigoMoneda);
            this.gbInsertarMonedas.Controls.Add(this.lblCodigoMoneda);
            this.gbInsertarMonedas.Location = new System.Drawing.Point(24, 23);
            this.gbInsertarMonedas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbInsertarMonedas.Name = "gbInsertarMonedas";
            this.gbInsertarMonedas.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbInsertarMonedas.Size = new System.Drawing.Size(734, 431);
            this.gbInsertarMonedas.TabIndex = 0;
            this.gbInsertarMonedas.TabStop = false;
            this.gbInsertarMonedas.Text = "Insertar Moneda";
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.CustomFormat = "MM/dd/yyyy";
            this.dtpFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaModificacion.Location = new System.Drawing.Point(284, 192);
            this.dtpFechaModificacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(396, 31);
            this.dtpFechaModificacion.TabIndex = 8;
            // 
            // btnInsertarMoneda
            // 
            this.btnInsertarMoneda.Location = new System.Drawing.Point(268, 271);
            this.btnInsertarMoneda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsertarMoneda.Name = "btnInsertarMoneda";
            this.btnInsertarMoneda.Size = new System.Drawing.Size(200, 44);
            this.btnInsertarMoneda.TabIndex = 6;
            this.btnInsertarMoneda.Text = "Insertar Moneda";
            this.btnInsertarMoneda.UseVisualStyleBackColor = true;
            this.btnInsertarMoneda.Click += new System.EventHandler(this.btnInsertarMoneda_Click);
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Location = new System.Drawing.Point(44, 192);
            this.lblFechaModificacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(228, 25);
            this.lblFechaModificacion.TabIndex = 4;
            this.lblFechaModificacion.Text = "Fecha de modificación";
            // 
            // txtNombreMoneda
            // 
            this.txtNombreMoneda.Location = new System.Drawing.Point(284, 131);
            this.txtNombreMoneda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombreMoneda.Name = "txtNombreMoneda";
            this.txtNombreMoneda.Size = new System.Drawing.Size(196, 31);
            this.txtNombreMoneda.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 131);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(223, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de la moneda";
            // 
            // txtCodigoMoneda
            // 
            this.txtCodigoMoneda.Location = new System.Drawing.Point(284, 71);
            this.txtCodigoMoneda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCodigoMoneda.Name = "txtCodigoMoneda";
            this.txtCodigoMoneda.Size = new System.Drawing.Size(196, 31);
            this.txtCodigoMoneda.TabIndex = 1;
            // 
            // lblCodigoMoneda
            // 
            this.lblCodigoMoneda.AutoSize = true;
            this.lblCodigoMoneda.Location = new System.Drawing.Point(44, 71);
            this.lblCodigoMoneda.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoMoneda.Name = "lblCodigoMoneda";
            this.lblCodigoMoneda.Size = new System.Drawing.Size(163, 25);
            this.lblCodigoMoneda.TabIndex = 0;
            this.lblCodigoMoneda.Text = "Código moneda";
            // 
            // lblEstadoInsercion
            // 
            this.lblEstadoInsercion.Location = new System.Drawing.Point(163, 394);
            this.lblEstadoInsercion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstadoInsercion.Name = "lblEstadoInsercion";
            this.lblEstadoInsercion.Size = new System.Drawing.Size(440, 44);
            this.lblEstadoInsercion.TabIndex = 7;
            // 
            // DML_Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 468);
            this.Controls.Add(this.lblEstadoInsercion);
            this.Controls.Add(this.gbInsertarMonedas);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DML_Insertar";
            this.Text = "Insertar monedas";
            this.gbInsertarMonedas.ResumeLayout(false);
            this.gbInsertarMonedas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsertarMonedas;
        private System.Windows.Forms.Label lblEstadoInsercion;
        private System.Windows.Forms.Button btnInsertarMoneda;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.TextBox txtNombreMoneda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigoMoneda;
        private System.Windows.Forms.Label lblCodigoMoneda;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
    }
}