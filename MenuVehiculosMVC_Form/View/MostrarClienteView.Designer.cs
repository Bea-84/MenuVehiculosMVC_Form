namespace MenuVehiculosMVC_Form.View
{
    partial class MostrarClienteView
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
            this.lbMostrarClientes = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbBuscarCliente = new System.Windows.Forms.Label();
            this.lbNif = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMostrarClientes
            // 
            this.lbMostrarClientes.AutoSize = true;
            this.lbMostrarClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMostrarClientes.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarClientes.Location = new System.Drawing.Point(58, 55);
            this.lbMostrarClientes.Name = "lbMostrarClientes";
            this.lbMostrarClientes.Size = new System.Drawing.Size(201, 35);
            this.lbMostrarClientes.TabIndex = 0;
            this.lbMostrarClientes.Text = "Mostrar clientes";
            this.lbMostrarClientes.Click += new System.EventHandler(this.lbMostrarClientes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(365, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 147);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbBuscarCliente
            // 
            this.lbBuscarCliente.AutoSize = true;
            this.lbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBuscarCliente.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarCliente.Location = new System.Drawing.Point(58, 244);
            this.lbBuscarCliente.Name = "lbBuscarCliente";
            this.lbBuscarCliente.Size = new System.Drawing.Size(176, 35);
            this.lbBuscarCliente.TabIndex = 2;
            this.lbBuscarCliente.Text = "Buscar Cliente";
            this.lbBuscarCliente.Click += new System.EventHandler(this.lbBucarCliente_Click);
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNif.Location = new System.Drawing.Point(64, 337);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(44, 26);
            this.lbNif.TabIndex = 3;
            this.lbNif.Text = "Nif:";
            this.lbNif.Click += new System.EventHandler(this.lbNif_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(654, 339);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(655, 399);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MostrarClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNif);
            this.Controls.Add(this.lbBuscarCliente);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbMostrarClientes);
            this.Name = "MostrarClienteView";
            this.Text = "MostrarClienteView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMostrarClientes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbBuscarCliente;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSalir;
    }
}