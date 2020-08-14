 namespace Cycle_Race
{
    public class Bet
    {
        public int Amount;
        public int CycleNum;
        public Punter Punter;

        public Bet(int Amount, int CycleNum, Punter Punter)
        {
            this.Amount = Amount;
            this.CycleNum = CycleNum;
            this.Punter = Punter;
        }

        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = string.Format("{0} bets {1} on Cycle #{2}",
                    Punter.Title, Amount, CycleNum);
            }
            else
            {
                description = string.Format("{0} bets are not placed yet",
                    Punter.Title);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (CycleNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
