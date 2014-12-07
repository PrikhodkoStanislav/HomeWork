using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Zadacha2_Computer_network;

namespace Computer_network_Test
{
    [TestClass]
    public class ComputerNetworkTest
    {
        public struct ElementsForInput
        {
            public int number;
            public int[] arrayOfOS;
            public int[,] matrix;
            public bool[] dirtyComputers;
            public int virusNumber;
            public int[] arrayOfVirus;
        };

        public ElementsForInput Input(StreamReader sr)
        {
            ElementsForInput elements = new ElementsForInput();
            int number = 0;
            int[] arrayOfOS;
            int[,] matrix;
            bool[] dirtyComputers;
            int virusNumber = 0;
            int[] arrayOfVirus;

            string input = sr.ReadLine();
            int.TryParse(input, out number);
            input = sr.ReadLine();
            string[] stringOS = input.Split(' ');
            arrayOfOS = new int[number];
            for (int i = 0; i < number; i++)
            {
                int.TryParse(stringOS[i], out arrayOfOS[i]);
            }
            matrix = new int[number, number];
            for (int i = 0; i < number; i++)
            {
                input = sr.ReadLine();
                string[] stringMatrix = input.Split(' ');
                for (int j = 0; j < number; j++)
                {
                    int.TryParse(stringMatrix[j], out matrix[i, j]);
                }
            }
            dirtyComputers = new bool[number];
            input = sr.ReadLine();
            string[] stringDirty = input.Split(' ');
            virusNumber = stringDirty.Length;
            arrayOfVirus = new int[number];
            for (int i = 0; i < virusNumber; i++)
            {
                int index = 0;
                int.TryParse(stringDirty[i], out index);
                dirtyComputers[index - 1] = true;
                arrayOfVirus[i] = index - 1;
            }
            elements.number = number;
            elements.arrayOfOS = arrayOfOS;
            elements.matrix = matrix;
            elements.dirtyComputers = dirtyComputers;
            elements.virusNumber = virusNumber;
            elements.arrayOfVirus = arrayOfVirus;
            return elements;
        }

        [TestMethod]
        public void ComputerNetworkTest1()
        {
            sr = new StreamReader("computer_network.in");
            sw = new StreamWriter("computer_network.out");
            ElementsForInput elements = Input(sr);
            Virus virus = new Virus(elements.virusNumber, elements.arrayOfVirus);
            Network network = new Network(elements.number, elements.matrix, elements.dirtyComputers, elements.virusNumber);
            OS os = new OS(elements.number, elements.arrayOfOS);
            network.PrintNetwork(sw, virus, os);
            sr.Close();
            sw.Close();
            sr1 = File.OpenText("computer_network.out");
            Assert.AreEqual("1 0 0 ", sr1.ReadLine());
            Assert.AreEqual("1 0 1 ", sr1.ReadLine());
            Assert.AreEqual("1 1 1 ", sr1.ReadLine());
            sr1.Close();
        }

        [TestMethod]
        public void ComputerNetworkTest2()
        {
            sr = new StreamReader("computer_network2.in");
            sw = new StreamWriter("computer_network.out");
            ElementsForInput elements = Input(sr);
            Virus virus = new Virus(elements.virusNumber, elements.arrayOfVirus);
            Network network = new Network(elements.number, elements.matrix, elements.dirtyComputers, elements.virusNumber);
            OS os = new OS(elements.number, elements.arrayOfOS);
            network.PrintNetwork(sw, virus, os);
            sr.Close();
            sw.Close();
            sr1 = File.OpenText("computer_network.out");
            Assert.AreEqual("1 1 0 0 0 ", sr1.ReadLine());
            Assert.AreEqual("1 1 0 0 1 ", sr1.ReadLine());
            Assert.AreEqual("1 1 1 0 1 ", sr1.ReadLine());
            Assert.AreEqual("1 1 1 1 1 ", sr1.ReadLine());
            sr1.Close();
        }

        private StreamReader sr;
        private StreamReader sr1;
        private StreamWriter sw;
    }
}
