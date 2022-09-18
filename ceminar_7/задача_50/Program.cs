Console.WriteLine("введите номер строки");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int y = Convert.ToInt32(Console.ReadLine());
int [,] number = new int [5,8];
FillArrayNumber(number);

if (x > number.GetLength(0) || y > number.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {x} строки и {y} столбца равно {number[x-1,y-1]}");
}

PrintArray(number);

void FillArrayNumber(int[,] array)
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







