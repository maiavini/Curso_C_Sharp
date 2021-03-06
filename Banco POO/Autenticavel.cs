using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank_Herança
{
    public interface IAutenticavel 
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
           return Senha == senha;
        }


    }
}
