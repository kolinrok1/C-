int ArrRandom (int [] array, int count)
{
    int sum=0;
        for ( int i=0; i<array.Length; i++)
    {
        array [i]+= count--;
        //count--;
        sum+=array[i];
    }
    return sum;
}



Console.WriteLine("Введите число M");
int sizeM =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int sizeN =Convert.ToInt32(Console.ReadLine());
int [] array = new int [sizeN-sizeM+1];
Console.WriteLine (ArrRandom(array, sizeN));

