namespace sistemaGestion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnUsuarios = new Button();
            btnVentas = new Button();
            btnProductos = new Button();
            btnProductosVendidos = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(70, 146);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(110, 65);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(218, 146);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(118, 65);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(377, 146);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(117, 65);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.Location = new Point(541, 146);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(114, 65);
            btnProductosVendidos.TabIndex = 3;
            btnProductosVendidos.Text = "Prodcuto Vendido";
            btnProductosVendidos.UseVisualStyleBackColor = true;
            btnProductosVendidos.Click += btnProductosVendidos_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(btnProductosVendidos);
            Controls.Add(btnProductos);
            Controls.Add(btnVentas);
            Controls.Add(btnUsuarios);
            Name = "Form1";
            Text = "Gestión de Sistema";
            ResumeLayout(false);
        }

        private Button btnUsuarios;
        private Button btnVentas;
        private Button btnProductos;
        private Button btnProductosVendidos;
    }
}
