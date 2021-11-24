using System;
using System.Linq;

namespace _0036ValidSudoku
{
    class Program
    {
        public bool IsValidSudoku(char[][] board)
        {

            if (CheckHorizontaal(board) && CheckVerticaal(board) && CheckPerHokje(board))
            {
                return true;
            }
            return false;
        }

        private bool CheckPerHokje(char[][] board)
        {
            //split array in 3 delen (rijen)
            char[][] firstRow = board.Take(3).ToArray();
            char[][] secondRow = board.Skip(3).Take(3).ToArray();
            char[][] thirdRow = board.Skip(6).Take(3).ToArray();

            //split rij 1 in 3 boxen
            char[] x = firstRow[0].Take(3).ToArray();
            char[] y = firstRow[1].Take(3).ToArray();
            char[] z = firstRow[2].Take(3).ToArray();
            char[] firstBoxFirstRow = x.Concat(y).Concat(z).ToArray();

            char[] a = firstRow[0].Skip(3).Take(3).ToArray();
            char[] b = firstRow[1].Skip(3).Take(3).ToArray();
            char[] c = firstRow[2].Skip(3).Take(3).ToArray();
            char[] secondBoxFirstRow = a.Concat(b).Concat(c).ToArray();

            char[] k = firstRow[0].Skip(6).Take(3).ToArray();
            char[] l = firstRow[1].Skip(6).Take(3).ToArray();
            char[] m = firstRow[2].Skip(6).Take(3).ToArray();
            char[] thirdBoxFirstRow = k.Concat(l).Concat(m).ToArray();


            return true;
        }

        public bool CheckHorizontaal(char[][] board)
        {
            //horizontaal
            char temp = 'x';

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    //horizontaal
                    temp = board[i][j];
                    while (temp == '.' && j < board[i].Length - 1)
                    {
                        j++;
                        temp = board[i][j];
                    }

                    for (int k = j + 1; k < board[i].Length; k++)
                    {
                        if (temp == board[i][k])
                            return false;
                    }
                }
            }
            return true;
        }
        public bool CheckVerticaal(char[][] board)
        {
            //verticaal
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    var tempVal = board[j][i];
                    while (tempVal == '.' && j < board[i].Length - 1)
                    {
                        j++;
                        tempVal = board[j][i];
                    }
                    if (j == board[i].Length - 1)
                    {
                        break;
                    }
                    for (int k = j + 1; k < board[i].Length; k++)
                    {
                        if (tempVal == board[k][i])
                        {
                            return false;
                        }
                    }

                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            char[][] sudoku = new char[][]
            {
                new char[]{'5','3','.','.','7','.','.','.','.'},
                new char[]{'6','.','.','1','9','5','.','.','.'},
                new char[]{'.','9','8','.','.','.','.','6','.'},
                new char[]{'8','.','.','.','6','.','.','.','3'},
                new char[]{'4','.','.','8','.','3','.','.','1'},
                new char[]{'7','.','.','.','2','.','.','.','6'},
                new char[]{'.','6','.','.','.','.','2','8','.'},
                new char[]{'.','.','.','4','1','9','.','.','5'},
                new char[]{'.','.','.','.','8','.','.','7','9'},

            };


            char[][] sudokuEmpty = new char[][]
            {
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},
                new char[]{'.','.','.','.','.','.','.','.','.'},

            };

            Program p = new Program();
            var x = p.IsValidSudoku(sudoku);
            Console.WriteLine(x);
        }
    }
}
