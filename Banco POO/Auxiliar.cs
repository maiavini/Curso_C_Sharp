using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank_Herança
{
    public class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.2;
        }













    }


  

}
