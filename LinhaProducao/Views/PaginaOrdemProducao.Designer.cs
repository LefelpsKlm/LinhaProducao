﻿namespace LinhaProducao.Views
{
    partial class PaginaOrdemProducao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 4;
            // 
            // listViewClientes
            // 
            this.listViewClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.listViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClientes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClientes.ForeColor = System.Drawing.Color.White;
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(0, 83);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(788, 361);
            this.listViewClientes.TabIndex = 3;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewClientes);
            this.Name = "PaginaOrdemProducao";
            this.Text = "PaginaOrdemProducao";
            this.Load += new System.EventHandler(this.PaginaOrdemProducao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewClientes;
    }
}