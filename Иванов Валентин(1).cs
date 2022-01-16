using System;

namespace Arcane1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество белок");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Теперь введите количество орехов");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ:");
            Console.WriteLine(K/N);

        }
    }
}
