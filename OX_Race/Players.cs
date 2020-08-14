using System.Windows.Forms;


namespace Cycle_Race
{
    public class Kaur : Punter
    {
        public Kaur(Bet MyBet, Label HigherBet, int Money, Label MyLabel) : base(MyBet, HigherBet, Money, MyLabel)
        {
            Title = "Kaur";
        }

       
    }

    public class Kumar : Punter
    {
        public Kumar(Bet bet, Label HigherBet, int Money, Label label) : base(bet, HigherBet, Money, label)
        {
            Title = "Kumar";
        }

       
    }

    public class Singh : Punter
    {
        public Singh(Bet bet, Label HigherBet, int Money, Label label) : base(bet, HigherBet, Money, label)
        {
            Title = "Singh";
        }

        
    }
}
