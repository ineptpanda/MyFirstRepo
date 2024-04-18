using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Player
    {
        //Attributes (instance variables)
        private string name;
        private int score;
        private int livesLeft;
        private int gold;

        //Constructors (generates a new object)

        public Player(string name)
        {
            this.name = name;
        } //end method

        public Player(string name, int startingLives) 
        {
            this.name = name;
            livesLeft = startingLives;
        }//end method

        //Methods = behaviors or tasks that the object can perform
        public int GetScore()
        { 
            return score; 
        }//end method

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }//end method

        public void Kill()
        {
            //We make sure that they can't get negative lives
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }//end method

        public int GetLivesLeft()
        {
            return livesLeft;
        }//end method

        //method to return gold total
        public int GetGold()
        {
            return gold;
        }//end method
        
        //method to add gold to total
        public void AddGold(int totalGold)
        {
            gold += totalGold;
        }
        //method to subtract gold from total
        public void SubtractGold(int totalGold)
        {
            gold -= totalGold;
        }
    }//end class
}//end namespace
 