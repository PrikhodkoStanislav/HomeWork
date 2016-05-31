namespace Zadacha2_Computer_network
{
    /// <summary>
    /// Class of the OS in the computer network.
    /// </summary>
    public class OS
    {
        /// <summary>
        /// Constructor for OS.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="osOfComputers"></param>
        public OS(int number, int[] osOfComputers)
        {
            this.numberOfComputer = number;
            probability = new int[number];
            for (int i = 0; i < number; i++)
            {
                int temp = 0;
                switch (osOfComputers[i])
                {
                    case (0) :
                        temp = 20;
                        break;
                    case (1):
                        temp = 40;
                        break;
                    case (2):
                        temp = 30;
                        break;
                    case (3):
                        temp = 80;
                        break;
                }
                probability[i] = temp;
            }
        }

        /// <summary>
        /// Return probability of the computer with number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int probabilityOfComputer(int number)
        {
            return probability[number];
        }

        /// <summary>
        /// Number of computers in the network.
        /// </summary>
        private int numberOfComputer;

        /// <summary>
        /// Array of the probabilitys to be infected.
        /// </summary>
        private int[] probability;
    }
}
