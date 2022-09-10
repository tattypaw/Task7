//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int cols, int max){
    double[,] array = new double[rows,cols];
    Random rand = new Random(DateTime.Now.Millisecond);
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = 2 * max * (0.5 - rand.NextDouble());
    return array;
}

void Show2dArray(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальную величину чисел в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateRandom2dArray(i, j, max);
Show2dArray(array);
*/
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.


double[,] CreateRandom2dArray(int rows, int cols, int max){
    double[,] array = new double[rows,cols];
    Random rand = new Random(DateTime.Now.Millisecond);
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = 2 * max * (0.5 - rand.NextDouble());
    return array;
}

void Show2dArray(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите номер строки искомого элемента: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента: ");
int j = Convert.ToInt32(Console.ReadLine());
//В задаче не задан размер массива, поэтому рассмотрен размер как в примере 3 строки 4 столбца. 
//Номера строк от 0 до 2, номера столбцов от 0 до 3, 
//array[1,2] лежит в строке с номером 1 (вторая) и в столбце с номером 2(третьем)
double[,] array = CreateRandom2dArray(3, 4, 20);

if ((i<3 & i>=0) & (j >=0 & j < 4)) {
    Console.WriteLine("Значение элемента: " + array[i,j]);}
else {Console.WriteLine("Такого элемента не существует");}

Show2dArray(array);
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/
int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void ShowArray(double[] array){
    for(int i = 0; i<array.Length; i++){
            Console.Write(array[i]+ "; ");
        }
        Console.WriteLine();
}

double[] CalcAverageCol(int[,] array){
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i< array.GetLength(1); i++){
        double sum = 0;
        for(int j = 0; j<array.GetLength(0); j++){
            sum += array[j,i];
        }
        average[i] = sum/array.GetLength(0);
        }
    return average;
    }

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows, cols, min, max);
double[] average = CalcAverageCol(array); 
Show2dArray(array); 
Console.Write("Среднее арифметическое каждого столбца: ");
ShowArray(average);
