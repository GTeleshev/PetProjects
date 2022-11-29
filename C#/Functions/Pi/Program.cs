// Pi calculation using Nilakantha Series π=3+4/(2·3·4)-4/(4·5·6)+4/(6·7·8)-4/(8·9·10)+4/(10·11·12)-4/(12·13·14) ⋯

Console.WriteLine(PiCalc(1000000));
Console.WriteLine(PiCalcPrecision(20));

decimal PiCalc(int number_of_iterations = 1)
{
    decimal piOut = 3.0M;
    decimal add = 0M;
    decimal sign = 1M;
    for (int i = 1; i <= number_of_iterations; i++)
    {
        decimal doubleI = 2 * i;
        decimal seq = 4 / (doubleI * (doubleI + 1) * (doubleI + 2)) * sign;
        add = add + seq;
        sign = sign * (-1);        
    }
    return piOut + add;
}

string PiCalcPrecision(int precision = 1)
{
    decimal piOut = 3.0M;
    decimal add = 0M;
    decimal sign = 1M;
    int i = 1;
    decimal add1 = 0.1M;
    decimal add2 = 0M;
    while (Math.Round(Math.Abs(add1 - add2), precision) > 0)
    {
        add1 = add2;
        decimal doubleI = 2 * i;
        decimal seq = 4 / (doubleI * (doubleI + 1) * (doubleI + 2)) * sign;
        add2 = add2 + seq;
        sign = sign * (-1);
        i++;        
    }
    string outPutString = $"Pi up to {precision} decimals: {Math.Round((piOut + add2), precision)}, number of iterations: {i}";
    return outPutString;
}
