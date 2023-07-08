//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

//Эту задачу мне не удалось решить. Полагаю, что она решается через рекурсию
//Ниже прилагаю одну из моих попыток выполнить задание

int [,] Func(int [,] array, int row, int col, int k)
{

            if (array[row,col] == 0)
            {
                array[row,col] = k;
                k++;
                Func([row, col+1]);
                Func([row+1, col]);
                Func([row, col-1]);
                Func([row-1, col]);
            }
        return array;
}

void Print (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

//------------------------------------

int [,] array = new int [4,4];
int [,] arr = Func(array, 0, 0, 1);
Print(arr);