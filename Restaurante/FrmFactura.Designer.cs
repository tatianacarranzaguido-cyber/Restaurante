namespace Restaurante
{
    partial class FrmFactura
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
            gbxDatosFactura = new GroupBox();
            lblTotalPagar = new Label();
            cboEmpleado = new ComboBox();
            cboFormaPago = new ComboBox();
            txtIVA = new TextBox();
            dtpFecha = new DateTimePicker();
            cboPedido = new ComboBox();
            lblTotalAPagar = new Label();
            lblEmpleado = new Label();
            lblFormaPago = new Label();
            lblIva = new Label();
            lblFecha = new Label();
            lblPedido = new Label();
            gbxAcciones = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnGuardar = new Button();
            dgvFactura = new DataGridView();
            gbxDatosFactura.SuspendLayout();
            gbxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // gbxDatosFactura
            // 
            gbxDatosFactura.Controls.Add(lblTotalPagar);
            gbxDatosFactura.Controls.Add(cboEmpleado);
            gbxDatosFactura.Controls.Add(cboFormaPago);
            gbxDatosFactura.Controls.Add(txtIVA);
            gbxDatosFactura.Controls.Add(dtpFecha);
            gbxDatosFactura.Controls.Add(cboPedido);
            gbxDatosFactura.Controls.Add(lblTotalAPagar);
            gbxDatosFactura.Controls.Add(lblEmpleado);
            gbxDatosFactura.Controls.Add(lblFormaPago);
            gbxDatosFactura.Controls.Add(lblIva);
            gbxDatosFactura.Controls.Add(lblFecha);
            gbxDatosFactura.Controls.Add(lblPedido);
            gbxDatosFactura.Location = new Point(12, 12);
            gbxDatosFactura.Name = "gbxDatosFactura";
            gbxDatosFactura.Size = new Size(466, 341);
            gbxDatosFactura.TabIndex = 0;
            gbxDatosFactura.TabStop = false;
            gbxDatosFactura.Text = "Datos de la Factura";
            gbxDatosFactura.Enter += gbxDatosFactura_Enter;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.BackColor = SystemColors.ActiveBorder;
            lblTotalPagar.Location = new Point(225, 298);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(144, 25);
            lblTotalPagar.TabIndex = 11;
            lblTotalPagar.Text = "C$ 0.00";
            // 
            // cboEmpleado
            // 
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(218, 241);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(151, 28);
            cboEmpleado.TabIndex = 10;
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(218, 184);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(151, 28);
            cboFormaPago.TabIndex = 9;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(218, 134);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(125, 27);
            txtIVA.TabIndex = 8;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(172, 83);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(279, 27);
            dtpFecha.TabIndex = 7;
            // 
            // cboPedido
            // 
            cboPedido.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPedido.FormattingEnabled = true;
            cboPedido.Location = new Point(218, 35);
            cboPedido.Name = "cboPedido";
            cboPedido.Size = new Size(151, 28);
            cboPedido.TabIndex = 6;
            // 
            // lblTotalAPagar
            // 
            lblTotalAPagar.AutoSize = true;
            lblTotalAPagar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAPagar.Location = new Point(11, 294);
            lblTotalAPagar.Name = "lblTotalAPagar";
            lblTotalAPagar.Size = new Size(128, 20);
            lblTotalAPagar.TabIndex = 5;
            lblTotalAPagar.Text = "Total a Pagar:";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleado.Location = new Point(11, 241);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(97, 20);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "Empleado:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPago.Location = new Point(11, 184);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(142, 20);
            lblFormaPago.TabIndex = 3;
            lblFormaPago.Text = "Forma de Pago:";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIva.Location = new Point(11, 134);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(80, 20);
            lblIva.TabIndex = 2;
            lblIva.Text = "IVA (%):";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(11, 83);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedido.Location = new Point(11, 34);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(72, 20);
            lblPedido.TabIndex = 0;
            lblPedido.Text = "Pedido:";
            // 
            // gbxAcciones
            // 
            gbxAcciones.Controls.Add(btnSalir);
            gbxAcciones.Controls.Add(btnLimpiar);
            gbxAcciones.Controls.Add(btnMostrar);
            gbxAcciones.Controls.Add(btnGuardar);
            gbxAcciones.Location = new Point(12, 408);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Size = new Size(466, 260);
            gbxAcciones.TabIndex = 1;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(11, 202);
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
            btnLimpiar.Location = new Point(11, 146);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(11, 92);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(105, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(11, 39);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(536, 31);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(631, 250);
            dgvFactura.TabIndex = 2;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1229, 680);
            Controls.Add(dgvFactura);
            Controls.Add(gbxAcciones);
            Controls.Add(gbxDatosFactura);
            Name = "FrmFactura";
            Text = "FrmFactura";
            gbxDatosFactura.ResumeLayout(false);
            gbxDatosFactura.PerformLayout();
            gbxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatosFactura;
        private Label lblTotalAPagar;
        private Label lblEmpleado;
        private Label lblFormaPago;
        private Label lblIva;
        private Label lblFecha;
        private Label lblPedido;
        private TextBox txtIVA;
        private DateTimePicker dtpFecha;
        private ComboBox cboPedido;
        private Label lblTotalPagar;
        private ComboBox cboEmpleado;
        private ComboBox cboFormaPago;
        private GroupBox gbxAcciones;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnGuardar;
        private DataGridView dgvFactura;
    }
}