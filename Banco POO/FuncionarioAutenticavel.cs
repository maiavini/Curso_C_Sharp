using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank_Herança
{
    class FuncionarioAutenticavel : Funcionario, IAutenticavel // Está é uma classe que é filha de Funcionario 
    {                                                          // com contrato com a interface
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public FuncionarioAutenticavel (string cpf, double salario) : base(cpf, salario)
        {

        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }
    }
}
