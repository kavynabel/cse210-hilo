using System;
using System.Collections.Generic;

namespace hilo1
{
    public class Game
    {
        // what is in game class- member variables
        bool isPlaying;
        int score;
        string guess = "";
        // int card; // maybe need to comment this? and line below.
        // int other;
        Card card = new Card();

        // constructor
        public Game()
        {
            isPlaying = true;
            score = 300;
        }

        //methods
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates(guess, card);
                DoOutputs();    
            }
        }
        public void GetInputs()
        {
            Console.WriteLine($"The card is {card.cardValue}");
            Console.Write("Higher or lower? [h/l] ");
            guess = Console.ReadLine();
            // isPlaying = (guess == "y");
            
        }

        public void again()
        {
            if (score > 0)
            {
               Console.WriteLine("Would you like to play again? [y/n]");
               string answer = Console.ReadLine();
               isPlaying = (answer == "y");
            }
            else
            {
                isPlaying = false;
            }
        }

        public void DoUpdates(string guess, Card card) // need parameters here for card and guess so can use them?
        {
            Card other = new Card();
            Console.WriteLine($"The next card is {other.cardValue}");
            // int otherCard = Card.nextCard(); (shouldnt need because when get new card number is already there from constructor)
            // if higher / lower adjust score accordingly
            if (other.cardValue > card.cardValue && guess == "h")
            {
                // award points
                score = score + 100;
            }
            else if(other.cardValue < card.cardValue && guess == "l")
            {
                score = score + 100;
            }
            else
            {
                score = score - 75;
            }
            card.cardValue = other.cardValue;
        }

        public void DoOutputs()
        {
            
            // display score
            Console.WriteLine($"Your score is: {score}");
             // isPlaying = (score > 0); // so if this is false it should stop the StartGame loop. (end the game) (now don't need this line with my Game.Again below I think)
             again();
        }
    }
}