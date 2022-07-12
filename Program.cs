Console.Write("Введите  координаты чисел: ");

void  Distance(float X1, float X2, float Y1, float Y2,
                float Z1, float Z2);

double Distance = Convert.ToDouble32(Console.ReadLine());
{
    double d = Math.Sqrt(Math.Pow(X2 - X1, 2) +
                         Math.Pow(Y2 - Y1, 2) +
                         Math.Pow(Z2 - Z1, 2));
                                   
    Console.WriteLine("Distance " + d);
    
}