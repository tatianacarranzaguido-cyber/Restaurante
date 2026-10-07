namespace Restaurante
{
    partial class FrmPedido
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
            gbxDatosPedido = new GroupBox();
            cboEmpleado = new ComboBox();
            cboCliente = new ComboBox();
            cboMesa = new ComboBox();
            lblEmpleado = new Label();
            lblCliente = new Label();
            lblMesa = new Label();
            dgvProductosDisponibles = new DataGridView();
            btnAgregar = new Button();
            dgvDetallePedido = new DataGridView();
            lblTotal = new Label();
            gbxAcciones = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            gbxDatosPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).BeginInit();
            gbxAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosPedido
            // 
            gbxDatosPedido.Controls.Add(cboEmpleado);
            gbxDatosPedido.Controls.Add(cboCliente);
            gbxDatosPedido.Controls.Add(cboMesa);
            gbxDatosPedido.Controls.Add(lblEmpleado);
            gbxDatosPedido.Controls.Add(lblCliente);
            gbxDatosPedido.Controls.Add(lblMesa);
            gbxDatosPedido.Location = new Point(12, 12);
            gbxDatosPedido.Name = "gbxDatosPedido";
            gbxDatosPedido.Size = new Size(420, 268);
            gbxDatosPedido.TabIndex = 0;
            gbxDatosPedido.TabStop = false;
            gbxDatosPedido.Text = "Datos del Pedido";
            // 
            // cboEmpleado
            // 
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(162, 151);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(151, 28);
            cboEmpleado.TabIndex = 5;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(162, 91);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(151, 28);
            cboCliente.TabIndex = 4;
            // 
            // cboMesa
            // 
            cboMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMesa.FormattingEnabled = true;
            cboMesa.Location = new Point(162, 32);
            cboMesa.Name = "cboMesa";
            cboMesa.Size = new Size(151, 28);
            cboMesa.TabIndex = 3;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleado.Location = new Point(8, 151);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(97, 20);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(8, 91);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(74, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesa.Location = new Point(8, 33);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(60, 20);
            lblMesa.TabIndex = 0;
            lblMesa.Text = "Mesa:";
            // 
            // dgvProductosDisponibles
            // 
            dgvProductosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosDisponibles.Location = new Point(12, 308);
            dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            dgvProductosDisponibles.RowHeadersWidth = 51;
            dgvProductosDisponibles.Size = new Size(495, 247);
            dgvProductosDisponibles.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 596);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(240, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar al Pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Location = new Point(591, 27);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.Size = new Size(616, 210);
            dgvDetallePedido.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(651, 274);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(121, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: C$0.00";
            // 
            // gbxAcciones
            // 
            gbxAcciones.Controls.Add(btnSalir);
            gbxAcciones.Controls.Add(btnLimpiar);
            gbxAcciones.Controls.Add(btnGuardar);
            gbxAcciones.Location = new Point(644, 355);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Size = new Size(428, 270);
            gbxAcciones.TabIndex = 5;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(10, 171);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(106, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(10, 100);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(106, 29);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(10, 39);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1282, 696);
            Controls.Add(gbxAcciones);
            Controls.Add(lblTotal);
            Controls.Add(dgvDetallePedido);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductosDisponibles);
            Controls.Add(gbxDatosPedido);
            Name = "FrmPedido";
            Text = "FrmPedido";
            gbxDatosPedido.ResumeLayout(false);
            gbxDatosPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).EndInit();
            gbxAcciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosPedido;
        private ComboBox cboMesa;
        private Label lblEmpleado;
        private Label lblCliente;
        private Label lblMesa;
        private ComboBox cboEmpleado;
        private ComboBox cboCliente;
        private DataGridView dgvProductosDisponibles;
        private Button btnAgregar;
        private DataGridView dgvDetallePedido;
        private Label lblTotal;
        private GroupBox gbxAcciones;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnGuardar;
    }
}