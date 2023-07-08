//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int ReadInt (string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] MatrixA (int n, int m)
{
    int [,] array = new int [n,m];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
    return array;
}

int [,] MatrixB (int k, int q)
{
    int [,] array = new int [k,q];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
    return array;
}

int [,] MatrixC (int [,] matrA, int [,] matrB)
{
    int [,] array = new int [matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
            {       
                for (int k = 0; k < matrB.GetLength(0); k++)
                    {
                        array[i,j] += matrA[i,k]*matrB[k,j];
                    }
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

bool Check(int n, int m, int q)
{
    if (n < 1 || m < 1 ||  q < 1)
    {
        System.Console.WriteLine("Число строк и столбцов матрицы не может быть меньше 1.");
        System.Console.WriteLine("Попробуйте ввести значения снова");
        return false;
    }
    return true;
}

//-------------------------------------------------------------

int n = ReadInt("Введите число строк первой матрицы: ");
int m = ReadInt("Введите число столбцов первой матрицы: ");
System.Console.WriteLine("Число столбцов первой матрицы равно числу строк второй матрицы");
System.Console.WriteLine($"В нашем случае число строк второй матрицы -> {m}");
int k = m;
int q = ReadInt("Введите число столбцов второй матрицы: ");

if (Check(n,m,q))
{
    System.Console.WriteLine("Первая матрица:");
    int [,] matrA = MatrixA (n, m);
    PrintArray(matrA);
    System.Console.WriteLine();
    System.Console.WriteLine("Вторая матрица:");
    int [,] matrB = MatrixB (k, q);
    PrintArray(matrB);
    System.Console.WriteLine();
    System.Console.WriteLine("Результат произведения матриц:");
    int [,] matrC = MatrixC (matrA, matrB);
    PrintArray(matrC);
}

 
