using System;
using Cycle_Race;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Punter Kaur;
        Cycle[] Cycles = new Cycle[2];

        [TestMethod]
        public void TestWinnerOutcome()
        {
            Cycle.StartingPosition1 = 0;
            Cycle.RacetrackLength1 = 50;
            int BettingAmount = 50;
            int CycleNumber = 1;
            int expectedWin = 100;
            int expectedLose = 0;
            Cycles[0] = new Cycle() { CyclePictureBox = null };
            Cycles[1] = new Cycle() { CyclePictureBox = null };
            Kaur = PlayerFactory.getPunter("Kaur", null, null);
            Kaur.money = BettingAmount;
            Kaur.PlaceBet((int)BettingAmount, CycleNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Cycles.Length; i++)
                {
                    if (Cycle.Run(Cycles[i]))
                    {
                        win = i + 1;
                        Kaur.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Kaur.gamble.CycleNum == win)
            {
                Assert.AreEqual(expectedWin, Kaur.money, "Account not credited correctly");
            }
            if (Kaur.gamble.CycleNum != win)
            {
                Assert.AreEqual(expectedLose, Kaur.money, "Account not debited correctly");

            }
        }
    }
}
