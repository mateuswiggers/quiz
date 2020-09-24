using System;

namespace Quiz

{
    class Program
    {
        public static string Questão1;
        public static string Questão2;
        public static string Questão3;
        public static string Questão4;
        public static string Questão5;

        static void Main(string[] args)
        {
            Questões();
            Console.Read();

        }
        public static void Questões()
        {
            // Questão 1

            Console.WriteLine("Como se chama o esporte que Ayrton Senna competia?");
            Questão1 = Console.ReadLine();
            if (Questão1 == "fórmula 1")
            {
                Console.WriteLine("Você Acertou");

            }
            else
            {
                Console.WriteLine("Você errou, a resposta correta era Fórmula 1");
            }
            // Questão 2
            Console.WriteLine("Quantas vezes Senna foi campeão do mundo?");
            Questão2 = Console.ReadLine();
                if (Questão2 == "3 vezes")
            {
                Console.WriteLine("Você Acertou");
            }
            else
            {
                Console.WriteLine("Você errou, a resposta correta era 3 vezes");
            }
            // Questão 3
            Console.WriteLine("Em que ano foi a primeira corrida oficial de Fórmula 1?");
            Questão3 = Console.ReadLine();
            if (Questão3 == "1950")

            {
                Console.WriteLine("Você acertou");
            }
            else
            {
                Console.WriteLine("Você errou, a resposta correta era 1950");
            }
            // Questão 4
            Console.WriteLine("Qual a equipe mais vitoriosa da Fórmula 1?");
            Questão4 = Console.ReadLine();
            if (Questão4 == "ferrari")
            {
                Console.WriteLine("Você acertou");
            }
            else
            {
                Console.WriteLine("Você errou, a resposta correta era ferrari");
            }
            // Questão 5
            Console.WriteLine("Onde se localiza o Autódromo de Interlagos?");
            Questão5 = Console.ReadLine();
            if (Questão5 == "São Paulo")
            {
                Console.WriteLine("Você acertou");
            }
            else
            {
                Console.WriteLine("Você errou, a resposta correta era São Paulo");
            }
        }
    }
}