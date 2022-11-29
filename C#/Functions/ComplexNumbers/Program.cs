// Simple complex numbers add and multiply functions

double[] firstNumber = { -1, 2 };
double[] secondNumber = { 1, -3 };
double[] sum = ComplexAdd(firstNumber, secondNumber);
double[] product = ComplexMultiply(firstNumber, secondNumber);

Console.WriteLine(ComplexString(firstNumber));
Console.WriteLine(ComplexString(secondNumber));
Console.WriteLine(ComplexString(sum));
Console.WriteLine(ComplexString(product));

double[] ComplexAdd(double[] number1, double[] number2)
{
    double[] sum = new double[2];
    sum[0] = number1[0] + number2[0];
    sum[1] = number1[1] + number2[1];
    return sum;
}

double[] ComplexMultiply(double[] number1, double[] number2)
{
    double[] product = new double[2];
    product[0] = number1[0] * number2[0] - number1[1] * number2[1];
    product[1] = number1[0] * number2[1] + number1[1] * number2[0];
    return product;
}

string ComplexString(double[] numToPrint)
{
    string delimiter = "+";
    if (numToPrint[1] < 0)
    {
        delimiter = "-";
    }
    return $"{numToPrint[0]} {delimiter} {Math.Abs(numToPrint[1])}i";
}