﻿namespace Ejecutar_comandos
{
    partial class ExecuteReader
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
            this.txtReader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtReader
            // 
            this.txtReader.Location = new System.Drawing.Point(24, 23);
            this.txtReader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReader.Multiline = true;
            this.txtReader.Name = "txtReader";
            this.txtReader.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReader.Size = new System.Drawing.Size(1016, 452);
            this.txtReader.TabIndex = 0;
            // 
            // ExecuteReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 502);
            this.Controls.Add(this.txtReader);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ExecuteReader";
            this.Text = "ExecuteReader";
            this.Load += new System.EventHandler(this.ExecuteReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReader;
    }
}