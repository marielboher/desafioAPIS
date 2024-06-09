namespace sistemaGestion
{
    partial class FormCrudProdutoVendido
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
            lblId = new Label();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            txtIdVenta = new TextBox();
            txtId = new TextBox();
            lblIdProducto = new Label();
            lblIdVenta = new Label();
            lblStock = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 29;
            lblId.Text = "ID";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(128, 89);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 28;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(128, 178);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 25;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(128, 131);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 24;
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 50);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 23;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(19, 181);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(69, 15);
            lblIdProducto.TabIndex = 20;
            lblIdProducto.Text = "Id Producto";
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(19, 134);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(49, 15);
            lblIdVenta.TabIndex = 19;
            lblIdVenta.Text = "Id Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(19, 92);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 18;
            lblStock.Text = "Stock";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(185, 326);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(93, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 326);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // FormCrudProdutoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 450);
            Controls.Add(lblId);
            Controls.Add(txtStock);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdVenta);
            Controls.Add(txtId);
            Controls.Add(lblIdProducto);
            Controls.Add(lblIdVenta);
            Controls.Add(lblStock);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Name = "FormCrudProdutoVendido";
            Text = "FormCrudProdutoVendido";
            Load += FormCrudProdutoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private TextBox txtIdVenta;
        private TextBox txtId;
        private Label lblIdProducto;
        private Label lblIdVenta;
        private Label lblStock;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}