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
        public static bool resultOfTask(bool[,] matrix, int[] arrayOfRobots)
        {
            int numberOfNodes = matrix.GetLength(0);
            int numberOfRobots = arrayOfRobots.Length;
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
                    visitNode(arrayOfRobots[i], ref numberOfRobotsInThisEvenness, isRobotInFirstEvenness, true, visit, matrix, arrayOfRobots);
                    if (numberOfRobotsInThisEvenness == 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Visit node and call visitNode for all friendly nodes, which we can visit.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="numberOfRobotsInThisEvenness"></param>
        /// <param name="isRobotInFirstEvenness"></param>
        /// <param name="evenness"></param>
        /// <param name="visit"></param>
        /// <param name="numberOfNodes"></param>
        /// <param name="matrix"></param>
        /// <param name="numberOfRobots"></param>
        /// <param name="arrayOfRobots"></param>
        public static void visitNode(int node, ref int numberOfRobotsInThisEvenness, bool[] isRobotInFirstEvenness, bool evenness, bool[] visit, bool[,] matrix, int[] arrayOfRobots)
        {
            visit[node] = true;
            int numberOfNodes = matrix.GetLength(0);
            int numberOfRobots = arrayOfRobots.Length;
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
                    visitNode(k, ref numberOfRobotsInThisEvenness, isRobotInFirstEvenness, !evenness, visit, matrix, arrayOfRobots);            
                }
            }
        }
    }
}
