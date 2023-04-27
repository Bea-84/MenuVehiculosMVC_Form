namespace MenuVehiculosMVC_Form.View
{
    partial class lbaltaClienteCompletada
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
            this.lbAltaClientes = new System.Windows.Forms.Label();
            this.lbNif = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.lbaltaCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAltaClientes
            // 
            this.lbAltaClientes.AutoSize = true;
            this.lbAltaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAltaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbAltaClientes.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltaClientes.Location = new System.Drawing.Point(316, 45);
            this.lbAltaClientes.Name = "lbAltaClientes";
            this.lbAltaClientes.Size = new System.Drawing.Size(158, 35);
            this.lbAltaClientes.TabIndex = 0;
            this.lbAltaClientes.Text = "Alta Clientes";
            this.lbAltaClientes.Click += new System.EventHandler(this.lbAltaClientes_Click);
            // 
            // lbNif
            // 
            this.lbNif.AutoSize = true;
            this.lbNif.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNif.Location = new System.Drawing.Point(40, 128);
            this.lbNif.Name = "lbNif";
            this.lbNif.Size = new System.Drawing.Size(44, 26);
            this.lbNif.TabIndex = 1;
            this.lbNif.Text = "Nif:";
            this.lbNif.Click += new System.EventHandler(this.lbNif_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(39, 185);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(89, 26);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(189, 268);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(367, 268);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(561, 268);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 7;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(45, 372);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(168, 26);
            this.lbMensaje.TabIndex = 8;
            this.lbMensaje.Text = "El cliente ya existe";
            this.lbMensaje.Visible = false;
            this.lbMensaje.Click += new System.EventHandler(this.lbMensaje_Click);
            // 
            // lbaltaCliente
            // 
            this.lbaltaCliente.AutoSize = true;
            this.lbaltaCliente.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaltaCliente.Location = new System.Drawing.Point(518, 372);
            this.lbaltaCliente.Name = "lbaltaCliente";
            this.lbaltaCliente.Size = new System.Drawing.Size(217, 26);
            this.lbaltaCliente.TabIndex = 9;
            this.lbaltaCliente.Text = "Alta cliente completada";
            this.lbaltaCliente.Visible = false;
            this.lbaltaCliente.Click += new System.EventHandler(this.lbaltaCliente_Click); 
            // 
            // lbaltaClienteCompletada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbaltaCliente);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbNif);
            this.Controls.Add(this.lbAltaClientes);
            this.Name = "lbaltaClienteCompletada";
            this.Text = "AltaClienteView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAltaClientes;
        private System.Windows.Forms.Label lbNif;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label lbaltaCliente;
    }
}