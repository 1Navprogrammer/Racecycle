using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cycle_Race
{
    public partial class CycleRaceForm : Form
    {
         readonly Cycle[] Cycles = new Cycle[4];

       
         readonly Punter[] punters = new Punter[3];

        public CycleRaceForm()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Cycle.StartingPosition1 = CycleBlack.Right - racetrack.Left;
            Cycle.RacetrackLength1 = racetrack.Size.Width - 70; //fixing length of race - till finish line

            Cycles[0] = new Cycle() { CyclePictureBox = CycleBlack };
            Cycles[1] = new Cycle() { CyclePictureBox = CycleBlue };
            Cycles[2] = new Cycle() { CyclePictureBox = CycleRed };
            Cycles[3] = new Cycle() { CyclePictureBox = CycleYellow };

            punters[0] = PlayerFactory.getPunter("Kaur", HigherBet, KaurBet); //getting Kaur object from factory class
            punters[1] = PlayerFactory.getPunter("Singh", HigherBet, SinghBet); //getting Singh object from factory class
            punters[2] = PlayerFactory.getPunter("Kumar", HigherBet, KumarBet); //getting Kumar object from factory class

            Debug.WriteLine(punters[0].Title);

            //Debug.Writeline(Punters[0]Title);
            foreach (Punter punter in punters)
            {
                punter.UpdateLabels();
            }
        }

        private void KaurButton_CheckedChanged(object sender, EventArgs e)
        {
            setHigherBetTextLabel(punters[0].money);
        }

        private void SinghButton_CheckedChanged(object sender, EventArgs e)
        {
            setHigherBetTextLabel(punters[1].money);
        }

        private void KumarButton_CheckedChanged(object sender, EventArgs e)
        {
            setHigherBetTextLabel(punters[2].money);
        }

        private void setHigherBetTextLabel(int Cash)
        {
            HigherBet.Text = string.Format("Higher Bet: ${0}", Cash);
        }

        // setting the bet for each Punter and updating labels respectively
        private void Bets_Click(object sender, EventArgs e)
        {
            int PunterNum = 0;

            if (KaurButton.Checked)
            {
                PunterNum = 0;
            }
            if (SinghButton.Checked)
            {
                PunterNum = 1;
            }
            if (KumarButton.Checked)
            {
                PunterNum = 2;
            }

            punters[PunterNum].PlaceBet((int)BettingAmount.Value, (int)CycleNumber.Value);
            punters[PunterNum].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningCycle;
            race.Enabled = false; //Unable begin race button

            while (NoWinner)
            { // loop as far as we find a Victor
                Application.DoEvents();
                for (int i = 0; i < Cycles.Length; i++)
                {
                    if (Cycle.Run(Cycles[i]))
                    {
                        winningCycle = i + 1;
                        NoWinner = false;
                        MessageBox.Show("Victor is - Cycle #" + winningCycle);
                        foreach (Punter punter in punters)
                        {
                            if (punter.gamble != null)
                            {
                                punter.Collect(winningCycle); //give twin amount who've won or deduce bette amount
                                punter.gamble = null;
                                punter.UpdateLabels();
                            }
                        }
                        foreach (Cycle Cycle in Cycles)
                        {
                            Cycle.StartPosition();
                        }
                        break;
                    }
                }
            }
            if (punters[0].busted && punters[1].busted && punters[2].busted)
            {  //if the cash is finish stop punters from betting 
                string message = "Wanna Play Again?";
                string title = "Finished!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    Close();
                }

            }
            race.Enabled = true;
        }

        private void racetrack_Click(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CycleBlue_Click(object sender, EventArgs e)
        {

        }
    }
}
