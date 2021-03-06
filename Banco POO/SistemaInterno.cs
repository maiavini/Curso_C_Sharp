using System;
using System.Collections.Generic;
using System.Text;


namespace ByteBank_Herança
{
    public class SistemaInterno : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Logar(IAutenticavel funcionario, string senha) // Aqui os parametros são um funcionario que tenha 
                                                                   // assinaddo com a Interface IAutenticavel
        {

            bool ususarioAutenticado = funcionario.Autenticar(senha);

            if(ususarioAutenticado)
            {
                Console.WriteLine("Bem Vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta.");
                return false;
                
            }
        }
    }
}
