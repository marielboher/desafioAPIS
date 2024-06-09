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
    public partial class FormProductos : Form
    {
        private ProductoService productoService;
        public int idProducto;

        public FormProductos()
        {
            InitializeComponent();
            productoService = new ProductoService();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            idProducto = 0;
            LoadProductos();
            dgvProductos.AutoGenerateColumns = true;
        }

        private void LoadProductos()
        {
            var productos = productoService.ListaDeProductos();
            dgvProductos.DataSource = productos;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = e.RowIndex;
                idProducto = Convert.ToInt32(dgvProductos.Rows[filaSeleccionada].Cells[0].Value);

                FormCrudProductos formCrudProducto = new FormCrudProductos(idProducto);
                formCrudProducto.FormClosed += (s, args) => LoadProductos();
                this.Hide();
                formCrudProducto.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCrudProductos formCrudProducto = new FormCrudProductos(0);
            formCrudProducto.FormClosed += (s, args) => LoadProductos();
            this.Hide();
            formCrudProducto.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadProductos();

        }
    }
}
