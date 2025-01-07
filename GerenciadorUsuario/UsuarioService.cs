using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorUsuario
{
    public class UsuarioService
    {
        private readonly List<Usuario> _usuarios;

        public UsuarioService()
        {
            
            _usuarios = new List<Usuario>();
        }

        public IEnumerable<Usuario> ObterUsuarios()
        {
            return _usuarios;
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            return _usuarios.Find(u => u.Id == id);
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            var usuarioExistente = ObterUsuarioPorId(usuario.Id);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Senha = usuario.Senha;
                usuarioExistente.Status = usuario.Status;
            }
        }

        public void ExcluirUsuario(int id)
        {
            var usuario = ObterUsuarioPorId(id);
            if (usuario != null)
            {
                _usuarios.Remove(usuario);
            }
        }

        public bool ValidarCredenciais(string nome, string senha)
        {
            
            return _usuarios.Exists(u => u.Nome == nome && u.Senha == senha);
        }
    }
}
    