namespace Zadacha4_Cursor
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Main class.
    /// </summary>
    public class MainClass
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var cursor = new EventCursor();

            eventLoop.LeftHandler += cursor.OnLeft;
            eventLoop.RightHandler += cursor.OnRight;
            eventLoop.UpHandler += cursor.OnUp;
            eventLoop.DownHandler += cursor.OnDown;

            try
            {
                eventLoop.Run();
            }
            catch (ExceptionWrongDirectionOfCursor e)
            {
                Console.WriteLine();
            }
        }
    }
}
