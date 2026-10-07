namespace Restaurante
{
    partial class FrmReservaciones
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
            gbxDatosReservacion = new GroupBox();
            numCantPersonas = new NumericUpDown();
            dtpHora = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            cboMesa = new ComboBox();
            cboCliente = new ComboBox();
            lblCantPersonas = new Label();
            lblHora = new Label();
            lblFecha = new Label();
            lblMesa = new Label();
            lblCliente = new Label();
            gbxAcciones = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnGuardar = new Button();
            dgvReservaciones = new DataGridView();
            gbxDatosReservacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantPersonas).BeginInit();
            gbxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).BeginInit();
            SuspendLayout();
            // 
            // gbxDatosReservacion
            // 
            gbxDatosReservacion.Controls.Add(numCantPersonas);
            gbxDatosReservacion.Controls.Add(dtpHora);
            gbxDatosReservacion.Controls.Add(dtpFecha);
            gbxDatosReservacion.Controls.Add(cboMesa);
            gbxDatosReservacion.Controls.Add(cboCliente);
            gbxDatosReservacion.Controls.Add(lblCantPersonas);
            gbxDatosReservacion.Controls.Add(lblHora);
            gbxDatosReservacion.Controls.Add(lblFecha);
            gbxDatosReservacion.Controls.Add(lblMesa);
            gbxDatosReservacion.Controls.Add(lblCliente);
            gbxDatosReservacion.Location = new Point(12, 12);
            gbxDatosReservacion.Name = "gbxDatosReservacion";
            gbxDatosReservacion.Size = new Size(538, 320);
            gbxDatosReservacion.TabIndex = 0;
            gbxDatosReservacion.TabStop = false;
            gbxDatosReservacion.Text = "Datos de la Reservacion";
            // 
            // numCantPersonas
            // 
            numCantPersonas.Location = new Point(190, 267);
            numCantPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numCantPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantPersonas.Name = "numCantPersonas";
            numCantPersonas.Size = new Size(194, 27);
            numCantPersonas.TabIndex = 9;
            numCantPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(187, 203);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(284, 27);
            dtpHora.TabIndex = 8;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(187, 153);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(284, 27);
            dtpFecha.TabIndex = 7;
            // 
            // cboMesa
            // 
            cboMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMesa.FormattingEnabled = true;
            cboMesa.Location = new Point(187, 93);
            cboMesa.Name = "cboMesa";
            cboMesa.Size = new Size(151, 28);
            cboMesa.TabIndex = 6;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(187, 39);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(151, 28);
            cboCliente.TabIndex = 5;
            // 
            // lblCantPersonas
            // 
            lblCantPersonas.AutoSize = true;
            lblCantPersonas.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantPersonas.Location = new Point(7, 269);
            lblCantPersonas.Name = "lblCantPersonas";
            lblCantPersonas.Size = new Size(174, 20);
            lblCantPersonas.TabIndex = 4;
            lblCantPersonas.Text = "Cantidad Personas:";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(7, 210);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(56, 20);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(7, 153);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesa.Location = new Point(7, 96);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(60, 20);
            lblMesa.TabIndex = 1;
            lblMesa.Text = "Mesa:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(7, 41);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(74, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // gbxAcciones
            // 
            gbxAcciones.Controls.Add(btnSalir);
            gbxAcciones.Controls.Add(btnLimpiar);
            gbxAcciones.Controls.Add(btnMostrar);
            gbxAcciones.Controls.Add(btnGuardar);
            gbxAcciones.Location = new Point(16, 365);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Size = new Size(380, 253);
            gbxAcciones.TabIndex = 1;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(12, 204);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(12, 144);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(12, 87);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(103, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(12, 30);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvReservaciones
            // 
            dgvReservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservaciones.Location = new Point(610, 54);
            dgvReservaciones.Name = "dgvReservaciones";
            dgvReservaciones.RowHeadersWidth = 51;
            dgvReservaciones.Size = new Size(538, 231);
            dgvReservaciones.TabIndex = 2;
            // 
            // FrmReservaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1176, 673);
            Controls.Add(dgvReservaciones);
            Controls.Add(gbxAcciones);
            Controls.Add(gbxDatosReservacion);
            Name = "FrmReservaciones";
            Text = "FrmReservaciones";
            gbxDatosReservacion.ResumeLayout(false);
            gbxDatosReservacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantPersonas).EndInit();
            gbxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatosReservacion;
        private Label lblCantPersonas;
        private Label lblHora;
        private Label lblFecha;
        private Label lblMesa;
        private Label lblCliente;
        private NumericUpDown numCantPersonas;
        private DateTimePicker dtpHora;
        private DateTimePicker dtpFecha;
        private ComboBox cboMesa;
        private ComboBox cboCliente;
        private GroupBox gbxAcciones;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnGuardar;
        private DataGridView dgvReservaciones;
    }
}