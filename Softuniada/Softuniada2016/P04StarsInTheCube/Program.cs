using System;
using System.Collections.Generic;
using System.Linq;

namespace P04StarsInTheCube
{
    class Program
    {
        static void Main(string[] args)
        {
            // tursi plius, napraven ot edni i sushti bukvi. Ako ima pred nego i zad nego (predna i zadna matrica) sushtata bukva
            //na mqsto centur --> imame 3D kub!!!. Napravi proverka dali pliusut ne e v purva ili vtora matrica ili izobshto zapochni ot vtora do posledna
            //matrica da tursish pliusove
            // matricite sa vinagi NxN v tazi zadacha. Oznachava che .length shte svurshi rabota
            // masiv ot matrici? Dali nqma da stane nepriqtno?
            int size = int.Parse(Console.ReadLine());
            List<Matrix> matrices = new List<Matrix>();
            int wat = 0;

            for (int i = 0; i < size; i++)
            {
                Matrix currentMatrix = new Matrix(size);
                matrices.Add(currentMatrix);
            }

            for (int row = 0; row < size; row++)
            {
                string[] currentInputRow = Console.ReadLine().Split('|');
                for (int matrixIndex = 0; matrixIndex < size; matrixIndex++)
                {
                    string currentRow = string.Concat(currentInputRow[matrixIndex].Split(' ', StringSplitOptions.RemoveEmptyEntries));
                    matrices[matrixIndex].SetMatrixRow(currentRow, row);
                }
            }



            //main ends here
        }


        //class ends here
    }

    public class Matrix {
        public char[,] Matrix1 { get; set; }
        public void SetMatrixRow(string letters, int row)
        {
            for (int col = 0; col < Math.Sqrt(Matrix1.Length); col++)
            {
                Matrix1[row, col] = letters[col];
            }
        }
        
        public Matrix(int size)
        {
            Matrix1 = new char[size, size];
        }

        //public bool SearchPlus()
        //{

        //}
    }
        
}
