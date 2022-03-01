//  Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.


Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine();
Console.WriteLine("Исходная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
   Console.WriteLine();
}


for (int i = 0; i < m; i++)
{
    
    for (int j = 0; j < n; j++)
    {
        int maximum = array[i, j];
        for (int k = j; k < n; k++)
        {
            if (array[i, k] > maximum)
            {
                maximum = array[i, k];
                array[i,k] = array[i,j];
                array[i,j] = maximum;

            }
        }
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
for (int i = 0; i < m; i++)
{
    int minimal = array[i, 0];
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

  
