using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class GameBoard
    {
        static void Main(string[] args)
        {
            int height = 3;
            int width = 3;

            //to draw board
            GameBoard draw = new GameBoard();
            int[,] DrawBoardPosition = new int[height, width];

            //to store board
            ConnectFour game_data = new ConnectFour();
            char[,] StoredDrawBoardMoves = new char[height, width];

            //drawing the board
            draw.Board(height, width, DrawBoardPosition);

            Console.WriteLine("Please pick a position for your move: ");
            Console.ReadLine();

        }

        public void Board(int h, int w, int[,] boardPlaySpot)
        {
            int i;
            int j;
            char charspacing = ' ';
            string borderDivider = new string('+', w * 2);
            string width = "|";
            int charBoardPosition = 0;

            // Rows, in width
            for (i = 0; i < w; i++)
            {
                Console.Write("\n");

                for (j = 0; j < h; j++)
                {
                    if (i % 2 == 1)
                    {
                        charBoardPosition++;
                        boardPlaySpot[i, j] = charBoardPosition;
                        //Console.Write(charChoice[i,j]);
                        Console.Write(charspacing);
                        Console.Write(width);
                    }
                    if (i % 2 == 0)
                    {
                        charBoardPosition++;
                        boardPlaySpot[i, j] = charBoardPosition;
                        //Console.Write(charChoice[i,j]);
                        Console.Write(charspacing);
                        Console.Write(width);
                    }
                }
                Console.Write("\n" + borderDivider);
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }

    public class ConnectFour
    {
        public int chips;
        public int rows;
        public int columns;
        public bool locked;

        public ConnectFour()
        {
            this.chips = 42;
            this.rows = 6;
            this.columns = 7;
            this.locked = true;
        }
        public int Chips
        {
            get
            {
                return chips;
            }
        }
        public int Rows
        {
            get
            {
                return rows;
            }
        }
        public int Columns
        {
            get
            {
                return columns;
            }
        }
        public bool Locked
        {
            get
            {
                return locked;
            }
        }












        //int index = 0;
        //int[,] boardPosition = new int[hght, wdth];

        //for (int x = 0; x < hght; x++)
        //{
        //for (int y = 0; y < wdth; y++)
        //{
        //index++;

        //boardPosition[x,y] = index;
        //Console.Write(boardPosition[x,y]);
        //}
        //}
        //Console.Write(boardPosition[0,1]);
        //if(boardPosition[0, 1] == )
        //Console.ReadLine();
        //}
    }
}
