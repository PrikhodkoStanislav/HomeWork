using System;

namespace Zadacha2_Computer_network
{
    /// <summary>
    /// Class for system of the viruses in the computer network.
    /// </summary>
    public class Virus
    {
        /// <summary>
        /// Constructor for the virus system.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numbersOfComputers"></param>
        public Virus(int number, int[] numbersOfComputers)
        {
            this.numberOfViruses = number;
            this.computers = numbersOfComputers;
            this.random = new Random(100);
        }

        /// <summary>
        /// Can viruses go to healthy computers in the network?
        /// </summary>
        /// <param name="numberOfComputers"></param>
        /// <param name="matrix"></param>
        /// <param name="dirtyComputers"></param>
        /// <returns></returns>
        public bool CanGo(int numberOfComputers ,int[,] matrix, bool[] dirtyComputers)
        {
            for (int i = 0; i < numberOfViruses; i++)
            {
                for (int j = 0; j < numberOfComputers; j++)
                {
                    if (matrix[computers[i], j] == 1 && !dirtyComputers[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Virus go to the computer!
        /// </summary>
        /// <param name="numberOfComputers"></param>
        /// <param name="matrix"></param>
        /// <param name="dirtyComputers"></param>
        /// <param name="os"></param>
        /// <param name="start"></param>
        public void Go(int numberOfComputers, int[,] matrix, bool[] dirtyComputers, OS os, ref int start)
        {
            for (int i = start; i < numberOfViruses; i++)
            {
                int index = 0;
                int[] variants = new int[numberOfComputers];
                for (int j = 0; j < numberOfComputers; j++)
                {
                    if (matrix[computers[i], j] == 1 && !dirtyComputers[j])
                    {
                        variants[index] = j;
                        index++;
                    }
                }
                if (index == 0)
                    continue;
                Infection(i, Road(index, variants, os), dirtyComputers);
                start = i + 1;
                return;
            }
            for (int i = 0; i < start; i++)
            {
                int index = 0;
                int[] variants = new int[numberOfComputers];
                for (int j = 0; j < numberOfComputers; j++)
                {
                    if (matrix[computers[i], j] == 1 && !dirtyComputers[j])
                    {
                        variants[index] = j;
                        index++;
                    }
                }
                if (index == 0)
                    continue;
                Road(index, variants, os);
                Infection(i, Road(index, variants, os), dirtyComputers);
                start = i + 1;
                return;
            }
            return;
        }

        /// <summary>
        /// Return number of the attacked computer.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="variants"></param>
        /// <param name="os"></param>
        /// <returns></returns>
        private int Road(int index, int[] variants, OS os)
        {
            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum += os.probabilityOfComputer(variants[i]);
            }
            int[] arrayOf100Probability = new int[index];
            arrayOf100Probability[0] = (100 * os.probabilityOfComputer(variants[0])) / sum;
            for (int i = 1; i < index; i++)
            {
                arrayOf100Probability[i] = arrayOf100Probability[i - 1] + (100 * os.probabilityOfComputer(variants[i])) / sum;
            }
            int roadProbability = random.Next(1, 100);
            for (int i = 0; i < index; i++)
            {
                if (roadProbability < arrayOf100Probability[i])
                {
                    return variants[i];
                }
            }
            return (index - 1);
        }

        /// <summary>
        /// Attack the computer!
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="dirtyComputers"></param>
        private void Infection(int from, int to, bool[] dirtyComputers)
        {
            computers[numberOfViruses] = to;
            numberOfViruses++;
            dirtyComputers[to] = true;
        }

        /// <summary>
        /// Number of viruses in the network.
        /// </summary>
        private int numberOfViruses;

        /// <summary>
        /// Numbers of dirty computers.
        /// </summary>
        private int[] computers;

        /// <summary>
        /// Random for virus.
        /// </summary>
        private Random random;
    }
}
