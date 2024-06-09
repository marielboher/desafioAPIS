using Desafio2Boher.Database;
using Desafio2Boher.Entities;
using System;
using System.Windows.Forms;

namespace sistemaGestion
{
    public partial class FormCrudVentas : Form
    {
        private int idVenta;

        public FormCrudVentas(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtComentarios.Text = "";
            txtIdUsuario.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCrudVentas_Load(object sender, EventArgs e)
        {
            if (idVenta > 0)
            {
                GestorBDDVenta gestorBDDVentas = new GestorBDDVenta();
                Venta venta = gestorBDDVentas.GetVentaById(idVenta);

                if (venta != null)
                {
                    txtId.Text = venta.Id.ToString();
                    txtComentarios.Text = venta.Comentarios;
                    txtIdUsuario.Text = venta.IdUsuario.ToString();
                }
            }
            else
            {
                Limpiar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string comentarios = txtComentarios.Text;
            int idUsuario;

            if (string.IsNullOrEmpty(txtIdUsuario.Text) || !int.TryParse(txtIdUsuario.Text, out idUsuario))
            {
                MessageBox.Show("Por favor ingrese un ID de Usuario válido.");
                return;
            }

            Venta nuevaVenta = new Venta(idVenta, comentarios, idUsuario);
            GestorBDDVenta gestorBDDVentas = new GestorBDDVenta();

            if (idVenta > 0)
            {
                gestorBDDVentas.UpdateVenta(idVenta, nuevaVenta);
                MessageBox.Show("Se actualizó la venta");
            }
            else
            {
                gestorBDDVentas.CreateVenta(nuevaVenta);
                MessageBox.Show("Se creó la venta");
            }

            Limpiar();
            this.Close();
            Program.formVentas.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorBDDVenta gestorBDDVentas = new GestorBDDVenta();
            gestorBDDVentas.DeleteVenta(idVenta);
            MessageBox.Show("Se eliminó la venta");
            Limpiar();
            this.Close();
            Program.formVentas.Show();
        }
    }
}
