using System;
using System.Collections.Generic;

namespace backgammon
{
    public class Engine
    {
        //Create board
        private List<List<Piece>> board_ = new List<List<Piece>>();
        private void createBoard(int size=24)
        {
            int rsize = size+2;
            Dictionary<int, int> spots = new Dictionary<int, int>();
            spots.Add(1, 5);
            spots.Add(12, 2);
            spots.Add(18, 5);
            spots.Add(20,2);
            // create columns
            for (int i = 0; i < rsize; i++)
            {
                // int white = [1, 12, 18, 20];
                // Black[24 13 7 5]
                // Fills first column
                if(spots.ContainsKey(i)){
                    //add white pieces to spot i x spots.value

                    // add black pieces to spot rsize-i x spot.value

                }
            }
        }

    }

    class Piece
    {
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
