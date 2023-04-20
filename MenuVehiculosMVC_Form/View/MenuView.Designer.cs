namespace MenuVehiculosMVC_Form.View
{
    partial class MenuView
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
            this.btaltaVehiculos = new System.Windows.Forms.Button();
            this.btAltaClientes = new System.Windows.Forms.Button();
            this.btMostrarVehiculos = new System.Windows.Forms.Button();
            this.btMostrarClientes = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btaltaVehiculos
            // 
            this.btaltaVehiculos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btaltaVehiculos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaltaVehiculos.Location = new System.Drawing.Point(93, 88);
            this.btaltaVehiculos.Name = "btaltaVehiculos";
            this.btaltaVehiculos.Size = new System.Drawing.Size(191, 47);
            this.btaltaVehiculos.TabIndex = 0;
            this.btaltaVehiculos.Text = "Alta Vehiculos";
            this.btaltaVehiculos.UseVisualStyleBackColor = false;
            this.btaltaVehiculos.Click += new System.EventHandler(this.btaltaVehiculos_Click);
            // 
            // btAltaClientes
            // 
            this.btAltaClientes.BackColor = System.Drawing.SystemColors.Info;
            this.btAltaClientes.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAltaClientes.Location = new System.Drawing.Point(467, 92);
            this.btAltaClientes.Name = "btAltaClientes";
            this.btAltaClientes.Size = new System.Drawing.Size(191, 43);
            this.btAltaClientes.TabIndex = 1;
            this.btAltaClientes.Text = "Alta clientes";
            this.btAltaClientes.UseVisualStyleBackColor = false;
            this.btAltaClientes.Click += new System.EventHandler(this.btAltaClientes_Click);
            // 
            // btMostrarVehiculos
            // 
            this.btMostrarVehiculos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMostrarVehiculos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrarVehiculos.Location = new System.Drawing.Point(93, 241);
            this.btMostrarVehiculos.Name = "btMostrarVehiculos";
            this.btMostrarVehiculos.Size = new System.Drawing.Size(191, 46);
            this.btMostrarVehiculos.TabIndex = 2;
            this.btMostrarVehiculos.Text = "Mostrar Vehiculos";
            this.btMostrarVehiculos.UseVisualStyleBackColor = false;
            this.btMostrarVehiculos.Click += new System.EventHandler(this.btMostrarVehiculos_Click);
            // 
            // btMostrarClientes
            // 
            this.btMostrarClientes.BackColor = System.Drawing.SystemColors.Info;
            this.btMostrarClientes.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrarClientes.Location = new System.Drawing.Point(467, 240);
            this.btMostrarClientes.Name = "btMostrarClientes";
            this.btMostrarClientes.Size = new System.Drawing.Size(191, 47);
            this.btMostrarClientes.TabIndex = 3;
            this.btMostrarClientes.Text = "Mostrar Clientes";
            this.btMostrarClientes.UseVisualStyleBackColor = false;
            this.btMostrarClientes.Click += new System.EventHandler(this.btMostrarClientes_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btSalir.Location = new System.Drawing.Point(344, 376);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btMostrarClientes);
            this.Controls.Add(this.btMostrarVehiculos);
            this.Controls.Add(this.btAltaClientes);
            this.Controls.Add(this.btaltaVehiculos);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btaltaVehiculos;
        private System.Windows.Forms.Button btAltaClientes;
        private System.Windows.Forms.Button btMostrarVehiculos;
        private System.Windows.Forms.Button btMostrarClientes;
        private System.Windows.Forms.Button btSalir;
    }
}