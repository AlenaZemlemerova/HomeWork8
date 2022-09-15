void Exercice54()
{
    // Задача 54: Задайте двумерный массив. 
    //Напишите программу, которая упорядочит по убыванию 
    //элементы каждой строки двумерного массива.
    int[,] array = new int[3,4];
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);  
    FillArray(array);
    PrintArray(array); 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int t = 0; t < columns; t++)
            {
                if(array[i,j] > array[i,t])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,t];
                    array[i,t] = temp;
                }
            }        
        }
    }
    Console.WriteLine();
    PrintArray(array);
}

void Exercice56()
{
    //Задача 56: Задайте прямоугольный двумерный массив. 
    //Напишите программу, которая будет находить строку 
    //с наименьшей суммой элементов.

    int[,] array = new int[4,4];
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);  
    FillArray(array);
    PrintArray(array);
    int sum = 0;
    int[] arraySum = new int[rows];
    for(int i = 0; i < rows; i++)
    {
        sum = 0;
        for(int j = 0; j < columns; j++)
        {
            sum += array[i,j];                
        }
        arraySum[i] = sum;
    }
    Console.WriteLine();
    int indMinSum = 0;
    for(int i = 0; i < arraySum.Length; i++)
    {
        for(int j = 0; j < arraySum.Length; j++)
        {
            if(arraySum[i] < arraySum[j]) indMinSum = i;
        }
    } 
    Console.WriteLine($"Строка с минимальной суммой элементов №{indMinSum + 1} с суммой {arraySum[indMinSum]}");
}

void Exercice58()   //Не могу составить формулу для произведения матриц
{
    //Задача 58: Задайте две матрицы. Напишите программу, 
    //которая будет находить произведение двух матриц.
    int[,] array1 = new int[2,2];
    int rows1 = array1.GetLength(0);
    int columns1 = array1.GetLength(1);  
    FillArray(array1);
    PrintArray(array1);
    Console.WriteLine();

    int[,] array2 = new int[2,2];
    int rows2 = array2.GetLength(0);
    int columns2 = array2.GetLength(1);  
    FillArray(array2);   
    PrintArray(array2);
    Console.WriteLine();

    int[,] arrayResult = new int[2,2];
    int rowsResult = arrayResult.GetLength(0);
    int columnsResult = arrayResult.GetLength(1);
    for(int i = 0; i < rowsResult; i++)
    {
        for(int j = 0; j < columnsResult; j++)
        {
            arrayResult[i, j] = array1[i,0] * array2[0,i] + array1[i,1] * array2[1,1];
        }
    }
    PrintArray(arrayResult);
}

void Exercice60()   //Задача выполнена, но непонятно как заполнить случайными неповторяющимися числами
{
    //Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
    //двузначных чисел. Напишите программу, которая будет построчно 
    //выводить массив, добавляя индексы каждого элемента.
    int[,,] array = new int[2,2,2];
    int number = 10;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int depth = array.GetLength(2);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for (int t = 0; t < depth; t++)
            {
                array[i,j,t] = number;
                number +=5;
                Console.WriteLine($"Индекс [{i},{j},{t}] равен {array[i,j,t]}");
            }
        }
    }
}

void Exercice62()   ///Не понимаю как перестать создавать циклы
{
    //Задача 62. Напишите программу, 
    //которая заполнит спирально массив 4 на 4.
    int[,] array = new int[4,4];
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int number = 1;
    int row = 0;
    int column = columns-1;
    for(int i = 0; i < columns; i++)
    {        
        array[row,i] = number;
        number++;
    }
    for(int i = 1; i < rows; i++)
    {        
        array[i,column] = number;
        number++;
    }
    column --;
    rows--;
    for(int i = column; i > 0; i--)
    {
        array[rows,i] = number;
        number++;
    }
    for(int i = rows; i > 0; i--)
    {
        array[i,row] = number;
        number++;
    }
    PrintArray(array);
}

void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintOneArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    } 
}

//Exercice54();
//Exercice56();
//Exercice58();
//Exercice60();
//Exercice62();
