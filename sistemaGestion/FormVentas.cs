using sistemaGestionBussines;
using Desafio2Boher.Entities;
using System;
using System.Windows.Forms;

namespace sistemaGestion
{
    public partial class FormVentas : Form
    {
        private VentaService ventaService;
        public int idVenta;

        public FormVentas()
        {
            InitializeComponent();
            ventaService = new VentaService();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            idVenta = 0;
            LoadVentas();
            dgvVentas.AutoGenerateColumns = true;
        }

        private void LoadVentas()
        {
            var ventas = ventaService.ListaDeVentas();
            dgvVentas.DataSource = ventas;
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = e.RowIndex;
                idVenta = Convert.ToInt32(dgvVentas.Rows[filaSeleccionada].Cells[0].Value);

                FormCrudVentas formCrudVentas = new FormCrudVentas(idVenta);
                this.Hide();
                formCrudVentas.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCrudVentas formCrudVentas = new FormCrudVentas(0);
            this.Hide();
            formCrudVentas.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadVentas();
        }
    }
}