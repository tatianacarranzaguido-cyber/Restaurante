namespace Restaurante
{
    partial class FrmClientes
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
            gbxDatoCliente = new GroupBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lblCorre = new Label();
            lblTelef = new Label();
            lblNomb = new Label();
            gbxAcciones = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnguardar = new Button();
            dgvClientes = new DataGridView();
            gbxDatoCliente.SuspendLayout();
            gbxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // gbxDatoCliente
            // 
            gbxDatoCliente.Controls.Add(txtCorreo);
            gbxDatoCliente.Controls.Add(txtTelefono);
            gbxDatoCliente.Controls.Add(txtNombre);
            gbxDatoCliente.Controls.Add(lblCorre);
            gbxDatoCliente.Controls.Add(lblTelef);
            gbxDatoCliente.Controls.Add(lblNomb);
            gbxDatoCliente.Location = new Point(12, 21);
            gbxDatoCliente.Name = "gbxDatoCliente";
            gbxDatoCliente.Size = new Size(361, 223);
            gbxDatoCliente.TabIndex = 0;
            gbxDatoCliente.TabStop = false;
            gbxDatoCliente.Text = "Datos del Cliente";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(154, 150);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(154, 92);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblCorre
            // 
            lblCorre.AutoSize = true;
            lblCorre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorre.Location = new Point(21, 153);
            lblCorre.Name = "lblCorre";
            lblCorre.Size = new Size(72, 20);
            lblCorre.TabIndex = 2;
            lblCorre.Text = "Correo:";
            // 
            // lblTelef
            // 
            lblTelef.AutoSize = true;
            lblTelef.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelef.Location = new Point(21, 95);
            lblTelef.Name = "lblTelef";
            lblTelef.Size = new Size(87, 20);
            lblTelef.TabIndex = 1;
            lblTelef.Text = "Telefono:";
            // 
            // lblNomb
            // 
            lblNomb.AutoSize = true;
            lblNomb.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomb.Location = new Point(21, 42);
            lblNomb.Name = "lblNomb";
            lblNomb.Size = new Size(80, 20);
            lblNomb.TabIndex = 0;
            lblNomb.Text = "Nombre:";
            // 
            // gbxAcciones
            // 
            gbxAcciones.Controls.Add(btnSalir);
            gbxAcciones.Controls.Add(btnLimpiar);
            gbxAcciones.Controls.Add(btnMostrar);
            gbxAcciones.Controls.Add(btnguardar);
            gbxAcciones.Location = new Point(12, 267);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Size = new Size(361, 246);
            gbxAcciones.TabIndex = 1;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(11, 196);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(11, 142);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(11, 85);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnguardar
            // 
            btnguardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(11, 34);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(94, 29);
            btnguardar.TabIndex = 0;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(474, 35);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(547, 225);
            dgvClientes.TabIndex = 2;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1056, 648);
            Controls.Add(dgvClientes);
            Controls.Add(gbxAcciones);
            Controls.Add(gbxDatoCliente);
            Name = "FrmClientes";
            Text = "FrmClientes";
            gbxDatoCliente.ResumeLayout(false);
            gbxDatoCliente.PerformLayout();
            gbxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatoCliente;
        private Label lblCorre;
        private Label lblTelef;
        private Label lblNomb;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private GroupBox gbxAcciones;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnguardar;
        private DataGridView dgvClientes;
    }
}