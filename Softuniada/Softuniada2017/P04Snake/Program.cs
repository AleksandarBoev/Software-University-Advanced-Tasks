using System;
using System.Linq;

namespace P04Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubeSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[cubeSize, cubeSize * cubeSize]; // vhod 3 -> 3 reda i 9 stulba, kakto e v primera

            //saving data
            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < cubeSize; row++)
            {
                string currentLine = string.Concat(Console.ReadLine().Split('|').Select(s => s.Trim()).ToArray());
                for (int col = 0; col < currentLine.Length; col++)
                {
                    matrix[row, col] = currentLine[col]; // vseki input red e edin red ot matricata i tuk se prisvoqva
                    if (currentLine[col] == 's')
                    {
                        currentCol = col;
                        currentRow = row;
                    }
                }
            }

            //executing commands
            bool gameOver = false;
            int points = 0;
            string currentDirection = Console.ReadLine();

            while (currentDirection != "end" && !gameOver)
            {
                string[] input = Console.ReadLine().Split();
                if (gameOver) // ignore all folowing commands (but still read them)
                {
                    continue;
                }
                string newDirection = input[0];
                //int newRow = currentRow; // ne znam dali shte mi trqbva

                int steps = int.Parse(input[2]);

                switch (currentDirection)
                {
                    case "up":
                        for (int i = 0; i < steps; i++)
                        {
                            Up(cubeSize, ref currentRow, ref currentCol);
                            if (!IsInside(cubeSize, cubeSize * cubeSize, currentRow, currentCol))
                            {
                                gameOver = true;
                                break;
                            }
                            IncreasePoints(matrix, currentRow, currentCol, ref points);
                        }

                        break;

                    case "down":
                        for (int i = 0; i < steps; i++)
                        {
                            Down(cubeSize, ref currentRow, ref currentCol);
                            if (!IsInside(cubeSize, cubeSize * cubeSize, currentRow, currentCol))
                            {
                                gameOver = true;
                                break;
                            }
                            IncreasePoints(matrix, currentRow, currentCol, ref points);
                        }
                        break;

                    case "forward":
                        for (int i = 0; i < steps; i++)
                        {
                            Forward(ref currentRow, ref currentCol);
                            if (!IsInside(cubeSize, cubeSize * cubeSize, currentRow, currentCol))
                            {
                                gameOver = true;
                                break;
                            }
                            IncreasePoints(matrix, currentRow, currentCol, ref points);
                        }
                        break;

                    case "backward":
                        for (int i = 0; i < steps; i++)
                        {
                            Backward(ref currentRow, ref currentCol);
                            if (!IsInside(cubeSize, cubeSize * cubeSize, currentRow, currentCol))
                            {
                                gameOver = true;
                                break;
                            }
                            IncreasePoints(matrix, currentRow, currentCol, ref points);
                        }
                        break;

                    case "left":
                        for (int i = 0; i < steps; i++)
                        {
                            Left(ref currentRow, ref currentCol);
                            if (!IsInside(cubeSize, cubeSize * cubeSize, currentRow, currentCol))
                            {
                                gameOver = true;
                                break;
                            }
                            IncreasePoints(matrix, currentRow, currentCol, ref points);
                        }
                        break;

                    case "right":
                        for (int i = 0; i < steps; i++)
                        {
                            Right(ref currentRow, ref currentCol);
                            if (!IsInside(cubeSize, cubeSize * cubeSize, currentRow, currentCol))
                            {
                                gameOver = true;
                                break;
                            }
                            IncreasePoints(matrix, currentRow, currentCol, ref points);
                        }
                        break;
                }

                currentDirection = newDirection;
                //while ends here
            }

            Console.WriteLine($"Points collected: {points}");// , Final coordinates: {currentRow}, {currentCol}");
            if (gameOver)
            {
                Console.WriteLine("The snake dies.");
            }

            //main ends here
        }

        static void IncreasePoints(char[,] matrix, int currentRow, int currentCol, ref int points)
        {
            if (matrix[currentRow, currentCol] == 'a')
            {
                points++;
                matrix[currentRow, currentCol] = 'o';
            }
        }

        static bool IsInside(int matrixRows, int matrixCols, int row, int col)
        {
            if (row < 0 || row > matrixRows - 1 || col < 0 || col > matrixCols - 1)
            {
                return false;
            }
            return true;
        }

        //up, down, forward, backward, left, right
        static void Up(int matrixSize, ref int row, ref int col)
        {
            col -= matrixSize;
        }

        static void Down(int matrixSize, ref int row, ref int col)
        {
            col += matrixSize;
        }

        static void Forward(ref int row, ref int col)
        {
            row--;
        }

        static void Backward(ref int row, ref int col)
        {
            row++;
        }

        static void Left(ref int row, ref int col)
        {
            col--;
        }

        static void Right(ref int row, ref int col)
        {
            col++;
        }

        //class ends here
    }
}
