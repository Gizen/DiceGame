using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiceGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int round = 1;
        int score = 0;
        int roundScore = 0;
        int dice1 = 0;
        int dice2 = 0;
        int dice3 = 0;
        int dice4 = 0;
        int rollsLeft = 5;
        int highScore = 0;        

        public MainWindow()
        {
            InitializeComponent();

            //Update Dice
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            dice3 = rnd.Next(1, 7);
            dice4 = rnd.Next(1, 7);
            button1.Content = dice1.ToString();
            button2.Content = dice2.ToString();
            button3.Content = dice3.ToString();
            button4.Content = dice4.ToString();

            //Display Round
            textBlockRound.Text = "Round " + round;

            //Update Rolls Left
            textBlockRollsLeft.Text = "RoLLs Left: " + rollsLeft;

            //Update Round Score
            if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
            {
                roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                textBlockRoundScore.Text = "Round Score: " + roundScore;
            }
            else
            {
                roundScore = dice1 + dice2 + dice3 + dice4;
                textBlockRoundScore.Text = "Round Score: " + roundScore;
            }

        }

        private void buttonNewRound_Click(object sender, RoutedEventArgs e)
        {

            if (round < 10)
            {
                //Reset Rolls Left
                rollsLeft = 5;
                textBlockRollsLeft.Text = "Rolls Left: " + rollsLeft;

                //Round Score Code
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                else
                {
                    roundScore = dice1 + dice2 + dice3 + dice4;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                //Bank Score
                score = roundScore + score;
                textBlockTotalScore.Text = "Total Score: " + score;

                //Roll Dice
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);
                dice3 = rnd.Next(1, 7);
                dice4 = rnd.Next(1, 7);
                button1.Content = dice1.ToString();
                button2.Content = dice2.ToString();
                button3.Content = dice3.ToString();
                button4.Content = dice4.ToString();

                //Round Score Code
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                else
                {
                    roundScore = dice1 + dice2 + dice3 + dice4;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }

                //Update round number
                round = round + 1;
                textBlockRound.Text = "Round " + round;
            }
            else
            {
                //Round Score Code
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                else
                {
                    roundScore = dice1 + dice2 + dice3 + dice4;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                //Bank Score
                score = roundScore + score;
                textBlockTotalScore.Text = "Total Score: " + score;

                if (score > highScore)
                {                    
                    textBlockHighScore.Text = "1. " + " " + score;
                    highScore = score;
                }
                textBlockRound.Text = "Game Over";
                button1.IsEnabled = false;
                button2.IsEnabled = false;
                button3.IsEnabled = false;
                button4.IsEnabled = false;
                buttonNewRound.IsEnabled = false;
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //if Statments
            if (rollsLeft > 0)
            {
                //rolls left
                rollsLeft--;
                textBlockRollsLeft.Text = "Rolls Left: " + rollsLeft;

                //Change Button
                dice1 = rnd.Next(1, 7);
                button1.Content = dice1.ToString();

                //Update Round Score
                //If all the dice are the same roundscroe * 5
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                else
                {
                    roundScore = dice1 + dice2 + dice3 + dice4;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //if Statments
            if (rollsLeft > 0)
            {
                //rolls left
                rollsLeft --;
                textBlockRollsLeft.Text = "Rolls Left: " + rollsLeft;

                //Change Button
                dice2 = rnd.Next(1, 7);
                button2.Content = dice2.ToString();

                //Update Round Score
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                else
                {
                    roundScore = dice1 + dice2 + dice3 + dice4;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //if Statments
            if (rollsLeft > 0)
            {
                //rolls left
                rollsLeft --;
                textBlockRollsLeft.Text = "Rolls Left: " + rollsLeft;

                //Change Button
                dice3 = rnd.Next(1, 7);
                button3.Content = dice3.ToString();

                //Update Round Score
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                else
                {
                    roundScore = dice1 + dice2 + dice3 + dice4;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //if Statments
            if (rollsLeft > 0)
            {
                //rolls left
                rollsLeft --;
                textBlockRollsLeft.Text = "Rolls Left: " + rollsLeft;

                //Change Button
                dice4 = rnd.Next(1, 7);
                button4.Content = dice4.ToString();

                //Update Round Score
                if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
                {
                    roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
                else
                {
                    roundScore = dice1 + dice2 + dice3 + dice4;
                    textBlockRoundScore.Text = "Round Score: " + roundScore;
                }
            }
        }

        private void buttonNewGame_Click(object sender, RoutedEventArgs e)
        {
            //Reset Everything
            round = 1;
            score = 0;
            roundScore = 0;
            rollsLeft = 5;

            //Reroll Dice
            dice1 = rnd.Next(1, 7);
            dice2 = rnd.Next(1, 7);
            dice3 = rnd.Next(1, 7);
            dice4 = rnd.Next(1, 7);
            button1.Content = dice1.ToString();
            button2.Content = dice2.ToString();
            button3.Content = dice3.ToString();
            button4.Content = dice4.ToString();

            //Unlock Buttons
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            buttonNewRound.IsEnabled = true;

            //Display Round
            textBlockRound.Text = "Round " + round;

            //Update Rolls Left
            textBlockRollsLeft.Text = "RoLLs Left: " + rollsLeft;

            //Update Round Score
            if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
            {
                roundScore = (dice1 + dice2 + dice3 + dice4) * 5;
                textBlockRoundScore.Text = "Round Score: " + roundScore;
            }
            else
            {
                roundScore = dice1 + dice2 + dice3 + dice4;
                textBlockRoundScore.Text = "Round Score: " + roundScore;
            }
        }
    }
}
