using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cycle_Race
{
    public class Cycle
    {
        private static int StartingPosition;
        private static int RacetrackLength;
        public PictureBox CyclePictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get => StartingPosition; set => StartingPosition = value; }
        public static int RacetrackLength1 { get => RacetrackLength; set => RacetrackLength = value; }

        // generation across all Cycle objects

        public static bool Run(Cycle obj)
        {
            int distance = MyRandom.Next(1, 10);
            if (obj.CyclePictureBox != null)
                obj.MoveCyclePictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void StartPosition()
        {
            MoveCyclePictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveCyclePictureBox(int distance)
        {
            Point p = CyclePictureBox.Location;
            p.X += distance;
            CyclePictureBox.Location = p; //move Cycle in x-axis
        }
    }
}
