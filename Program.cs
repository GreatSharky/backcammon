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
            bool white = true;
            // create columns
            for (int i = 0; i < rsize; i++)
            {
                // Fills first column
                if(i == 1){
                    //create 5 pices
                    white = true;
                    for(int j = 0; j < 5; j++){
                        
                    }
                }
                else if(i == 5){
                    // create 3 black pices
                    white = false;
                    for(int j = 0; j < 3; j++){
                        
                    }
                }
                else if(i == 7){
                    // create 5 black pieces
                    white = false;
                    for(int j = 0; j < 5; j++){

                    }
                }
                else if(i == 12){
                    // create 2 white pices
                    white = true;
                    for(int j = 0; j < 2; j++){

                    }
                }
                else if(i == 13){
                    // create 2 black pices
                    white = false;
                    for(int j = 0; j < 2; j++){

                    }
                }
                else if(i == 18){
                    // create 5 white pices
                    white = true;
                    for(int j = 0; j < 5; j++){

                    }
                }
                else if(i == 20){
                    // create 3 white pices
                    white = true;
                    for(int j = 0; j < 3; j++){

                    }
                }
                else if(i == 24){
                    // create 5 black pices
                    white = false;
                    for(int j = 0; j < 5; j++){
                        
                    }
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
