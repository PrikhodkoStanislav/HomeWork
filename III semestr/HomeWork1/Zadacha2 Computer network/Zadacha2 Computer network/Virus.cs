using System;

namespace Zadacha2_Computer_network
{
    public class Virus
    {
        public Virus(int number, int[] numbersOfComputers)
        {
            this.numberOfViruses = number;
            this.computers = numbersOfComputers;
        }

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

        private int Road(int index, int[] variants, OS os)
        {
            int sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum += os.probabilityOfComputer(variants[i]);
            }
            int[] arrayOf100Probability = new int[index];
            arrayOf100Probability[0] = 100 * (os.probabilityOfComputer(variants[0]) / sum);
            for (int i = 1; i < index; i++)
            {
                arrayOf100Probability[i] = arrayOf100Probability[i - 1] + 100 * (os.probabilityOfComputer(variants[i]) / sum);
            }
            Random random = new Random();
            int roadProbability = random.Next(100);
            for (int i = 0; i < index; i++)
            {
                if (roadProbability < arrayOf100Probability[i])
                {
                    return variants[i];
                }
            }
            return (index - 1);
        }

        private void Infection(int from, int to, bool[] dirtyComputers)
        {
            //for (int i = 0; i < numberOfViruses; i++)
            //{
                //if (computers[i] == from)
                //{
                //    computers[i] = to;
                //}
            //}
            computers[numberOfViruses] = to;//
            numberOfViruses++;//
            dirtyComputers[to] = true;
        }

        private int numberOfViruses;
        private int[] computers;
    }
}
