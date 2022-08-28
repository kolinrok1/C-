
Console.WriteLine("Введите числа через запитую");
string size =Console.ReadLine();
string [] array = new string [size.Length];
int sizeArrayInt = 0;
int count=0;
for ( int i=0; i< size.Length; i++)
{
    if (size[i]!=',') 
    {
        array[sizeArrayInt]= array[sizeArrayInt]+size[i];
        array[sizeArrayInt]= Convert.ToString(array[sizeArrayInt]);
    }
    else sizeArrayInt++;

}
int [] arrayInt = new int [sizeArrayInt+1];
for (int i=0; i<sizeArrayInt+1; i++)
{
    arrayInt[i]= Convert.ToInt32(array[i]);
        if (arrayInt[i]>0) count++;
}
Console.WriteLine();
Console.WriteLine(count);
