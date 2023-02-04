int[,] array = new int[4,5];

Random rnd = new Random();
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(10));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "  ");
        Console.WriteLine();
}

Console.Write("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>4 || b>5)

Console.WriteLine("такого элемента нет");

else
{
var c = array.GetValue(a,b);
Console.WriteLine(c);
}