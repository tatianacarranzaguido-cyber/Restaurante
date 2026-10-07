namespace Restaurante
{
    partial class FrmProducto
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
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            gbxDatosProductos = new GroupBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            groupBox2 = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            btnGuardar = new Button();
            dgvProducto = new DataGridView();
            gbxDatosProductos.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(6, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(6, 85);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(116, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(6, 132);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(69, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(6, 179);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(96, 20);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria:";
            // 
            // gbxDatosProductos
            // 
            gbxDatosProductos.Controls.Add(txtCategoria);
            gbxDatosProductos.Controls.Add(txtPrecio);
            gbxDatosProductos.Controls.Add(txtDescripcion);
            gbxDatosProductos.Controls.Add(txtNombre);
            gbxDatosProductos.Controls.Add(lblDescripcion);
            gbxDatosProductos.Controls.Add(lblCategoria);
            gbxDatosProductos.Controls.Add(lblNombre);
            gbxDatosProductos.Controls.Add(lblPrecio);
            gbxDatosProductos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxDatosProductos.Location = new Point(12, 23);
            gbxDatosProductos.Name = "gbxDatosProductos";
            gbxDatosProductos.Size = new Size(359, 228);
            gbxDatosProductos.TabIndex = 4;
            gbxDatosProductos.TabStop = false;
            gbxDatosProductos.Text = "Datos del Producto";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(198, 179);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 27);
            txtCategoria.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(198, 132);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(198, 85);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Controls.Add(btnMostrar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 263);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(17, 208);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(17, 149);
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
            btnMostrar.Location = new Point(17, 91);
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
            btnGuardar.Location = new Point(17, 41);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(425, 41);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(541, 210);
            dgvProducto.TabIndex = 6;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(978, 565);
            Controls.Add(dgvProducto);
            Controls.Add(groupBox2);
            Controls.Add(gbxDatosProductos);
            Name = "FrmProducto";
            Text = "FrmProducto";
            gbxDatosProductos.ResumeLayout(false);
            gbxDatosProductos.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblCategoria;
        private GroupBox gbxDatosProductos;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private GroupBox groupBox2;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnGuardar;
        private Button btnSalir;
        private DataGridView dgvProducto;
    }
}