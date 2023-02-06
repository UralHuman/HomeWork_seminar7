Console.Write("Введите размер матрицы n : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размер матрицы m : ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];

Random rand = new Random();

int[] summ = new int[m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(0, 10);
                    
    }
}
Console.WriteLine("Матрица:");
System.Console.WriteLine();

for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++)
    {
    Console.Write(matrix[i, j] + " "); 
    summ[i] += matrix[j, i];     
    } 
    Console.WriteLine();
}
Console.WriteLine();
System.Console.WriteLine("Средне арифмитические значения элементов столбцов: ");
System.Console.WriteLine();
foreach (double elem in summ)
{
    Console.WriteLine(elem/m); 
}
 
        
    