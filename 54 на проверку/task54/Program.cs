//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


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
            array[i, j] = rand.Next(0, 101);
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

int [,] Sort (int [,] arr)
{

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sortSize = 0;
            while(sortSize < arr.GetLength(1))
            {
                int j = 0;
                while (j < arr.GetLength(1) - 1 - sortSize)
                {
                        if (arr[i,j] < arr[i,j + 1])
                        {
                            int boost = arr[i,j];
                            arr[i,j] = arr[i,j + 1];
                            arr[i,j + 1] = boost;
                        
                        }
                    j++;
                }
                sortSize++;
            
            }
        }
        

    return arr;
}

bool Check (int n, int m)
{
    if (n < 0 || m < 0)
    {
        System.Console.WriteLine("Число строк и столбцов не может быть меньше 0");
        return false;
    }
    return true;
}

//-------------------------------------------------------------
int n = ReadInt("Введите число строк: ");
int m = ReadInt("Введите число столбцов: ");

if(Check(n,m))
{
    int [,] matrix = FillArray (n, m);
    PrintArray(matrix);
    System.Console.WriteLine();
    System.Console.WriteLine("Упорядоченный массив:");
    int [,] sorted = Sort(matrix);
    PrintArray(sorted);
}

