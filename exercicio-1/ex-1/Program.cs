using System;
using Course;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Person person1, person2;
            person1 = new Person();
            person2 = new Person();
            Console.WriteLine("Digite o nome da primeira pessoa e em seguida a idade dela: ");
            person1.Nome = Console.ReadLine();
            person1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa e em seguida a idade dela: ");
            person2.Nome = Console.ReadLine();
            person2.Idade = int.Parse(Console.ReadLine());

            if (person1.Idade > person2.Idade)
            {
                Console.WriteLine($"{person1.Nome} é mais velho(a)");
            } else {
                Console.WriteLine($"{person2.Nome} é mais velho(a)");
            }
        }
    }
}