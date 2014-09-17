namespace Zadacha2_Computer_network
{
    public class OS
    {
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
                        temp = 50;
                        break;
                }
                probability[i] = temp;
            }
        }

        public int probabilityOfComputer(int number)
        {
            return probability[number];
        }


        private int numberOfComputer;
        private int[] probability;
    }
}
