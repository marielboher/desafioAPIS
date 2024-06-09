using sistemaGestionBussines;
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
    public partial class FormProductosVendidos : Form
    {
        private ProductoVendidoService productoVendidoService;
        public int idProductoVendido;
        public FormProductosVendidos()
        {
            InitializeComponent();
            productoVendidoService = new ProductoVendidoService();
        }

        private void FormProductosVendidos_Load(object sender, EventArgs e)
        {
            idProductoVendido = 0;
            LoadProductosVendidos();
            dgvProductosVendidos.AutoGenerateColumns = true;
        }
        private void LoadProductosVendidos()
        {
            var productosVendidos = productoVendidoService.ListaDeProductosVendidos();
            dgvProductosVendidos.DataSource = productosVendidos;
        }

        private void dgvProductosVendidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = e.RowIndex;
                idProductoVendido = Convert.ToInt32(dgvProductosVendidos.Rows[filaSeleccionada].Cells[0].Value);

                FormCrudProdutoVendido formCrudProductoVendido = new FormCrudProdutoVendido(idProductoVendido);
                formCrudProductoVendido.FormClosed += (s, args) => LoadProductosVendidos();
                this.Hide();
                formCrudProductoVendido.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCrudProdutoVendido formCrudProductoVendido = new FormCrudProdutoVendido(0);
            formCrudProductoVendido.FormClosed += (s, args) => LoadProductosVendidos();
            this.Hide();
            formCrudProductoVendido.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProductosVendidos();

        }
    }
}
