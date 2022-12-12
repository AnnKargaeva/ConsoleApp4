int m, n;
Console.Write($"Введите m размерность массива: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите n размерность массива: ");
int.TryParse(Console.ReadLine(), out n);

int[,] array = new int[m + 1, n + 1];

for (int i = 0; i < array.GetLength(0); i++)// Заполнение крайнего левого столбца
    array[i, 0] = i;
for (int i = 0; i < array.GetLength(1); i++)// Заполнение крайней верхней строки
    array[0, i] = i;


for (int i = 1; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1); j++)
    {
        array[i, j] = i * j;
    }
}

PrintArray(array);

foreach (var i in array)
    Console.Write($"{i} ");

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,3}", arr[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}