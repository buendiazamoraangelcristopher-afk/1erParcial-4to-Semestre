using System;

public class Program
{
    public static void Main()
    {
        Random rd = new Random();
        int one1, two2, tree3;
        string input;

        while (true)
        {
            Console.WriteLine("=== GENERADOR DE SUMA 100 ===");
            Console.WriteLine("Ingresa un número positivo para comenzar (o '0' para salir):");
            input = Console.ReadLine();

            int valorEntrada;

            if (!int.TryParse(input, out valorEntrada) || valorEntrada < 0)
            {
                Console.WriteLine("!!! pon un valor permitido !!!\n");
                continue;
            }

            if (valorEntrada == 0) break;


            one1 = rd.Next(1, 98);
            two2 = rd.Next(1, 100 - n1);
            tree3 = 100 - (n1 + n2);


            Console.WriteLine($"\nNúmero 1: {one1}");
            for (int i = 0; i < one1; i++)
            {
                Console.Write("💠");
            }


            Console.WriteLine($"\n\nNúmero 2: {two2}");
            int j = 0;
            while (j < two2)
            {
                Console.Write("🔥");
                j++;
            }


            Console.WriteLine($"\n\nNúmero 3: {tree3}");
            int j = 0;
            do
            {
                Console.Write("⚡");
                j++;
            } while (j < n3);

            Console.WriteLine("\n\n-----------------------");
            Console.WriteLine($"RESULTADO: {one1} + {two2} + {tree3} = {one1 + two2 + tree3}");
            Console.WriteLine("--------------------------\n");
        }
    }
}
