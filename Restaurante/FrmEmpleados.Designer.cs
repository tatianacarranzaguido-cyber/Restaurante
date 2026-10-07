namespace Restaurante
{
    partial class FrmEmpleados
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
            groupBox1 = new GroupBox();
            txtSalario = new TextBox();
            txtTelefono = new TextBox();
            txtCargo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            dtpFechaContratacion = new DateTimePicker();
            lblSalario = new Label();
            lblTelefono = new Label();
            lblCargo = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            gbxAcciones = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnGuardar = new Button();
            dgvEmpleados = new DataGridView();
            groupBox1.SuspendLayout();
            gbxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(dtpFechaContratacion);
            groupBox1.Controls.Add(lblSalario);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblCargo);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(121, 241);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 27);
            txtSalario.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(121, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(121, 134);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(125, 27);
            txtCargo.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(121, 87);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaContratacion.Location = new Point(7, 288);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(315, 24);
            dtpFechaContratacion.TabIndex = 5;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario.Location = new Point(7, 244);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(74, 20);
            lblSalario.TabIndex = 4;
            lblSalario.Text = "Salario:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(7, 189);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(87, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(7, 134);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(65, 20);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(7, 87);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(7, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // gbxAcciones
            // 
            gbxAcciones.Controls.Add(btnSalir);
            gbxAcciones.Controls.Add(btnLimpiar);
            gbxAcciones.Controls.Add(btnMostrar);
            gbxAcciones.Controls.Add(btnGuardar);
            gbxAcciones.Location = new Point(19, 393);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Size = new Size(321, 250);
            gbxAcciones.TabIndex = 1;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(10, 200);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(10, 148);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(10, 90);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(102, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(10, 32);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(449, 39);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(564, 209);
            dgvEmpleados.TabIndex = 2;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1059, 666);
            Controls.Add(dgvEmpleados);
            Controls.Add(gbxAcciones);
            Controls.Add(groupBox1);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNombre;
        private TextBox txtSalario;
        private TextBox txtTelefono;
        private TextBox txtCargo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaContratacion;
        private Label lblSalario;
        private Label lblTelefono;
        private Label lblCargo;
        private Label lblApellido;
        private GroupBox gbxAcciones;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnGuardar;
        private DataGridView dgvEmpleados;
    }
}