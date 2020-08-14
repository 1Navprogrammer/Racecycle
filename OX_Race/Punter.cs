using System;
using System.Windows.Forms;

namespace Cycle_Race
{
    public abstract class Punter
    {
        public string Title;
        public Bet gamble;
        public int money;
        public bool busted;
        public Label statusLabel, HigherBet;

      

        public Punter(Bet bet, Label HigherBet, int Cash, Label statusLabel)
        {
            this.gamble = bet;
            this.money = Cash;
            this.HigherBet = HigherBet;
            this.statusLabel = statusLabel;
            if (this.statusLabel != null)
                this.statusLabel.ForeColor = System.Drawing.Color.Black;

        }
        public void Collect(int Winner)
        {
            money += gamble.Pay(Winner);
        }
        public void UpdateLabels()
        {
            if (gamble == null)
            {
                statusLabel.Text = String.Format("{0} hasn't placed any bets", Title);
            }

            else
            {
                statusLabel.Text = gamble.GetDescription();
            }
            if (money == 0)
            {
                busted = true;
                statusLabel.Text = String.Format("BUSTED!");
                statusLabel.ForeColor = System.Drawing.Color.Red;

            }
            HigherBet.Text = String.Format("Higher Bet: ${0}", money);
        }


        public void ClearBet()
        {
            gamble.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Cycle)
        {
            if (Amount <= money)
            {
                gamble = new Bet(Amount, Cycle, this);
                return true;
            }
            return false;
        }

    }
}
