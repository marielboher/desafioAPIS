using Desafio2Boher.Database;
using Desafio2Boher.Entities;
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
    public partial class FormUsuarios : Form
    {
        private UsuarioService usuarioService;
        public int idUsuario;

        public FormUsuarios()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            idUsuario = 0;
            LoadUsuarios();
            dgvUsuarios.AutoGenerateColumns = true;
        }

        private void LoadUsuarios()
        {
            var usuarios = usuarioService.ListaDeUsuarios();
            dgvUsuarios.DataSource = usuarios;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                idUsuario = Convert.ToInt32(dgvUsuarios.Rows[filaSeleccionada].Cells[0].Value);
            }
            FormCrudUsuarios formCrudUsuarios = new FormCrudUsuarios();
            this.Hide();
            formCrudUsuarios.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCrudUsuarios formCrudUsuarios = new FormCrudUsuarios();
            this.Hide();
            formCrudUsuarios.Show();
        }

        private void FormUsuarios_Load_1(object sender, EventArgs e)
        {
            LoadUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Refresh();
            LoadUsuarios();
        }
    }
}
