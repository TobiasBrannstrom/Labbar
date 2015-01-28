using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration4.A
{
    public class SecretNumber
    {
        private int _count;
        private int _number;

        public const int MaxNumberOfGuesses = 7;

        public void Initialize()
        {
            _count = 0;
           
            Random randomNumber = new Random();
            _number = randomNumber.Next(1, 101);       
        }

        public bool MakeGuess(int number)
        {
            if(number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }

            _count++;

            if (number < _number && _count != MaxNumberOfGuesses)
            {
            Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));
            }

            else if (number > _number && _count != MaxNumberOfGuesses)
            {
            Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));
            }

            else if (number == _number)
            {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} försök.", _count);
            Console.ResetColor();
            return true;
            }

            else if (number < _number && _count == MaxNumberOfGuesses)
            {
                 Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.\nDet hemliga talet var {2}.", number, (MaxNumberOfGuesses - _count), _number);
            }
                        
            else if (number > _number && _count == MaxNumberOfGuesses)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.\nDet hemliga talet var {2}.", number, MaxNumberOfGuesses - _count, _number);
            }                
            return false;
        }

        public SecretNumber()
        {
            Initialize();
        }
    }
}
