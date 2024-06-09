using Desafio2Boher.Database;
using Desafio2Boher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestionBussines
{
    public class ProductoService
    {
        private GestorBDDProducto gestorProducto;

        public ProductoService()
        {
            gestorProducto = new GestorBDDProducto();
        }

        public bool CreateProducto(Producto producto)
        {
            return gestorProducto.CreateProducto(producto);
        }

        public Producto GetProductoById(int id)
        {
            return gestorProducto.GetProductoById(id);
        }

        public bool UpdateProducto(int id, Producto producto)
        {
            return gestorProducto.UpdateProducto(id, producto);
        }

        public bool DeleteProducto(int id)
        {
            return gestorProducto.DeleteProducto(id);
        }

        public List<Producto> ListaDeProductos()
        {
            return gestorProducto.ListaDeProductos();
        }
    }
}
