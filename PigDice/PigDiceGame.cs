using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice
{
    public class PigDiceGame {
        private Random rnd = new Random(DateTime.Now.Millisecond);

        public int RollTheDie() {
            return rnd.Next(1 , 7);
        }
        public int PigDice() {
            var score = 0;
            var roll = RollTheDie();
            while(roll != 1) {
                score += roll;
                roll = RollTheDie();
            }
            return score;
        }

        public void Play() {  // method to start the game
            var worldRecordScore = 300;
            var highScore = 0;
            var gamesToPlay = 1000;
            while (gamesToPlay > 0 || highScore < worldRecordScore) {
                var score = PigDice();
                if(score < highScore) {
                    highScore = score;
                   // Console.WriteLine($"New High Score is {score} ");

                }
                gamesToPlay--;
            }
            Console.WriteLine($"New WW score is {highScore}");
            

  //          Console.WriteLine($" {score} ");

        }

    }
}
