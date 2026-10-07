namespace Restaurante
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnProducto = new Button();
            btnMesas = new Button();
            btnEmpleados = new Button();
            btnPago = new Button();
            btnReservaciones = new Button();
            btnPedido = new Button();
            btnFactura = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(19, 28);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(126, 29);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProducto
            // 
            btnProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducto.Location = new Point(19, 105);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(126, 29);
            btnProducto.TabIndex = 1;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnMesas
            // 
            btnMesas.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMesas.Location = new Point(19, 187);
            btnMesas.Name = "btnMesas";
            btnMesas.Size = new Size(126, 29);
            btnMesas.TabIndex = 2;
            btnMesas.Text = "Mesas";
            btnMesas.UseVisualStyleBackColor = true;
            btnMesas.Click += btnMesas_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.Location = new Point(19, 276);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(126, 29);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnPago
            // 
            btnPago.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPago.Location = new Point(305, 28);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(160, 29);
            btnPago.TabIndex = 4;
            btnPago.Text = "Forma de Pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // btnReservaciones
            // 
            btnReservaciones.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservaciones.Location = new Point(305, 105);
            btnReservaciones.Name = "btnReservaciones";
            btnReservaciones.Size = new Size(160, 29);
            btnReservaciones.TabIndex = 5;
            btnReservaciones.Text = "Reservaciones";
            btnReservaciones.UseVisualStyleBackColor = true;
            btnReservaciones.Click += btnReservaciones_Click;
            // 
            // btnPedido
            // 
            btnPedido.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPedido.Location = new Point(305, 187);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(160, 29);
            btnPedido.TabIndex = 6;
            btnPedido.Text = "Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnFactura
            // 
            btnFactura.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFactura.Location = new Point(305, 276);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(160, 29);
            btnFactura.TabIndex = 7;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnFactura);
            Controls.Add(btnPedido);
            Controls.Add(btnReservaciones);
            Controls.Add(btnPago);
            Controls.Add(btnEmpleados);
            Controls.Add(btnMesas);
            Controls.Add(btnProducto);
            Controls.Add(btnClientes);
            Name = "FrmMenuPrincipal";
            Text = "Restaurante Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProducto;
        private Button btnMesas;
        private Button btnEmpleados;
        private Button btnPago;
        private Button btnReservaciones;
        private Button btnPedido;
        private Button btnFactura;
    }
}
