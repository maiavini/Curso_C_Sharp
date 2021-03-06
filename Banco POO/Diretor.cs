using System;
using System.Collections.Generic;
using System.Text;


namespace ByteBank_Herança
{
    class Diretor : FuncionarioAutenticavel

    {

        public override double GetBonificacao()
        {
            return Salario *= 0.10;
        }

        public override void AumentarSalario()
        {
             Salario *= 0.20;
        }

        public Diretor (string cpf) : base(cpf, 5000)
        {
            
        }
    
    
    
    }
}
