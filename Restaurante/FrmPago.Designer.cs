namespace Restaurante
{
    partial class FrmPago
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
            gbxDatosPago = new GroupBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            lblNombre = new Label();
            gbxAcciones = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnGuardar = new Button();
            dgvFormaPago = new DataGridView();
            gbxDatosPago.SuspendLayout();
            gbxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormaPago).BeginInit();
            SuspendLayout();
            // 
            // gbxDatosPago
            // 
            gbxDatosPago.Controls.Add(txtDescripcion);
            gbxDatosPago.Controls.Add(txtNombre);
            gbxDatosPago.Controls.Add(lblDescripcion);
            gbxDatosPago.Controls.Add(lblNombre);
            gbxDatosPago.Location = new Point(12, 12);
            gbxDatosPago.Name = "gbxDatosPago";
            gbxDatosPago.Size = new Size(297, 157);
            gbxDatosPago.TabIndex = 0;
            gbxDatosPago.TabStop = false;
            gbxDatosPago.Text = "Datos del Pago";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(153, 103);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(18, 103);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(116, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(18, 42);
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
            gbxAcciones.Location = new Point(12, 210);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Size = new Size(297, 249);
            gbxAcciones.TabIndex = 1;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(14, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(14, 146);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(14, 87);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(110, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(14, 33);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvFormaPago
            // 
            dgvFormaPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormaPago.Location = new Point(416, 24);
            dgvFormaPago.Name = "dgvFormaPago";
            dgvFormaPago.RowHeadersWidth = 51;
            dgvFormaPago.Size = new Size(542, 188);
            dgvFormaPago.TabIndex = 2;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1052, 545);
            Controls.Add(dgvFormaPago);
            Controls.Add(gbxAcciones);
            Controls.Add(gbxDatosPago);
            Name = "FrmPago";
            Text = "FrmPago";
            gbxDatosPago.ResumeLayout(false);
            gbxDatosPago.PerformLayout();
            gbxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFormaPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatosPago;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private Label lblNombre;
        private GroupBox gbxAcciones;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnGuardar;
        private DataGridView dgvFormaPago;
    }
}