using Desafio2Boher.Database;
using Desafio2Boher.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaGestion
{
    public partial class FormCrudProductos : Form
    {
        private int idProducto;

        public FormCrudProductos(int idProducto)
        {
            InitializeComponent();
            this.idProducto = idProducto;
        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtDescripciones.Text = "";
            txtCosto.Text = "";
            txtStock.Text = "";
            txtPrecioVenta.Text = "";
            txtIdUsuario.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formProductos.Show();
        }

        private void FormCrudProductos_Load(object sender, EventArgs e)
        {
            if (idProducto > 0)
            {
                GestorBDDProducto gestorBDDProducto = new GestorBDDProducto();
                Producto producto = gestorBDDProducto.GetProductoById(idProducto);

                if (producto != null)
                {
                    txtId.Text = producto.Id.ToString();
                    txtDescripciones.Text = producto.Descripciones;
                    txtCosto.Text = producto.Costo.ToString();
                    txtStock.Text = producto.Stock.ToString();
                    txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                    txtIdUsuario.Text = producto.IdUsuario.ToString();
                }
            }
            else
            {
                Limpiar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripciones = txtDescripciones.Text;
            decimal costo;
            int stock;
            decimal precioVenta;
            int idUsuario;

            if (string.IsNullOrEmpty(txtDescripciones.Text) || !decimal.TryParse(txtCosto.Text, out costo) || !int.TryParse(txtStock.Text, out stock) || !decimal.TryParse(txtPrecioVenta.Text, out precioVenta) || !int.TryParse(txtIdUsuario.Text, out idUsuario))
            {
                MessageBox.Show("Por favor ingrese valores válidos.");
                return;
            }

            Producto nuevoProducto = new Producto(idProducto, descripciones, costo, stock, precioVenta, idUsuario);
            GestorBDDProducto gestorBDDProducto = new GestorBDDProducto();

            if (idProducto > 0)
            {
                gestorBDDProducto.UpdateProducto(idProducto, nuevoProducto);
                MessageBox.Show("Se actualizó el producto");
            }
            else
            {
                gestorBDDProducto.CreateProducto(nuevoProducto);
                MessageBox.Show("Se creó el producto");
            }

            Limpiar();
            this.Close();
            Program.formProductos.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorBDDProducto gestorBDDProducto = new GestorBDDProducto();
            gestorBDDProducto.DeleteProducto(idProducto);
            MessageBox.Show("Se eliminó el producto");
            Limpiar();
            this.Close();
            Program.formProductos.Show();
        }
    }
}
