//Задача 56: Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой элементов.
int ReadInt (string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] FillArray (int n, int m)
{
    int [,] array = new int [n,m];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-100, 101);
        }
    }
    return array;
}

void PrintArray (int [,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i,j] + "\t");
        }
    System.Console.WriteLine();
    }
}

void PrintAr (int [] arr)
{
for (int i = 0; i < 1; i++)
    {
        System.Console.Write(string.Join(", ", arr));
    }
}

bool Check (int n, int m)
{
    if (n == m || n < 1 || m < 1)
    {
        System.Console.Write("Число строк и столбцов не должно совпадать и их значение ");
        System.Console.WriteLine("должно быть больше нуля. Введите число строк и столбцов снова");
        return false;
    }
    return true;
}

int [] Resultat (int [,] arr)
{
    int [] newarr = new int [arr.GetLength(0)];
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (k == i)
                {
                    newarr[k] += arr [i,j];
                }
            }
        }
    }
    return newarr;
}

void Answer(int [] res)
{
    int b = 0;
    int min = res[0];
    for (int i = 1; i < res.Length; i++)
    {
        if (min > res[i])
        {
            min = res[i];
            b = i + 1;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Строка {b} - строка с наименьшей суммой элементов: {min}");
}

//-------------------------------------------------------------
System.Console.WriteLine("Число строк и столбцов не должно совпадать");
int n = ReadInt("Введите число строк: ");
int m = ReadInt("Введите число столбцов: ");

if (Check(n, m))
{
    int [,] matrix = FillArray (n, m);
    PrintArray(matrix);
    System.Console.WriteLine();
    int [] newar = Resultat(matrix);
    PrintAr(newar);
    Answer(newar);
}