namespace Restaurante
{
    partial class FrmMesas
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
            gbxDatoMesas = new GroupBox();
            txtEstado = new TextBox();
            txtCapacidad = new TextBox();
            txtNumero = new TextBox();
            lblEstado = new Label();
            lblCapacidad = new Label();
            lblNumero = new Label();
            gbxAcciones = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnGuardar = new Button();
            dgvMesas = new DataGridView();
            gbxDatoMesas.SuspendLayout();
            gbxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMesas).BeginInit();
            SuspendLayout();
            // 
            // gbxDatoMesas
            // 
            gbxDatoMesas.Controls.Add(txtEstado);
            gbxDatoMesas.Controls.Add(txtCapacidad);
            gbxDatoMesas.Controls.Add(txtNumero);
            gbxDatoMesas.Controls.Add(lblEstado);
            gbxDatoMesas.Controls.Add(lblCapacidad);
            gbxDatoMesas.Controls.Add(lblNumero);
            gbxDatoMesas.Location = new Point(12, 22);
            gbxDatoMesas.Name = "gbxDatoMesas";
            gbxDatoMesas.Size = new Size(390, 241);
            gbxDatoMesas.TabIndex = 0;
            gbxDatoMesas.TabStop = false;
            gbxDatoMesas.Text = "Datos de la Mesa";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(184, 162);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 5;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(184, 96);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(125, 27);
            txtCapacidad.TabIndex = 4;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(184, 36);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(11, 169);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(73, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidad.Location = new Point(11, 103);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(103, 20);
            lblCapacidad.TabIndex = 1;
            lblCapacidad.Text = "Capacidad:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(11, 36);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(80, 20);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // gbxAcciones
            // 
            gbxAcciones.Controls.Add(btnSalir);
            gbxAcciones.Controls.Add(btnLimpiar);
            gbxAcciones.Controls.Add(btnMostrar);
            gbxAcciones.Controls.Add(btnGuardar);
            gbxAcciones.Location = new Point(12, 329);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Size = new Size(390, 260);
            gbxAcciones.TabIndex = 1;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(19, 213);
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
            btnLimpiar.Location = new Point(19, 156);
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
            btnMostrar.Location = new Point(19, 96);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(104, 29);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(19, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvMesas
            // 
            dgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesas.Location = new Point(549, 40);
            dgvMesas.Name = "dgvMesas";
            dgvMesas.RowHeadersWidth = 51;
            dgvMesas.Size = new Size(541, 244);
            dgvMesas.TabIndex = 2;
            // 
            // FrmMesas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1102, 601);
            Controls.Add(dgvMesas);
            Controls.Add(gbxAcciones);
            Controls.Add(gbxDatoMesas);
            Name = "FrmMesas";
            Text = "FrmMesas";
            gbxDatoMesas.ResumeLayout(false);
            gbxDatoMesas.PerformLayout();
            gbxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMesas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatoMesas;
        private TextBox txtEstado;
        private TextBox txtCapacidad;
        private TextBox txtNumero;
        private Label lblEstado;
        private Label lblCapacidad;
        private Label lblNumero;
        private GroupBox gbxAcciones;
        private Button btnGuardar;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
        private DataGridView dgvMesas;
    }
}