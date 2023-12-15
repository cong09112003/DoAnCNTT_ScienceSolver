using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science_Solver.AppModel
{
    public class MathematicalMatrix
    {
        // fields
        public int iMatrix_Colum;
        public int iMatrix_Row;
        public double[,] dMatrix;
        public int Matrix_Colum
        {
            get { return this.iMatrix_Colum; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                         $"{nameof(this.iMatrix_Colum)}:must be greater 0");
                this.iMatrix_Colum = value;
            }
        }
        public int Matrix_Row
        {
            get { return this.iMatrix_Row; }
            set
            {
                if (value < 0)
                    throw new ArgumentException(
                         $"{nameof(this.iMatrix_Row)}:must be greater 0");
                this.iMatrix_Row = value;
            }
        }
        public double[,] Matrix
        {
            get { return this.dMatrix; }
            set { this.dMatrix = value; }
        }
        public MathematicalMatrix()
        {
            this.Matrix_Row = 0;
            this.Matrix_Colum = 0;
            this.Matrix = new double[0, 0];
        }
        public MathematicalMatrix(int Matrix_Colum_, int Matrix_Row_, double[,] Matrix_)
        {
            this.Matrix_Colum = Matrix_Colum_;
            this.Matrix_Row = Matrix_Row_;
            this.Matrix = Matrix_;
        }
        ~MathematicalMatrix()
        { }
        // methods
        public void MathematicalMatrix_Input()
        {
            Console.Write("Row of the matrix:"); this.Matrix_Row = Convert.ToInt16(Console.ReadLine());
            Console.Write("Column of the matrix:"); this.Matrix_Colum = Convert.ToInt16(Console.ReadLine());
            // Initialize the new Matrix [row, column]
            this.Matrix = new double[this.Matrix_Row, this.Matrix_Colum];
            for (int i = 0; i < this.Matrix_Row; i++)
            {
                for (int j = 0; j < this.Matrix_Colum; j++)
                {
                    Console.Write("Matrix[" + i + "," + j + "]=");
                    this.Matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        public static MathematicalMatrix MathematicalMatrix_Transpose(MathematicalMatrix a)
        {
            MathematicalMatrix res = new MathematicalMatrix();
            res.Matrix_Row = a.Matrix_Colum;
            res.Matrix_Colum = a.Matrix_Row;
            res.Matrix = new double[res.Matrix_Row, res.Matrix_Colum];
            for (int i = 0; i < a.Matrix_Row; i++)
            {
                for (int j = 0; j < a.Matrix_Colum; j++)
                {
                    res.Matrix[j, i] = a.Matrix[i, j];
                }
            }
            return res;
        }
        public static Boolean Mathematics_MatricSquare(int row, int column)
        { return (row == column); }
        public void MathematicalMatrix_Output()
        {
            Console.WriteLine("Column of the matrix: " + this.Matrix_Colum);
            Console.WriteLine("Row of the matrix: " + this.Matrix_Row);
            for (int i = 0; i < this.Matrix_Row; i++)
            {
                for (int j = 0; j < this.Matrix_Colum; j++)
                {
                    Console.Write(this.Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            if (Mathematics_MatricSquare(this.Matrix_Row, this.Matrix_Colum))
                Console.WriteLine(" Determinant of the rectangle matrix:" + MathematicalMatrixDeterminant(this.Matrix, this.Matrix_Colum));
        }
        /* A= | a b c |
              | d e f |
              | g h i |
        -> a (e,f,h,i) b (d,f,g,i) c(d,f,g,i)
        */
        // Base on the recursive function-> finding dterminant of matrix
        public static double MathematicalMatrixDeterminant(double[,] matrix, int n)
        {
            return MathematicalMatrixDeterminant_temp(matrix, n, n);
        }
        public static double MathematicalMatrixDeterminant_temp(double[,] matrix, int n, int N)
        {
            double count_ = 0; // Initialize result
            if (n == 1)
                return matrix[0, 0];//To store cofactors
            double[,] temp = new double[N, N]; //To store sign multiplier
            double sign = 1; // Iterate for each element of first row
            for (int f = 0; f < n; f++)
            {
                getCofactor(matrix, temp, 0, f, n);// Getting Cofactor of mat[0][f]
                count_ += sign * matrix[0, f] * MathematicalMatrixDeterminant_temp(temp, n - 1, N);
                sign = -sign;// terms are to be added with alternative sign
            }
            return count_;
        }
        // Function to get cofactor of matrĩ [p][q] in temp[][].n-> size of matrix
        public static void getCofactor(double[,] mat, double[,] temp, int p, int q, int n)
        {
            int i = 0, j = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row != p && col != q)
                    {
                        temp[i, j++] = mat[row, col];
                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
        }

        public static void swap(double[,] matrix, int row_1, int row_2, int col)
        {
            for (int i = 0; i < col; i++)
            {
                // swap
                matrix[row_1, i] = matrix[row_1, i] * matrix[row_2, i];
                matrix[row_2, i] = matrix[row_1, i] / matrix[row_2, i];
                matrix[row_1, i] = matrix[row_1, i] / matrix[row_2, i];
            }
        }
        public static int Rank(double[,] matrix, int n)
        {

            int rank = n;
            for (int i = 0; i < rank; i++)
            {
                if (matrix[i, i] != 0)
                {
                    for (int j = 0; j < rank; j++)
                    {
                        if (j != i)
                        {
                            double multi = matrix[j, i] / matrix[i, j];
                            for (int k = 0; k < rank; k++)
                            {
                                matrix[j, k] -= (double)multi * matrix[i, k];
                            }
                        }
                    }
                }
                else
                {
                    bool reduce = true;
                    for (int t = i + 1; t < rank; t++)
                    {
                        if (matrix[t, i] != 0)
                        {
                            swap(matrix, i, t, rank);
                            reduce = false;
                            break;
                        }
                    }
                    if (reduce)
                    {
                        rank--;
                        for (int t = 0; t < rank; t++)
                        {
                            matrix[t, i] = matrix[i, rank];
                        }
                    }
                    i--;
                }
            }

            return rank;
        }
        public static bool operator ==(MathematicalMatrix Matrix_1, MathematicalMatrix Matrix_2)
        {
            return ((Matrix_1.Matrix_Row == Matrix_2.Matrix_Row) && (Matrix_1.Matrix_Colum == Matrix_2.Matrix_Colum));
        }
        public static bool operator !=(MathematicalMatrix Matrix_1, MathematicalMatrix Matrix_2)
        {
            return ((Matrix_1.Matrix_Row != Matrix_2.Matrix_Row) || (Matrix_1.Matrix_Colum != Matrix_2.Matrix_Colum));
        }
        public static MathematicalMatrix operator +(MathematicalMatrix matrix_1, MathematicalMatrix matrix_2)
        {
            if (matrix_1 == matrix_2)
            {
                MathematicalMatrix res = new MathematicalMatrix();
                res.Matrix = new double[matrix_1.Matrix_Row, matrix_1.Matrix_Colum];
                res.Matrix_Row = matrix_1.Matrix_Row;
                res.Matrix_Colum = matrix_1.Matrix_Colum;
                for (int i = 0; i < matrix_1.Matrix_Row; i++)
                {
                    for (int j = 0; j < matrix_1.Matrix_Colum; j++)
                        res.Matrix[i, j] = matrix_1.Matrix[i, j] + matrix_2.Matrix[i, j];
                }
                return res;
            }
            else return new MathematicalMatrix();

        }
        public static MathematicalMatrix operator -(MathematicalMatrix matrix_1, MathematicalMatrix matrix_2)
        {
            if (matrix_1 == matrix_2)
            {
                MathematicalMatrix res = new MathematicalMatrix();
                res.Matrix = new double[matrix_1.Matrix_Row, matrix_1.Matrix_Colum];
                res.Matrix_Row = matrix_1.Matrix_Row;
                res.Matrix_Colum = matrix_1.Matrix_Colum;
                for (int i = 0; i < matrix_1.Matrix_Row; i++)
                {
                    for (int j = 0; j < matrix_1.Matrix_Colum; j++)
                        res.Matrix[i, j] = matrix_1.Matrix[i, j] - matrix_2.Matrix[i, j];

                }
                return res;
            }
            else return new MathematicalMatrix();
        }
        // Adjoint (or Adjugate) of a matrix is the matrix obtained by taking the transpose of the cofactor matrix of a given square matrix is called its Adjoint or Adjugate matrix.
        // The Adjoint of any square matrix ‘A’ (say) is represented as Adj(A). 
        public static MathematicalMatrix MathematicalMatrixAdjoint(MathematicalMatrix matrix)
        {
            MathematicalMatrix adjoint = new MathematicalMatrix();
            if (Mathematics_MatricSquare(matrix.Matrix_Row, matrix.Matrix_Colum))
            {
                adjoint.Matrix = new double[matrix.Matrix_Row, matrix.Matrix_Colum];
                adjoint.Matrix_Row = matrix.Matrix_Row;
                adjoint.Matrix_Colum = matrix.Matrix_Colum;
                if (matrix.Matrix_Row == 1)
                {
                    adjoint.Matrix[0, 0] = 1;
                    return adjoint;
                }
                double sign = 1;
                double[,] temp = new double[matrix.Matrix_Row, matrix.Matrix_Row];
                for (int i = 0; i < matrix.Matrix_Row; i++)
                {
                    for (int j = 0; j < matrix.Matrix_Colum; j++)
                    {
                        getCofactor(matrix.Matrix, temp, i, j, matrix.Matrix_Row);
                        sign = ((i + j) % 2 == 0) ? 1 : -1;// sign of adj[j,i] positive if sum of row, and column indexes is even.
                        adjoint.Matrix[j, i] = (sign) * (MathematicalMatrix.MathematicalMatrixDeterminant(temp, matrix.Matrix_Row - 1));// Interchanging rows and columns to get the                                                                                            // transpose of the cofactor matrix                                                                                             // transpose of the cofactor matrix
                    }
                }
            }
            return adjoint;
        }
        // Function to calculate and store inverse, returns false if
        // matrix is singular
        public static MathematicalMatrix MathematicalMatrixInverse(MathematicalMatrix matrix)
        {
            MathematicalMatrix inverse = new MathematicalMatrix();
            if (Mathematics_MatricSquare(matrix.Matrix_Row, matrix.Matrix_Colum))
            {
                inverse.Matrix = new double[matrix.Matrix_Row, matrix.Matrix_Colum];
                inverse.Matrix_Row = matrix.Matrix_Row;
                inverse.Matrix_Colum = matrix.Matrix_Colum;
                // Find determinant of [,]A
                double det = MathematicalMatrix.MathematicalMatrixDeterminant(matrix.Matrix, matrix.Matrix_Row);
                if (det == 0) return inverse;
                // Find adjoint
                MathematicalMatrix adjoint = MathematicalMatrix.MathematicalMatrixAdjoint(matrix);
                //// Find Inverse using formula "inverse(A) = adj(A)/det(A)"
                for (int i = 0; i < matrix.Matrix_Row; i++)
                    for (int j = 0; j < matrix.Matrix_Colum; j++)
                        inverse.Matrix[i, j] = adjoint.Matrix[i, j] / det;
            }
            return inverse;
        }
        public static Boolean MathematicalMatrixBooleanMultiple(int matrix1_Column, int matrix2_row)
        {
            return (matrix1_Column == matrix2_row);
        }
        public static MathematicalMatrix operator *(MathematicalMatrix matrix1, MathematicalMatrix matrix2)
        {
            MathematicalMatrix matrix_res = new MathematicalMatrix();
            if (MathematicalMatrix.MathematicalMatrixBooleanMultiple(matrix1.Matrix_Colum, matrix2.Matrix_Row))
            {
                matrix_res.Matrix = new double[matrix1.iMatrix_Row, matrix2.Matrix_Colum];
                matrix_res.Matrix_Row = matrix1.Matrix_Row;
                matrix_res.Matrix_Colum = matrix2.Matrix_Colum;

                for (int i = 0; i < matrix1.Matrix_Row; i++)
                {
                    for (int j = 0; j < matrix2.Matrix_Colum; j++)
                    {
                        double temp = 0;
                        for (int k = 0; k < matrix1.Matrix_Colum; k++)
                        {
                            temp += matrix1.Matrix[i, k] * matrix2.Matrix[k, j];
                        }
                        matrix_res.Matrix[i, j] = temp;
                    }
                }
            }
            return matrix_res;
        }
        public static MathematicalMatrix operator /(MathematicalMatrix matrix1, MathematicalMatrix matrix2)
        {
            MathematicalMatrix matrix_res = new MathematicalMatrix();
            matrix_res = MathematicalMatrix.MathematicalMatrixInverse(matrix2) * matrix1;
            return matrix_res;
        }
    }
}
