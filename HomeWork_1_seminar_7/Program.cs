System.Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];

Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double a = genRndDouble(-10,10);
        array[i,j] = a;
        System.Console.Write($"{Math.Round(array[i, j],2)} ");
    }
    System.Console.WriteLine();
}

double genRndDouble (int a, int b)
{
   
    double rndDouble = a + rnd.NextDouble() * (b-a);

    return rndDouble;
}
