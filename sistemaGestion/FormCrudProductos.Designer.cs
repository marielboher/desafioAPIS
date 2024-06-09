namespace sistemaGestion
{
    partial class FormCrudProductos
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
            txtDescripciones = new TextBox();
            txtIdUsuario = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            txtCosto = new TextBox();
            txtId = new TextBox();
            lblIdUsuario = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblCosto = new Label();
            lblDescripciones = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(36, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 29;
            lblId.Text = "ID";
            // 
            // txtDescripciones
            // 
            txtDescripciones.Location = new Point(141, 53);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(100, 23);
            txtDescripciones.TabIndex = 28;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(141, 236);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 27;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(141, 187);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 26;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(141, 142);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 25;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(141, 95);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 24;
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 14);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 23;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.Location = new Point(32, 236);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(60, 15);
            lblIdUsuario.TabIndex = 22;
            lblIdUsuario.Text = "Id Usuario";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(32, 195);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 21;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(36, 145);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 20;
            lblStock.Text = "Stock";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(32, 98);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(38, 15);
            lblCosto.TabIndex = 19;
            lblCosto.Text = "Costo";
            // 
            // lblDescripciones
            // 
            lblDescripciones.AutoSize = true;
            lblDescripciones.Location = new Point(32, 56);
            lblDescripciones.Name = "lblDescripciones";
            lblDescripciones.Size = new Size(80, 15);
            lblDescripciones.TabIndex = 18;
            lblDescripciones.Text = "Descripciones";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(198, 342);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(108, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 342);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormCrudProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 378);
            Controls.Add(lblId);
            Controls.Add(txtDescripciones);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtStock);
            Controls.Add(txtCosto);
            Controls.Add(txtId);
            Controls.Add(lblIdUsuario);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblCosto);
            Controls.Add(lblDescripciones);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Name = "FormCrudProductos";
            Text = "FormCrudProductos";
            Load += FormCrudProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtDescripciones;
        private TextBox txtIdUsuario;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtCosto;
        private TextBox txtId;
        private Label lblIdUsuario;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblCosto;
        private Label lblDescripciones;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}