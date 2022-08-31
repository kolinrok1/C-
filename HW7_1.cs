int ReadIn (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (double[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        double dr = 0;
                for (int j=0; j< array.GetLength(1); j++)
        {
            dr= new Random().NextDouble() *10;
            array[i,j]= Math.Round(dr,2);
        }
    }
}

void PrintArray (double[,]array)
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
double [,] array = new double [row,col];
FillArray(array);
PrintArray(array);
