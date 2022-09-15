
Console.WriteLine("Введите количество чисел");
int col = Convert.ToInt32(Console.ReadLine());

int[] array = new int[col];

int count = 0;
for(int i=0; i<col; i++)
{
    Console.WriteLine($"Введите {i+1} число");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i]>0) count++;
}
Console.WriteLine($"Введено положительных чисел: {count}");




Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());

if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые одинаковы");
else if (k1 == k2) Console.WriteLine("Прямые паралельны");
else 
{
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точки пересечения: {x} {y}");
}