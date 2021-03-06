using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank_Herança
{
    public abstract class Funcionario // abstract pq está na classe mãe e evita o instanciamento.
    {
        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public double Salario { get; protected set; }
        
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(long cpf)
        {
            TotalFuncionarios++;
        }

        public Funcionario (string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
        }


        public abstract double GetBonificacao(); // aqui tinha o virtual, que indicava que era um método da classe mãe.
        

        public abstract void AumentarSalario(); // abstract pq agora é usado somente como base +
                                                // já que cada funcionário tem sua lógica para aumentar o salário.

   







    }


}
