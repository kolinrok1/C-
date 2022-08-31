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
string numberRow = "0";
string numberCol = "0";
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите номер элемента");
string numbA= Console.ReadLine();
if (numbA.Length>2 || numbA.Length==1)
{
 Console.WriteLine("Введите корректное число");
return;
}
numberRow= Convert.ToString (numbA[0]) ;
numberCol= Convert.ToString (numbA[1]) ;
row = Convert.ToInt32(numberRow);
col=Convert.ToInt32(numberCol);
if (row>array.GetLength(0) || col>array.GetLength(1)) 
{
    Console.WriteLine("Такого элемента нет в массиве");
    return;
}
    Console.WriteLine();
    Console.Write("Ваш элемент:");
    Console.Write(array[row-1,col-1]);



