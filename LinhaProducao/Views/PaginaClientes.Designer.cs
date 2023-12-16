namespace LinhaProducao.Views
{
    partial class PaginaClientes
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
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NvCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClientes
            // 
            this.listViewClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.listViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClientes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClientes.ForeColor = System.Drawing.Color.White;
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(0, 77);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(788, 361);
            this.listViewClientes.TabIndex = 0;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.SelectedIndexChanged += new System.EventHandler(this.listViewClientes_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.NvCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 2;
            // 
            // NvCliente
            // 
            this.NvCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NvCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(95)))), ((int)(((byte)(117)))));
            this.NvCliente.FlatAppearance.BorderSize = 0;
            this.NvCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NvCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NvCliente.ForeColor = System.Drawing.Color.White;
            this.NvCliente.Location = new System.Drawing.Point(12, 3);
            this.NvCliente.Name = "NvCliente";
            this.NvCliente.Size = new System.Drawing.Size(194, 46);
            this.NvCliente.TabIndex = 2;
            this.NvCliente.Text = "Adicionar Novo Cliente";
            this.NvCliente.UseVisualStyleBackColor = false;
            this.NvCliente.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // PaginaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewClientes);
            this.Name = "PaginaClientes";
            this.Text = "PaginaClientes";
            this.Load += new System.EventHandler(this.PaginaClientes_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NvCliente;
    }
}