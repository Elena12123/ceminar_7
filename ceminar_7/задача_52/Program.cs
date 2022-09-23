Console.WriteLine("введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] number = new int[n, m];
FillArray(number);

for (int j = 0; j < number.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        avarage = (avarage + number[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ",2);
}
Console.WriteLine();
PrintArray(number);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 100);
            }   
        }
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
       
        Console.WriteLine(""); 
    }
}

