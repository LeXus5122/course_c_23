int[,] matrixA = {
                {2, 4},
                {3, 2}
            };

int[,] matrixB = {
                {3, 4},
                {3, 3}
            };

int rowsA = matrixA.GetLength(0);
int colsA = matrixA.GetLength(1);
int rowsB = matrixB.GetLength(0);
int colsB = matrixB.GetLength(1);


int[,] resultMatrix = new int[rowsA, colsB];

for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < colsB; j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < colsA; k++)
        {
            resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

Console.WriteLine("Результирующая матрица:");
for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < colsB; j++)
    {
        Console.Write(resultMatrix[i, j] + " ");
    }
    Console.WriteLine();
}