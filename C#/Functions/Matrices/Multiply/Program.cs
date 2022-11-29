/*Matrices multiplication*/
int sogl = 4;
double[,] firstMatrix = GetArray(4, sogl, 1, 5);
double[,] secondMatrix = GetArray(sogl, 1, 1, 5);
double[,] multi = MatrixMultiply(firstMatrix, secondMatrix);
Console.WriteLine("First matrix");
PrintArray(firstMatrix);
Console.WriteLine("Second matrix");
PrintArray(secondMatrix);
Console.WriteLine("Result of multiplication");
PrintArray(multi);

double[,] MatrixMultiply(double[,] Matrix1, double[,] Matrix2)
{
    int rows1 = Matrix1.GetLength(0);
    int columns1 = Matrix1.GetLength(1);
    int rows2 = Matrix2.GetLength(0);
    int columns2 = Matrix2.GetLength(1);
    double[,] multipliedMatrix = new double[rows1, columns2];
    double sumij = 0;
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            sumij = 0;
            for (int r = 0; r < columns1; r++)
            {
                sumij = sumij + Matrix1[i, r] * Matrix2[r, j];
            }
            multipliedMatrix[i, j] = sumij;
        }
    }
    return multipliedMatrix;
}

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int interimVar = 0;
    if (minValue > maxValue)
    {
        interimVar = maxValue;
        maxValue = minValue;
        minValue = interimVar;
    }

    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int rand = new Random().Next(minValue, maxValue + 1);
            result[i, j] = Convert.ToDouble(rand);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}