using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        //class properties listed below...
        private string typeOfFruit;
        private int piecesOfFruitLeft;
        //private int startingPiecesOfFruitLeft;
        //StartingPiecesOfFruitLeft

        //accessors
        public string TypeOfFruit
        {
            get;
        }
        public int PiecesOfFruitLeft
        {
            get
            {
                return piecesOfFruitLeft;
            }
            private set
            {
                piecesOfFruitLeft = value;
            }
        }
        //constructor 
        public FruitTree(string typeOfFruit, int startingPiecesOfFruitLeft)
        {
            TypeOfFruit = typeOfFruit;
            //startingPiecesOfFruitLeft =numberOfPiecesToRemove;
            PiecesOfFruitLeft = startingPiecesOfFruitLeft;
        }
        // method
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            bool pickFruit = false;
            if (piecesOfFruitLeft == 0)
            {
                pickFruit = false;
            }
            else if (piecesOfFruitLeft > 0)
            {
                pickFruit = true;
                PiecesOfFruitLeft -= numberOfPiecesToRemove;  
            }
            return pickFruit;
        }
    }
}
