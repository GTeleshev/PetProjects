// See https://aka.ms/new-console-template for more information


Console.WriteLine("Quaternion Class Check");
Quaternion quater = new Quaternion(1, 2, 3, -4);
// string name = Quaternion.PrintQ(quater);
Console.WriteLine(quater.a);
Console.WriteLine(quater.b);
Console.WriteLine(quater.c);
Console.WriteLine(quater.d);
// Console.WriteLine(quater.PrintQ());
Console.WriteLine(quater.PrintQ());
Console.ReadLine();
Quaternion quater2 = new Quaternion(1, 3, 5, 6);
Console.WriteLine(quater2.PrintQ());
Quaternion quater3 = quater.QuatAdd(quater2);
Console.WriteLine(quater3.PrintQ());
Quaternion quater4 = quater.MultiplyQuat(quater2);
Console.WriteLine(quater4.PrintQ());
public class Quaternion
{
    public double a { get; set; }
    public double b { get; set; }
    public double c { get; set; }
    public double d { get; set; }

    public Quaternion()
    {
        this.a = 0;
        this.b = 0;
        this.c = 0;
        this.d = 0;
    }

    public Quaternion(double A, double B, double C, double D)
    {
        this.a = A;
        this.b = B;
        this.c = C;
        this.d = D;
    }

    public string PrintQ()
    {
        string fs = "+";
        string ss = "+";
        string ts = "+";
        if (this.b < 0)
        {
            fs = "-";
        }
        if (this.c < 0)
        {
            ss = "-";
        }
        if (this.d < 0)
        {
            ts = "-";
        }
        double absB = Math.Abs(this.b);
        double absC = Math.Abs(this.c);
        double absD = Math.Abs(this.d);
        string quaternString = $"{this.a} {fs} {absB}i {ss} {absC}j {ts} {absD}k";
        return quaternString;
    }

    public Quaternion QuatAdd(Quaternion quat2)
    {
        Quaternion sumQuat = new Quaternion(this.a + quat2.a, this.b + quat2.b, this.c + quat2.c, this.d + quat2.d);
        return sumQuat;
    }

    public Quaternion MultiplyQuat(Quaternion quat2)
    {
        Quaternion productQuat = new Quaternion();
        double[,] firstMatrix = {
            {this.a, -this.b, -this.c, -this.d},
            {this.b, this.a, -this.d, this.c},
            {this.c, this.d, this.a, -this.b},
            {this.d, -this.c, this.b, this.a}
        };
        double[,] secondMatrix = {
            {quat2.a},
            {quat2.b},
            {quat2.c},
            {quat2.d}
        };
        double[,] productMatrix = MatrixMultiply(firstMatrix, secondMatrix);
        productQuat.a = productMatrix[0,0];
        productQuat.b = productMatrix[1,0];
        productQuat.c = productMatrix[2,0];
        productQuat.d = productMatrix[3,0];
        
        return productQuat;
    }
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
}