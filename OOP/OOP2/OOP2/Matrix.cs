using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Matrix<T> where T : struct, IComparable, IComparable<T>, IFormattable, IEquatable<T>, IConvertible
    {
        private T[,] matrixElements;

        private int rows = 0;
        public int Rows
        {
            get { return this.rows; }
        }

        private int columns = 0;
        public int Columns
        {
            get { return this.columns; }
        }

        public Matrix(int _rows, int _columns)
        {
            if(_rows <= 0 || _columns <= 0)
            {
                throw new ArgumentException("The dimensions of matrix must be positive and greater than 0.");
            }
            else
            {
                this.rows = _rows;
                this.columns = _columns;
                matrixElements = new T[rows, columns];
            }
        }

        public Matrix(T[,] elements)
        {
            if(elements == null || elements.GetLength(0) == 0 || elements.GetLength(1) == 0)
            {
                throw new ArgumentException("The array must contain at least one element.");
            }
            else
            {
                this.rows = elements.GetLength(0);
                this.columns = elements.GetLength(1);
                matrixElements = (T[,])elements.Clone();
            }
        }

        public T this[int row, int column]
        {
            get 
            {
                if (row > this.rows || row < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} exceeded the bounds of the matrix.", row));
                }
                else if (column > this.columns || column < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} exceeded the bounds of the matrix.", column));
                }
                else if(row > this.rows || row < 0 && column > this.columns || column < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("The indexers {0} and {1} exceeded the bounds of the matrix.", row, column));
                }
                else
                {
                    return matrixElements[row, column];
                }
            }
            set 
            {
                if (row > this.rows || row < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} exceeded the bounds of the matrix.", row));
                }
                else if (column > this.columns || column < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("The index {0} exceeded the bounds of the matrix.", column));
                }
                else if (row > this.rows || row < 0 && column > this.columns || column < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("The indexers {0} and {1} exceeded the bounds of the matrix.", row, column));
                }
                else
                {
                    matrixElements[row, column] = value;
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> M1, Matrix<T> M2)
        {            
            if(M1.Rows == M2.Rows && M1.Columns == M2.Columns)
            {
                T[,] sumMatrix = new T[M1.Rows, M1.Columns];

                for (int i = 0; i < M1.rows; i++)
                {
                    for (int j = 0; j < M1.Columns; j++)
                    {
                        sumMatrix[i, j] = (dynamic)M1[i, j] + (dynamic)M2[i, j];
                    }
                }
                return new Matrix<T>(sumMatrix);
            }
            else
            {
                throw new ArgumentException("The matrices must have equal rows and columns!");
            }
        }

        public static Matrix<T> operator -(Matrix<T> M1, Matrix<T> M2)
        {
            if(M1.Rows == M2.Rows && M1.Columns == M2.Columns)
            {
                T[,] subsstrMatrix = new T[M1.Rows, M1.Columns];

                for (int i = 0; i < M1.rows; i++)
                {
                    for (int j = 0; j < M1.Columns; j++)
                    {
                        subsstrMatrix[i, j] = (dynamic)M1[i, j] - (dynamic)M2[i, j];
                    }
                }
                return new Matrix<T>(subsstrMatrix);
            }
            else
            {
                throw new ArgumentException("The matrices must have equal rows and columns!");
            }
        }

        public static Matrix<T> operator *(Matrix<T> M1, Matrix<T> M2)
        {
            if(M1.Columns == M2.Rows)
            {
                T[,] prodMatrix = new T[M1.Rows, M2.Columns];

                for(int i = 0; i < M1.Rows; i++)
                {
                    for (int j = 0; j < M2.Columns; j++)
                    {
                        for(int k = 0; k < M1.Columns; k++)
                        {
                            prodMatrix[i, j] += (dynamic)M1[i, k] + (dynamic)M2[k, j]; 
                        }
                    }
                }
                return new Matrix<T>(prodMatrix);
            }
            else
            {
                throw new ArgumentException("The columns of the first matrix must be equals to the rows of the second matrix!"); 
            }
        }

        public static bool operator true(Matrix<T> M)
        {
            if(M == null || M.Rows == 0 || M.columns == 0)
            {
                throw new ArgumentException("Invalid matrix.");
            }

            for(int i = 0; i < M.Rows; i++)
            {
                for(int j = 0; j < M.Columns; j++)
                {
                    if(!M[i, j].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> M)
        {
            if (M == null || M.Rows == 0 || M.columns == 0)
            {
                throw new ArgumentException("Invalid matrix.");
            }

            for (int i = 0; i < M.Rows; i++)
            {
                for (int j = 0; j < M.Columns; j++)
                {
                    if (!M[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Columns; j++)
                {
                    str += matrixElements[i, j].ToString() + " ";
                }
                str += Environment.NewLine;
            }
            return str;
        }
    }
}
