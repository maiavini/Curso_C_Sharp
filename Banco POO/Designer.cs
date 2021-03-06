using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank_Herança
{
    class Designer : Funcionario
    {

        public  Designer  (string cpf) : base(cpf, 3000)
        {
            CPF = cpf;
            
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
