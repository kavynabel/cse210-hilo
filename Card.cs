using System;

namespace hilo1
{
    public class Card
    {
        // member variables
        // public int number;
        public int cardValue;
        // constructor
        public Card()
        {
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,14);
        }
        // member functions
        // public int showCard()
        // {
        //     //show the first card.
        //     Random randomGenerator = new Random(); // randomGenerator is an instance/object(product) of the Random class.
        //     number = randomGenerator.Next(1,14);
        //     return number;
        // }
        // public void nextCard() //change this one to int probs!
        // {
        //     // show the next card
        //     Random randomGenerator = new Random();
        //     otherNumber = randomGenerator.Next(1,14);
       // }
    }
}