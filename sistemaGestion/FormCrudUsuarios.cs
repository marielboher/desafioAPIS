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
    public partial class FormCrudUsuarios : Form
    {
        public FormCrudUsuarios()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtMail.Text = "";
            txtId.Text = "";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formUsuarios.idUsuario = 0;
            Program.formUsuarios.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCrudUsuarios_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.formUsuarios.idUsuario;
            if (idUsuario > 0)
            {
                GestorBDDUsuario gestorBDDUsuario = new GestorBDDUsuario();
                Usuario usuario = gestorBDDUsuario.GetUserById(idUsuario);

                if (usuario != null)
                {
                    txtNombre.Text = usuario.Nombre;
                    txtApellido.Text = usuario.Apellido;
                    txtUsuario.Text = usuario.NombreUsuario;
                    txtPass.Text = usuario.Password;
                    txtMail.Text = usuario.Email;
                    txtId.Text = usuario.Id.ToString();
                }
            }
            else
            {
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            GestorBDDUsuario gestorBDDUsuario = new GestorBDDUsuario();
            gestorBDDUsuario.DeleteUser(int.Parse(id));
            MessageBox.Show("Se borro el usuario");
            Limpiar();
            this.Close();
            Program.formUsuarios.idUsuario = 0;
            Program.formUsuarios.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;
            string mail = txtMail.Text;

           int idUsuario = Program.formUsuarios.idUsuario;

           Usuario newUser = new Usuario(nombre, apellido, usuario, pass, mail);

            GestorBDDUsuario gestorBDDUsuario = new GestorBDDUsuario();

            if(idUsuario > 0)
            {
                gestorBDDUsuario.UpdateUser(idUsuario, newUser);
                MessageBox.Show("se actualizo el usuario");
            }
            else
            {
                gestorBDDUsuario.CreateUser(newUser);
                MessageBox.Show("se creo el usuario");
            }

            Limpiar();
            this.Close();
            Program.formUsuarios.idUsuario = 0;
            Program.formUsuarios.Show();

        }
    }
}