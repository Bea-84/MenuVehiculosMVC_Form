namespace MenuVehiculosMVC_Form.View
{
    partial class MostrarVehiculoView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBuscarVehiculo = new System.Windows.Forms.Label();
            this.listBoxVehiculos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxmatricula = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar Vehiculos";
            // 
            // lbBuscarVehiculo
            // 
            this.lbBuscarVehiculo.AutoSize = true;
            this.lbBuscarVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBuscarVehiculo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarVehiculo.Location = new System.Drawing.Point(58, 240);
            this.lbBuscarVehiculo.Name = "lbBuscarVehiculo";
            this.lbBuscarVehiculo.Size = new System.Drawing.Size(194, 35);
            this.lbBuscarVehiculo.TabIndex = 1;
            this.lbBuscarVehiculo.Text = "Buscar Vehiculo";
            this.lbBuscarVehiculo.Click += new System.EventHandler(this.lbBuscarVehiculo_Click);
            // 
            // listBoxVehiculos
            // 
            this.listBoxVehiculos.FormattingEnabled = true;
            this.listBoxVehiculos.Location = new System.Drawing.Point(384, 59);
            this.listBoxVehiculos.Name = "listBoxVehiculos";
            this.listBoxVehiculos.Size = new System.Drawing.Size(345, 147);
            this.listBoxVehiculos.TabIndex = 2;
            this.listBoxVehiculos.SelectedIndexChanged += new System.EventHandler(this.listBoxVehiculos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matrícula:";
            // 
            // textBoxmatricula
            // 
            this.textBoxmatricula.Location = new System.Drawing.Point(384, 344);
            this.textBoxmatricula.Name = "textBoxmatricula";
            this.textBoxmatricula.Size = new System.Drawing.Size(218, 20);
            this.textBoxmatricula.TabIndex = 4;
            this.textBoxmatricula.TextChanged += new System.EventHandler(this.textBoxmatricula_TextChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(653, 344);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(654, 401);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // MostrarVehiculoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.textBoxmatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxVehiculos);
            this.Controls.Add(this.lbBuscarVehiculo);
            this.Controls.Add(this.label1);
            this.Name = "MostrarVehiculoView";
            this.Text = "MostrarVehiculoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBuscarVehiculo;
        private System.Windows.Forms.ListBox listBoxVehiculos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxmatricula;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSalir;
    }
}