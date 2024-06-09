using Desafio2Boher.Database;
using Desafio2Boher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestionBussines
{
    public class VentaService
    {
        private GestorBDDVenta gestorVenta;

        public VentaService()
        {
            gestorVenta = new GestorBDDVenta();
        }

        public bool CreateVenta(Venta venta)
        {
            return gestorVenta.CreateVenta(venta);
        }

        public Venta GetVentaById(int id)
        {
            return gestorVenta.GetVentaById(id);
        }

        public bool UpdateVenta(int id, Venta venta)
        {
            return gestorVenta.UpdateVenta(id, venta);
        }

        public bool DeleteVenta(int id)
        {
            return gestorVenta.DeleteVenta(id);
        }

        public List<Venta> ListaDeVentas()
        {
            return gestorVenta.ListaDeVentas();
        }
    }
}