//Sudoku Background
//Sudoku is a game played on a 9x9 grid. The goal of the game is to fill all cells of the
//grid with digits
//from 1 to 9, so that each column, each row, and each of the nine 3x3 sub-grids
//(also known as blocks) contain
//all of the digits from 1 to 9.
//(More info at: http://en.wikipedia.org/wiki/Sudoku)

//Sudoku Solution Validator
//Write a function validSolution/ValidateSolution/valid_solution() that accepts a 2D array
//representing a Sudoku board, and returns true if it is a valid solution, or false otherwise.
//The cells of the sudoku board may also contain 0's, which will represent empty cells.
//Boards containing one or more zeroes are considered to be invalid solutions.

//The board is always 9 cells by 9 cells, and every cell only contains integers from 0 to 9.

//Examples
//validSolution([
//  [5, 3, 4, 6, 7, 8, 9, 1, 2],
//  [6, 7, 2, 1, 9, 5, 3, 4, 8],
//  [1, 9, 8, 3, 4, 2, 5, 6, 7],
//  [8, 5, 9, 7, 6, 1, 4, 2, 3],
//  [4, 2, 6, 8, 5, 3, 7, 9, 1],
//  [7, 1, 3, 9, 2, 4, 8, 5, 6],
//  [9, 6, 1, 5, 3, 7, 2, 8, 4],
//  [2, 8, 7, 4, 1, 9, 6, 3, 5],
//  [3, 4, 5, 2, 8, 6, 1, 7, 9]
//]); // => true
//validSolution([
//  [5, 3, 4, 6, 7, 8, 9, 1, 2], 
//  [6, 7, 2, 1, 9, 0, 3, 4, 8],
//  [1, 0, 0, 3, 4, 2, 5, 6, 0],
//  [8, 5, 9, 7, 6, 1, 0, 2, 0],
//  [4, 2, 6, 8, 5, 3, 7, 9, 1],
//  [7, 1, 3, 9, 2, 4, 8, 5, 6],
//  [9, 0, 1, 5, 3, 7, 2, 1, 4],
//  [2, 8, 7, 4, 1, 9, 6, 3, 5],
//  [3, 0, 0, 4, 8, 1, 1, 7, 9]
//]); // => false

namespace CodeWars_Katas._4kyu;

internal class Sudoku_Solution_Validator
{
    public static bool ValidateSolution(int[][] board)
    {
        var colCheck = new List<int>();
        var rowCheck = new List<int>();
        var groupCheck = new List<int>();
        int groupCount = 0;
        for (int i = 0; i < 9; i++)
        {
            groupCheck.Add(board[groupCount][i]);
            groupCheck.Add(board[groupCount + 1][i]);
            groupCheck.Add(board[groupCount + 2][i]);
            if (groupCheck.Count() == 9)
            {
                if (groupCheck.Distinct().Count() != 9)
                    return false;
                if (groupCheck.Distinct().Count() == 9)
                {
                    groupCount += 3;
                    groupCheck.Clear();
                }
            }
        }
        int Count = 0;
        for (int i = 0; i < 9; i++)
        {
            colCheck.Add(board[i][Count]);
            rowCheck.Add(board[Count][i]);
            if (i == 8 && rowCheck.Distinct().Count() == 9 && colCheck.Distinct().Count() == 9)
            {
                if (Count < 8)
                {
                    i = -1;
                    colCheck.Clear();
                    rowCheck.Clear();
                }
                Count++;
                if (Count == 8 || rowCheck.Distinct().Count() == 9 && colCheck.Distinct().Count() == 9)
                    return true;
            }
        }
        return false;
    }
}
