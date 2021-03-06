using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Login

    // Tudo é static para que não seja estancinado, somente a classe Usuarios pode ser
{
    class CadastroUsuarios

    {
        private static Usuario[] usuarios = //O Certo é ter os usuarios de um BD
        {
            new Usuario(){Nome = "Gabriel", Senha = "abc123"},
            new Usuario(){Nome = "Danny", Senha = "123abc"},
            new Usuario(){Nome = "Rafael", Senha = "mnb123"}


        };

        private static Usuario _userlogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userlogado; }
            private set { _userlogado = value; }

        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }

                

            }

            return false;
        }

     







    }
}
