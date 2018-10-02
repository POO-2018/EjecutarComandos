namespace Ejecutar_comandos
{
    partial class StoredProcedure
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
            this.gbEliminarMoneda = new System.Windows.Forms.GroupBox();
            this.lblEstadoEliminacion = new System.Windows.Forms.Label();
            this.btnEliminarMoneda = new System.Windows.Forms.Button();
            this.btnCargarMonedas = new System.Windows.Forms.Button();
            this.lstCodigoMoneda = new System.Windows.Forms.ListBox();
            this.gbEliminarMoneda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEliminarMoneda
            // 
            this.gbEliminarMoneda.Controls.Add(this.lblEstadoEliminacion);
            this.gbEliminarMoneda.Controls.Add(this.btnEliminarMoneda);
            this.gbEliminarMoneda.Controls.Add(this.btnCargarMonedas);
            this.gbEliminarMoneda.Controls.Add(this.lstCodigoMoneda);
            this.gbEliminarMoneda.Location = new System.Drawing.Point(24, 23);
            this.gbEliminarMoneda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbEliminarMoneda.Name = "gbEliminarMoneda";
            this.gbEliminarMoneda.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbEliminarMoneda.Size = new System.Drawing.Size(784, 456);
            this.gbEliminarMoneda.TabIndex = 0;
            this.gbEliminarMoneda.TabStop = false;
            this.gbEliminarMoneda.Text = "Eliminar Moneda";
            // 
            // lblEstadoEliminacion
            // 
            this.lblEstadoEliminacion.Location = new System.Drawing.Point(50, 331);
            this.lblEstadoEliminacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstadoEliminacion.Name = "lblEstadoEliminacion";
            this.lblEstadoEliminacion.Size = new System.Drawing.Size(684, 44);
            this.lblEstadoEliminacion.TabIndex = 3;
            // 
            // btnEliminarMoneda
            // 
            this.btnEliminarMoneda.Location = new System.Drawing.Point(372, 196);
            this.btnEliminarMoneda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEliminarMoneda.Name = "btnEliminarMoneda";
            this.btnEliminarMoneda.Size = new System.Drawing.Size(302, 44);
            this.btnEliminarMoneda.TabIndex = 2;
            this.btnEliminarMoneda.Text = "Eliminar Moneda";
            this.btnEliminarMoneda.UseVisualStyleBackColor = true;
            // 
            // btnCargarMonedas
            // 
            this.btnCargarMonedas.Location = new System.Drawing.Point(372, 58);
            this.btnCargarMonedas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCargarMonedas.Name = "btnCargarMonedas";
            this.btnCargarMonedas.Size = new System.Drawing.Size(302, 44);
            this.btnCargarMonedas.TabIndex = 1;
            this.btnCargarMonedas.Text = "Cargar listado de monedas";
            this.btnCargarMonedas.UseVisualStyleBackColor = true;
            this.btnCargarMonedas.Click += new System.EventHandler(this.btnCargarMonedas_Click);
            // 
            // lstCodigoMoneda
            // 
            this.lstCodigoMoneda.FormattingEnabled = true;
            this.lstCodigoMoneda.ItemHeight = 25;
            this.lstCodigoMoneda.Location = new System.Drawing.Point(50, 58);
            this.lstCodigoMoneda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstCodigoMoneda.Name = "lstCodigoMoneda";
            this.lstCodigoMoneda.Size = new System.Drawing.Size(270, 254);
            this.lstCodigoMoneda.TabIndex = 0;
            // 
            // StoredProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 502);
            this.Controls.Add(this.gbEliminarMoneda);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StoredProcedure";
            this.Text = "Ejecutando Stored Procedure";
            this.gbEliminarMoneda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminarMoneda;
        private System.Windows.Forms.ListBox lstCodigoMoneda;
        private System.Windows.Forms.Label lblEstadoEliminacion;
        private System.Windows.Forms.Button btnEliminarMoneda;
        private System.Windows.Forms.Button btnCargarMonedas;
    }
}