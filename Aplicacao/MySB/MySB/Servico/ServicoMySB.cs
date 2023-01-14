using MySB.Repositorio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySB.Servico
{
    public class ServicoMySB
    {
        private RepositorioMySB _repositorio;
        public ServicoMySB()
        {
            string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            _repositorio = new RepositorioMySB(conn);
        }

        public bool ValidaUsuarioLogin(string pUsuario, string pSenha)
        {
            return _repositorio.ValidaLogin(pUsuario, pSenha);
        }
    }
}
