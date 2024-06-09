using Desafio2Boher.Entities;
using Desafio2Boher.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestionBussines
{
    public class UsuarioService
    {
        private GestorBDDUsuario gestorUsuario;

        public UsuarioService()
        {
            gestorUsuario = new GestorBDDUsuario();
        }

        public bool CreateUser(Usuario usuario)
        {
            return gestorUsuario.CreateUser(usuario);
        }

        public Usuario GetUserById(int id)
        {
            return gestorUsuario.GetUserById(id);
        }

        public bool UpdateUser(int id, Usuario usuario)
        {
            return gestorUsuario.UpdateUser(id, usuario);
        }

        public bool DeleteUser(int id)
        {
            return gestorUsuario.DeleteUser(id);
        }

        public List<Usuario> ListaDeUsuarios()
        {
            return gestorUsuario.ListaDeUsuarios();
        }
    }
}