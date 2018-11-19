using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Die
    {
        // ONE change
        // instance variables - replace the example below with your own
        private int faceValue;
        private Random r;
        /**
         * Constructor for objects of class Die
         */
        public Die(Random r)
        {
            // initialise instance variables
            this.r = r;
           // roll();
        }

        public void roll()
        {
            
            faceValue = (int)(r.Next(1,6) );
           // Console.WriteLine("Face Value: " + faceValue);
        }

        public int getFaceValue()
        {
            return faceValue;
        }

    }
}
