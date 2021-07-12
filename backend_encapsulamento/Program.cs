using System;

namespace backend_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
          MasterCard m = new MasterCard();
            m.NomeTitular = "Giovanni iannace";
            m.Numero = "04062003";
            m.Bandeira = "Visa";

            Console.WriteLine($" o Titular {m.NomeTitular} - Tem o Token: {m.Token} - e sua bandeira é : {m.Bandeira}");
        }
    }
}
