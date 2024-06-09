using sistemaGestionBussines;

namespace sistemaGestion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.FormClosed += (s, args) => this.Close();
            formUsuarios.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.FormClosed += (s, args) => this.Close();
            formVentas.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.FormClosed += (s, args) => this.Close();
            formProductos.Show();
            this.Hide();
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            FormProductosVendidos formProductosVendidos = new FormProductosVendidos();
            formProductosVendidos.FormClosed += (s, args) => this.Close();
            formProductosVendidos.Show();
            this.Hide();
        }
    }
}