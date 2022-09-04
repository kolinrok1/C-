int ReadIn (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (int[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
          for (int j=0; j< array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArray (int[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " "); 
        }
        Console.WriteLine();
    }
}

int row = ReadIn("Введите количесво строк");
int col = ReadIn("Введите количество столбцов");
int [,] array = new int [row,col];
FillArray(array);
PrintArray(array);
int minI=0;
int result = 0;
int maxResult=0;

    for (int i=0; i<array.GetLength(0); i++)
    {
          for (int j=0; j< array.GetLength(1); j++)
        {
            result+=array[i,j];
        }
        if (maxResult>result)
        {
            maxResult=result;
            minI=i;
        }
    }
Console.WriteLine($"Строка с нименешей суммой элементов {minI}");
