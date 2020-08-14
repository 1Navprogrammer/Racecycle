using System;
using System.Windows.Forms;

namespace Cycle_Race
{
    public  static class PlayerFactory
    {
        public static Punter getPunter(String Name, Label HigherBet, Label bet)
        {
            Punter p;
            switch (Name)
            {
                case "Kaur":
                    p = new Kaur(null, HigherBet, 50, bet);
                    break;

                case "Singh":
                    p = new Singh(null, HigherBet, 50, bet);
                    break;

                case "Kumar":
                    p = new Kumar(null, HigherBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            return p;
        }
    }
}
