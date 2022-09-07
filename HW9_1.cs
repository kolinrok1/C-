void ArrRandom (int [] array)
{
    int count = array.Length;
    for ( int i=0; i<array.Length; i++)
    {
        array [i]= count;
        count--;
    }
}

void PrintArray (int [] array)
{
    for (int i=0; i<array.Length;i++)
    {
        if (i!=array.Length-1) {Console.Write(array[i]+ ",");}
        else {Console.Write(array[i]);}
    }
}


Console.WriteLine("Введите число");
int size =Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
ArrRandom(array);
PrintArray(array);
