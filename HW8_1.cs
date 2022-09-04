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
int max=array[0,0];
for (int i=0; i<array.GetLength(0); i++)
{
    for (int j = 0 ; j<array.GetLength(1); j++)
    {
        for ( int k=0; k<array.GetLength(1); k++)
        {
            if (array[i,k]< array[i,j])
            {
                max=array[i,j];
                array[i,j]= array[i,k];
                array[i,k]= max;
                
            }
        }
    }
}
Console.WriteLine();
PrintArray(array);
