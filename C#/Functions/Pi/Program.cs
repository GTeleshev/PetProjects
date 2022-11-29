// Pi calculation using Nilakantha Series π=3+4/(2·3·4)-4/(4·5·6)+4/(6·7·8)-4/(8·9·10)+4/(10·11·12)-4/(12·13·14) ⋯

Console.WriteLine(Picalc(1000000));

decimal Picalc(int number_of_iterations = 1)
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
