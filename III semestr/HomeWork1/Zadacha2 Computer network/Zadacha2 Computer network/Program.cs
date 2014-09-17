using System;

namespace Zadacha2_Computer_network
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of computers:");
            string input = Console.ReadLine();
            int number = 0;
            int.TryParse(input, out number);
            Console.WriteLine("Input OS of computers:");
            Console.WriteLine("(0 - Windows, 1 - Linux, 2 - Mac OS, 3 - Google Chromium OS)");
            input = Console.ReadLine();
            string[] stringOS = input.Split(' ');
            int[] arrayOfOS = new int[number];
            for (int i = 0; i < number; i++)
            {
                int.TryParse(stringOS[i], out arrayOfOS[i]);
            }
            Console.WriteLine("Input connectivity matrix " + number + "x" + number + ":");
            int[,] matrix = new int[number, number];
            for (int i = 0; i < number; i++)
            {
                input = Console.ReadLine();
                string[] stringMatrix = input.Split(' ');
                for (int j = 0; j < number; j++)
                {
                    int.TryParse(stringMatrix[j], out matrix[i, j]);
                }
            }
            bool[] dirtyComputers = new bool[number];
            Console.WriteLine("Input numbers of dirty computers:");
            input = Console.ReadLine();
            string[] stringDirty = input.Split(' ');
            int virusNumber = stringDirty.Length;
            int[] arrayOfVirus = new int[number];//
            for (int i = 0; i < virusNumber; i++)
            {
                int index = 0;
                int.TryParse(stringDirty[i], out index);
                dirtyComputers[index - 1] = true;
                arrayOfVirus[i] = index - 1;
            }
            Virus virus = new Virus(virusNumber, arrayOfVirus);
            Network network = new Network(number, matrix, dirtyComputers, virusNumber);
            OS os = new OS(number, arrayOfOS);
            network.PrintNetwork(virus, os);
        }
    }
}
