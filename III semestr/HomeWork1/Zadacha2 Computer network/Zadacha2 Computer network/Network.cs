using System;

namespace Zadacha2_Computer_network
{
    public class Network
    {
        public Network(int number, int[,] matrix, bool[] dirty, int virusNumber)
        {
            this.numberOfComputers = number;
            this.matrix = matrix;
            this.dirtyComputers = dirty;
            this.numberOfDirtyComputers = virusNumber;
        }

        public void PrintNetwork(Virus virus, OS os)
        {
            PrintNetworkNow();
            int start = 0;
            while (numberOfComputers != numberOfDirtyComputers && virus.CanGo(numberOfComputers, matrix, dirtyComputers))
            {
                virus.Go(numberOfComputers, matrix, dirtyComputers, os, ref start);
                PrintNetworkNow();
            }
            Console.WriteLine();
        }

        private void PrintNetworkNow()
        {
            Console.WriteLine();
            for (int i = 0; i < numberOfComputers; i++)
            {
                if (dirtyComputers[i])
                {
                    Console.Write(1 + " ");
                }
                else
                {
                    Console.Write(0 + " ");
                }
            }
        }

        private int numberOfComputers;
        private int[,] matrix;
        private int numberOfDirtyComputers;
        private bool[] dirtyComputers;
    }
}
