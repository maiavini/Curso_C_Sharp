using System;


namespace ByteBank_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaInterno sistema = new SistemaInterno();

            FuncionarioAutenticavel vinicius = new Diretor("12991329793");
            vinicius.Nome = "Vinicius Maia";
            vinicius.Senha = "123";

            SistemaInterno.Logar(vinicius, "123");


            
            


        }
    }
}
