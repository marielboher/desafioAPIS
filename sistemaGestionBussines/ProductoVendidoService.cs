using Desafio2Boher.Database;
using Desafio2Boher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestionBussines
{
    public class ProductoVendidoService
    {
        private GestorBDDProductoVendido gestorProductoVendido;

        public ProductoVendidoService()
        {
            gestorProductoVendido = new GestorBDDProductoVendido();
        }

        public bool CreateProductoVendido(ProductoVendido productoVendido)
        {
            return gestorProductoVendido.CreateProductoVendido(productoVendido);
        }

        public ProductoVendido GetProductoVendidoById(int id)
        {
            return gestorProductoVendido.GetProductoVendidoById(id);
        }

        public bool UpdateProductoVendido(int id, ProductoVendido productoVendido)
        {
            return gestorProductoVendido.UpdateProductoVendido(id, productoVendido);
        }

        public bool DeleteProductoVendido(int id)
        {
            return gestorProductoVendido.DeleteProductoVendido(id);
        }

        public List<ProductoVendido> ListaDeProductosVendidos()
        {
            return gestorProductoVendido.ListaDeProductosVendidos();
        }
    }
}
