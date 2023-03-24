int[,] matrix = {
                { 5, 2, 4, 6 },
                { 1, 6, 3, 7 },
                { 8, 7, 9, 3 }
                };

int minRow = 0;
int minCol = 0;
int minValue = matrix[0, 0];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < minValue)
        {
            minValue = matrix[i, j];
            minRow = i;
            minCol = j;
        }
    }
}

int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

for (int i = 0, newRow = 0; i < matrix.GetLength(0); i++)
{
    if (i != minRow)
    {
        for (int j = 0, newCol = 0; j < matrix.GetLength(1); j++)
        {
            if (j != minCol)
            {
                newMatrix[newRow, newCol] = matrix[i, j];
                newCol++;
            }
        }
        newRow++;
    }
}

Console.WriteLine("Новая матрица после удаления строки и столбца с минимальным элементом:");
for (int i = 0; i < newMatrix.GetLength(0); i++)
{
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
        Console.Write(newMatrix[i, j] + " ");
    }
    Console.WriteLine();
}