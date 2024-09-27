using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssigment1
{
       internal  class BeerSong
    {
        public void Song(int numbers)
        {
            for (int i = numbers; i > 0; i--) 
            {   if (i > 1)
                {
                    Console.WriteLine(i + " bottles of beer on the wall," + i + " bottles of beer.Take one down and pass it around,");
                    Console.WriteLine(); 
                }

                else 
                { 
                    Console.WriteLine(i + " bottles of beer on the wall," + i + " bottles of beer.Take one down and pass it around.");
                }
            }

        }

    }
}
