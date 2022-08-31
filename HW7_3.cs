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
int count=0;
int j=0;
while (j<array.GetLength(1))
{
    int i=0;
    double result = 0;
    count++;
    while (i<array.GetLength(0))
    {
        result+=array[i,j];
        i++;
    }
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое по " + count+ " столбцу, равно "+ result/row );
    j++;
}
