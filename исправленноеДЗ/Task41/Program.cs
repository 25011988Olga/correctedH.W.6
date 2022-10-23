Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите эти элементы : ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0; 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше 0: {count}");