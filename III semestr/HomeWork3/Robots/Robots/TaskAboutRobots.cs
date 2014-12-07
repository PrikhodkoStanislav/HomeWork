namespace Robots_namespace
{
    /// <summary>
    /// Class of task.
    /// </summary>
    public class TaskAboutRobots
    {
        /// <summary>
        /// Result of task.
        /// </summary>
        /// <param name="numberOfNodes"></param>
        /// <param name="matrix"></param>
        /// <param name="numberOfRobots"></param>
        /// <param name="arrayOfRobots"></param>
        /// <returns></returns>
        public static bool resultOfTask(int numberOfNodes, bool[,] matrix, int numberOfRobots, int[] arrayOfRobots)
        {
            bool[] visit = new bool[numberOfNodes];
            bool[] isRobotInFirstEvenness = new bool[numberOfRobots];
            for (int i = 0; i != numberOfRobots; ++i)
            {
                isRobotInFirstEvenness[i] = false;
            }
            for (int i = 0; i != numberOfRobots; ++i)
            {
                for (int k = 0; k != numberOfNodes; ++k)
                {
                    visit[k] = false;
                }
                if (!isRobotInFirstEvenness[i])
                {
                    int numberOfRobotsInThisEvenness = 0;
                    visitNode(arrayOfRobots[i], ref numberOfRobotsInThisEvenness, isRobotInFirstEvenness, true, visit, numberOfNodes, matrix, numberOfRobots, arrayOfRobots);
                    if (numberOfRobotsInThisEvenness == 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void visitNode(int node, ref int numberOfRobotsInThisEvenness, bool[] isRobotInFirstEvenness, bool evenness, bool[] visit, int numberOfNodes, bool[,] matrix, int numberOfRobots, int[] arrayOfRobots)
        {
            visit[node] = true;
            if (evenness)
            {
                for (int i = 0; i != numberOfRobots; ++i)
                {
                    if (arrayOfRobots[i] == node)
                    {
                        isRobotInFirstEvenness[i] = true;
                        numberOfRobotsInThisEvenness++;
                        break;
                    }
                }      
            }
            for (int k = 0; k != numberOfNodes; ++k)
            {
                if (matrix[node, k] && !visit[k])
                {
                    visitNode(k, ref numberOfRobotsInThisEvenness, isRobotInFirstEvenness, !evenness, visit, numberOfNodes, matrix, numberOfRobots, arrayOfRobots);            
                }
            }
        }
    }
}
