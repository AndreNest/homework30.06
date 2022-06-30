// 21

double coub (double a1, double b1, double c1, double a2, double b2, double c2)
{
    double result = 0;
    result = Math.Sqrt((a1-a2)*(a1-a2)+( b1- b2)*(b1-b2)+(c1-c2)*(c1-c2));
    return result;
}
double sum = coub(3,6,8, 2, 1, -7);
Console.WriteLine(sum);
