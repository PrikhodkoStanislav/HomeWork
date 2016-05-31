using System;
using System.IO;

namespace Zadacha2_Computer_network
{
    /// <summary>
    /// Class of the condition of the computer network.
    /// </summary>
    public class Network
    {
        /// <summary>
        /// Constructor for the network.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="matrix"></param>
        /// <param name="dirty"></param>
        /// <param name="virusNumber"></param>
        public Network(int number, int[,] matrix, bool[] dirty, int virusNumber)
        {
            this.numberOfComputers = number;
            this.matrix = matrix;
            this.dirtyComputers = dirty;
            this.numberOfDirtyComputers = virusNumber;
        }

        /// <summary>
        /// Print condition of the network.
        /// </summary>
        /// <param name="virus"></param>
        /// <param name="os"></param>
        public void PrintNetwork(StreamWriter sw, Virus virus, OS os)
        {
            PrintNetworkNow(sw);
            int start = 0;
            while (numberOfComputers != numberOfDirtyComputers && virus.CanGo(numberOfComputers, matrix, dirtyComputers))
            {
                virus.Go(numberOfComputers, matrix, dirtyComputers, os, ref start);
                numberOfDirtyComputers++;
                PrintNetworkNow(sw);
            }
            sw.WriteLine();
        }

        /// <summary>
        /// Print condition of the network in this stage.
        /// </summary>
        private void PrintNetworkNow(StreamWriter sw)
        {
            for (int i = 0; i < numberOfComputers; i++)
            {
                if (dirtyComputers[i])
                {
                    sw.Write(1 + " ");
                }
                else
                {
                    sw.Write(0 + " ");
                }
            }
            sw.WriteLine();
        }

        /// <summary>
        /// Number of computers in the network.
        /// </summary>
        private int numberOfComputers;

        /// <summary>
        /// Adjacency matrix.
        /// </summary>
        private int[,] matrix;

        /// <summary>
        /// Number of dirty computer in the network.
        /// </summary>
        private int numberOfDirtyComputers;

        /// <summary>
        /// Array of condition of the computers.
        /// </summary>
        private bool[] dirtyComputers;
    }
}
