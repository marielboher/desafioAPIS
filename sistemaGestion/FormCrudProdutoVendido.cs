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
    public partial class FormCrudProdutoVendido : Form
    {
        private int idProductoVendido;

        public FormCrudProdutoVendido(int idProductoVendido)
        {
            InitializeComponent();
            this.idProductoVendido = idProductoVendido;
        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtStock.Text = "";
            txtIdProducto.Text = "";
            txtIdVenta.Text = "";
        }

        private void FormCrudProdutoVendido_Load(object sender, EventArgs e)
        {
            if (idProductoVendido > 0)
            {
                GestorBDDProductoVendido gestorBDDProductoVendido = new GestorBDDProductoVendido();
                ProductoVendido productoVendido = gestorBDDProductoVendido.GetProductoVendidoById(idProductoVendido);

                if (productoVendido != null)
                {
                    txtId.Text = productoVendido.Id.ToString();
                    txtStock.Text = productoVendido.Stock.ToString();
                    txtIdProducto.Text = productoVendido.IdProducto.ToString();
                    txtIdVenta.Text = productoVendido.IdVenta.ToString();
                }
            }
            else
            {
                Limpiar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int stock;
            int idProducto;
            int idVenta;

            if (!int.TryParse(txtStock.Text, out stock) || !int.TryParse(txtIdProducto.Text, out idProducto) || !int.TryParse(txtIdVenta.Text, out idVenta))
            {
                MessageBox.Show("Por favor ingrese valores válidos.");
                return;
            }

            ProductoVendido nuevoProductoVendido = new ProductoVendido(idProductoVendido, stock, idProducto, idVenta);
            GestorBDDProductoVendido gestorBDDProductoVendido = new GestorBDDProductoVendido();

            if (idProductoVendido > 0)
            {
                gestorBDDProductoVendido.UpdateProductoVendido(idProductoVendido, nuevoProductoVendido);
                MessageBox.Show("Se actualizó el producto vendido");
            }
            else
            {
                gestorBDDProductoVendido.CreateProductoVendido(nuevoProductoVendido);
                MessageBox.Show("Se creó el producto vendido");
            }

            Limpiar();
            this.Close();
            Program.formProductosVendidos.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorBDDProductoVendido gestorBDDProductoVendido = new GestorBDDProductoVendido();
            gestorBDDProductoVendido.DeleteProductoVendido(idProductoVendido);
            MessageBox.Show("Se eliminó el producto vendido");
            Limpiar();
            this.Close();
            Program.formProductosVendidos.Show();
        }
    }
}
