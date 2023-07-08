//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool Check (int n, int m, int q)
{
    if (n < 1 || m < 1 || q < 1)
    {
        System.Console.WriteLine("Число строк столбцов и слоев массива не может быть меньше 1");
        return false;
    }
    return true;
}

int [,,] Fill(int n, int m, int q)
{
    int [,,] arr = new int [n,m,q];
    Random rand = new Random();
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                {
                    arr[i,j,k] = rand.Next(10,100);
                }
            }
        }
    }
    return arr;
}

void Print(int [,,] array)
{   
    for (int q = 0; q < array.GetLength(2); q++)
    {
        for (int n = 0; n < array.GetLength(0); n++)
        {
            for (int m = 0; m < array.GetLength(1); m++)
            {
                System.Console.Write($"{array[n,m,q]} ({n},{m},{q}) ");
            }
            System.Console.WriteLine();
        }
    }
}

bool Result (int [,,] matrix, int [,,] copy)
{
    for (int q = 0; q < matrix.GetLength(2); q++)
    {
        for (int n = 0; n < matrix.GetLength(0); n++)
        {
            for (int m = 0; m < matrix.GetLength(1); m++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    for (int i = 0; i < copy.GetLength(0); i++)
                    {
                        for (int j = 0; j < copy.GetLength(1); j++)
                        { 
                            if (i == n && j == m && k == q)
                            {
                                continue;
                            }
                            if (copy[i,j,k] == matrix[n,m,q])
                            {
                                System.Console.WriteLine("Есть совпадающие значения элементов матрицы, запустите программу снова");
                                System.Console.WriteLine($"{copy[i,j,k]} -> {i},{j},{k} and {matrix[n,m,q]} -> {n},{m},{q}");
                                return false;
                            }
                        }

                    }
                }
            }
        }

    }
    return true;
}

//----------------------------------------------------------------
int n = ReadInt("Введите число строк трехмерного массива(X): ");
int m = ReadInt("Введите число столбцов трехмерного массива(Y): ");
int q = ReadInt("Введите число слоев трехмерного массива(Z): ");

if(Check(n, m, q))
{
    int [,,] matrix = Fill(n,m,q);
    int [,,] copy = matrix;
    Print(matrix);
    if (Result (matrix, copy))
    {
        System.Console.WriteLine();
    }
}