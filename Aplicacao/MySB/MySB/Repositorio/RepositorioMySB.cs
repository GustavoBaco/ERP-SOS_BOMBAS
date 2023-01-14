using MySB.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySB.Repositorio
{
    public class RepositorioMySB
    {
        private string _stringConnection;
        public RepositorioMySB(string conexao)
        {
            _stringConnection = conexao;
        }

        public bool ValidaLogin(string pUsuario, string pSenha)
        {
            using (var contexto = new ContextoMySB(_stringConnection))
            {
                var qtdUsuario = contexto.LoginEnt.Where(w => w.Usuario.Equals(pUsuario) && w.Senha.Equals(pSenha)).Select(s => s).Count();
                return qtdUsuario > 0 ? true : false;
            }
        }
    }
}
