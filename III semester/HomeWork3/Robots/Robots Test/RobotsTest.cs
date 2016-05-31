using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots_namespace;

namespace Robots_Test
{
    [TestClass]
    public class RobotsTest
    {
        public struct ElementsForInput
        {
            public bool[,] matrix;
            public int[] arrayOfRobots;
        };

        public ElementsForInput Input(StreamReader sr)
        {
            ElementsForInput elements = new ElementsForInput();
            string inputString = reader.ReadLine();
            string[] stringsForInput = inputString.Split(' ');
            int numberOfNodes;
            int.TryParse(stringsForInput[0], out numberOfNodes);
            int numberOfRoads;
            int.TryParse(stringsForInput[1], out numberOfRoads);
            int numberOfRobots;
            int.TryParse(stringsForInput[2], out numberOfRobots);
            bool[,] matrix = new bool[numberOfNodes, numberOfNodes];
            for (int i = 0; i != numberOfNodes; ++i)
            {
                for (int j = 0; j != numberOfNodes; ++j)
                {
                    matrix[i, j] = false;
                }
            }
            for (int i = 0; i != numberOfRoads; ++i)
            {
                inputString = reader.ReadLine();
                stringsForInput = inputString.Split(' ');
                int from;
                int.TryParse(stringsForInput[0], out from);
                int to;
                int.TryParse(stringsForInput[1], out to);
                matrix[from, to] = true;
                matrix[to, from] = true;
            }
            int[] arrayOfRobots = new int[numberOfRobots];
            inputString = reader.ReadLine();
            stringsForInput = inputString.Split(' ');
            for (int i = 0; i != numberOfRobots; ++i)
            {
                int.TryParse(stringsForInput[i], out arrayOfRobots[i]);
            }
            elements.matrix = matrix;
            elements.arrayOfRobots = arrayOfRobots;
            return elements;
        }

        [TestMethod]
        public void TestTaskAboutRobots1()
        {
            reader = new StreamReader("Task1.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots2WithNotIsolatedRobot()
        {
            reader = new StreamReader("Task2.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots3WithNotIsolatedRobotAndNode0HasNotRobot()
        {
            reader = new StreamReader("Task3.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots4WithIsolatedRobot()
        {
            reader = new StreamReader("Task4.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots5WitNotIsolatedRobotAndHasNotCycle()
        {
            reader = new StreamReader("Task5.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots6WithIsolatedRobotAndHasNotCycle()
        {
            reader = new StreamReader("Task6.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots7WithTwoIsolatedRobots()
        {
            reader = new StreamReader("Task7.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots8()
        {
            reader = new StreamReader("Task8.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots9()
        {
            reader = new StreamReader("Task9.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestTaskAboutRobots10()
        {
            reader = new StreamReader("Task10.txt");
            ElementsForInput elements = Input(reader);
            bool result = TaskAboutRobots.resultOfTask(elements.matrix, elements.arrayOfRobots);
            Assert.IsTrue(result);
        }

        private StreamReader reader;
    }
}
