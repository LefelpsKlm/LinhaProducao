﻿namespace LinhaProducao.Views
{
    partial class PaginaLinhaProducao
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
            this.listViewLProducao = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 6;
            // 
            // listViewLProducao
            // 
            this.listViewLProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.listViewLProducao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewLProducao.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLProducao.ForeColor = System.Drawing.Color.White;
            this.listViewLProducao.HideSelection = false;
            this.listViewLProducao.Location = new System.Drawing.Point(0, 86);
            this.listViewLProducao.Name = "listViewLProducao";
            this.listViewLProducao.Size = new System.Drawing.Size(788, 361);
            this.listViewLProducao.TabIndex = 5;
            this.listViewLProducao.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaLinhaProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewLProducao);
            this.Name = "PaginaLinhaProducao";
            this.Text = "PaginaLinhaProducao";
            this.Load += new System.EventHandler(this.PaginaLinhaProducao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewLProducao;
    }
}