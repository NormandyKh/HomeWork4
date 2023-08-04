namespace HomeWork4.Matrix
{
    internal class Matrix
    {
        private int[,] data;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new int[Rows, Columns];
        }

        //Индексатор для доступа к элементам
        public int this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        //перегрузка +
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Матрицы имеют разный размер.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        //перегрузка -
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new ArgumentException("Матрицы имеют разный размер.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        //перегрузка * матриц друг на друга
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Rows)
                throw new ArgumentException("Количество столбцов первой матрицы должно быть равно количеству рядов второй матрицы.");

            Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.Columns; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        //перегрузка * матрицы на число
        public static Matrix operator *(Matrix matrix, int scalar)
        {
            Matrix result = new Matrix(matrix.Rows, matrix.Columns);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }

        //перегрузка == матриц друг на друга
        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (ReferenceEquals(matrix1, matrix2))
                return true;

            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                return false;

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }

            return true;
        }

        //перегрузка !=
        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }

        //Перегрузка Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Matrix other = (Matrix)obj;
            return this == other;
        }
    }
}
