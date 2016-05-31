namespace Zadacha4_Cursor
{
    using System;

    public class EventCursor
    {
        /// <summary>
        /// Constructor for event of corsor.
        /// </summary>
        public EventCursor()
        {
            Console.Clear();
            coordinateX = Console.CursorLeft;
            coordinateY = Console.CursorTop;
        }

        /// <summary>
        /// Turn cursor left.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLeft(object sender, EventArgs args)
        {
            PointCursor(-1, 0);
        }

        /// <summary>
        /// Turn cursor right.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRight(object sender, EventArgs args)
        {
            PointCursor(1, 0);
        }

        /// <summary>
        /// Turn cursor up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnUp(object sender, EventArgs args)
        {
            PointCursor(0, -1);
        }

        /// <summary>
        /// Turn cursor down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDown(object sender, EventArgs args)
        {
            PointCursor(0, 1);
        }

        /// <summary>
        /// Move cursor to (delta x, delta y).
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        private void PointCursor(int deltaX, int deltaY)
        {
            if (coordinateX + deltaX >= 0 && coordinateY + deltaY >= 0)
            {
                if (coordinateX + deltaX < Console.BufferWidth && (coordinateY + deltaY < Console.BufferHeight))
                {
                    Console.SetCursorPosition(coordinateX + deltaX, coordinateY + deltaY);
                    coordinateX += deltaX;
                    coordinateY += deltaY;
                }
                else
                {
                    throw new ExceptionWrongDirectionOfCursor();
                }
            }
            else
            {
                throw new ExceptionWrongDirectionOfCursor();
            }
        }

        /// <summary>
        /// Coordinate x and y of cursor now.
        /// </summary>
        private int coordinateX { get; set; }
        private int coordinateY { get; set; }
    }
}
