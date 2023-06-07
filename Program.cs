// дз8:
// // ********************************************************
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[] quick_sort(int[] mas, int min_ind, int max_ind){
//     if (min_ind >= max_ind){
//         return mas;
//     }
//     int pivot = get_pivot(mas, min_ind, max_ind);
//     quick_sort(mas, min_ind, pivot - 1);
//     quick_sort(mas, pivot + 1, max_ind);
//     return mas;
// }

// int get_pivot(int[] mas, int min_ind, int max_ind){
//     int pivot = min_ind - 1;
//     for(int i = min_ind; i <= max_ind; i++){
//         if (mas[i] > mas[max_ind]){
//             pivot++;
//             swap(ref mas[pivot],  ref mas[i]);
//         }
//     }
//     pivot++;
//     swap(ref mas[pivot], ref mas[max_ind]);
//     return pivot;
// }

// void swap(ref int leftItem, ref int rightItem)
//         {
//             int temp = leftItem;
//             leftItem = rightItem;
//             rightItem = temp;
//         }

// int[,] create_matrix_random_int(int i, int j){
//     int[,] mas = new int[i, j];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             mas[i, j] = rnd.Next(-100, 101);
//     }}
//     return mas;}



// void print_matrix_int(int[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 5}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}



// void sort_matrix_colls(int[,] matr){
//     int rows = matr.GetLength(0);
//     int colls = matr.GetLength(1);

//     int[] m2 = new int[rows];
//     for(int i = 0; i < colls; i++){
//         for(int j = 0; j < rows; j++){
//             m2[j] = matr[j, i];}
//         quick_sort(m2, 0, rows - 1);
//        for(int j = 0; j < rows; j++){
//             matr[j, i] = m2[j];}
// }
// }
// void sort_matrix_rows(int[,] matr){
//     int rows = matr.GetLength(0);
//     int colls = matr.GetLength(1);
//     int[] m1 = new int[colls];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colls; j++){
//             m1[j] = matr[i, j];}
//         quick_sort(m1, 0, colls - 1);
//         for(int j = 0; j < colls; j++){
//             matr[i, j] = m1[j];}
// }
// }




// System.Console.WriteLine("Введите количеттво строк и количество столбцов(последовательно, через enter).");
// int[,] matrix = create_matrix_random_int(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// System.Console.WriteLine("До сортировки:");
// print_matrix_int(matrix);
// sort_matrix_rows(matrix);
// System.Console.WriteLine("Отсортировали:");
// print_matrix_int(matrix);
// int[,] matrix1 = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
// System.Console.WriteLine("Проверка теста из условия. До сортировки:");
// print_matrix_int(matrix1);
// sort_matrix_rows(matrix1);
// System.Console.WriteLine("Отсортировали:");
// print_matrix_int(matrix1);
// // ********************************************************






// // ********************************************************
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
//суммой элементов: 1 строка

// int[,] create_matrix_random_int(int i, int j){
//     int[,] mas = new int[i, j];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             mas[i, j] = rnd.Next(-100, 101);
//     }}
//     return mas;}



// void print_matrix_int(int[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 5}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}

// int min_sum_row(int[,] matr){
//     int rows = matr.GetLength(0);
//     int colls = matr.GetLength(1);
//     int min_s = 999999999;
//     int res = 0;
//     int s = 0;
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colls; j++){
//             s += matr[i, j];}
//         if (s < min_s){
//              min_s = s;
//              res = i;
//         }
//         s = 0;
//         }
//         return res + 1;
//         }



// System.Console.WriteLine("Введите количеттво строк и количество столбцов(последовательно, через enter).");
// int[,] matrix = create_matrix_random_int(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// System.Console.WriteLine("Массив:");
// print_matrix_int(matrix);
// System.Console.WriteLine($"Строка с минимальной суммой элементов: {min_sum_row(matrix)}");

// int[,] matrix1 = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
// System.Console.WriteLine("Проверка теста из условия.");
// System.Console.WriteLine("Массив:");
// print_matrix_int(matrix1);
// System.Console.WriteLine($"Строка с минимальной суммой элементов: {min_sum_row(matrix1)}");
// // ********************************************************






// // ********************************************************
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int[,] create_matrix_random_int(int i, int j){
//     int[,] mas = new int[i, j];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             mas[i, j] = rnd.Next(-10, 11);
//     }}
//     return mas;}



// void print_matrix_int(int[,] mas){
//     Console.Write("[");
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//             System.Console.Write($"{mas[i, j], 5}");
//     }
//     System.Console.WriteLine();
//     }
//     Console.WriteLine($"]");}

// int[,] product(int[,] matr1, int[,] matr2){
//     int rows = matr1.GetLength(0);
//     int colls = matr2.GetLength(1);
//     int[,] res = new int [rows, colls];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colls; j++){
//             for(int k = 0; k < matr2.GetLength(0); k++){
//                 res[i, j] += matr1[i, k] * matr2[k, j];
//         }}}
//         return res;
//         }



// System.Console.WriteLine("Введите количеттво строк и количество столбцов первой матрицы (последовательно, через enter).");
// int rows = Convert.ToInt32(Console.ReadLine());
// int colls = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = create_matrix_random_int(rows, colls);
// System.Console.WriteLine("Матрица1");
// print_matrix_int(matrix);
// System.Console.WriteLine("Введите количеттво столбцов второй матрицы (количество строк второй матрицы должно совпадать с количеством столбцов первой матрицы).");
// int[,] matrix1= create_matrix_random_int(colls, Convert.ToInt32(Console.ReadLine()));
// System.Console.WriteLine("Матрица2");
// print_matrix_int(matrix1);
// System.Console.WriteLine($"Матрица 3: произведение матрицы 1 и матрицы 2:");
// print_matrix_int(product(matrix, matrix1));

// System.Console.WriteLine();
// int[,] matrix2 = {{2, 4}, {3, 2}};
// int[,] matrix3 = {{3, 4}, {3, 3}};
// System.Console.WriteLine("Проверка теста из условия.");
// System.Console.WriteLine("Матрица 1 из условия задачи:");
// print_matrix_int(matrix2);
// System.Console.WriteLine("Матрица 2 из условия задачи:");
// print_matrix_int(matrix3);
// System.Console.WriteLine($"Произведение матриц из условия задачи:");
// print_matrix_int(product(matrix2, matrix3));


// System.Console.WriteLine();
// int[,] matrix4 = {{2, 1}, {-3, 0}, {4, -1}};
// int[,] matrix5 = {{5, -1, 6}, {-3, 0, 7}};
// System.Console.WriteLine("Проверка из примера отсюда: https://ru.onlinemschool.com/math/library/matrix/multiply/");
// System.Console.WriteLine("Матрица 1:");
// print_matrix_int(matrix4);
// System.Console.WriteLine("Матрица 2:");
// print_matrix_int(matrix5);
// System.Console.WriteLine($"Произведение матриц:");
// print_matrix_int(product(matrix4, matrix5));
// // ********************************************************





// // ********************************************************
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] create_matrix3_random_int(int i, int j, int k){
//     int[,,] mas = new int[i, j, k];
//     int r = 0;
//     int d = 0;
//     int[] mark = new int[180];
//     Random rnd = new Random();
//     for(i = 0; i < mas.GetLength(0); i++){
//         for(j = 0; j < mas.GetLength(1); j++){
//             for(k = 0; k < mas.GetLength(2); k++){
//                 r = rnd.Next(-99, 100);
//                 while(mark.Contains(r) || (r >-10 && r < 10)) r = rnd.Next(-99, 100);
//                 mark[d] = r;
//                 mas[i, j, k] = r;
//     }}}
//     return mas;}



// void print_matrix3_int(int[,,] mas){
//     Console.Write("[");
//     for(int k = 0; k < mas.GetLength(2); k++){
//     for(int i = 0; i < mas.GetLength(0); i++){
//         for(int j = 0; j < mas.GetLength(1); j++){
//                 System.Console.Write($"{mas[i, j, k]}:  ({i}{j}{k}) ");
//     }
//     System.Console.WriteLine();
//     }}
//     Console.WriteLine($"]");}



// System.Console.WriteLine("Введите 3 размерности (последовательно, через enter).");
// int[,,] matrix1 = create_matrix3_random_int(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// System.Console.WriteLine("Матрица:");
// print_matrix3_int(matrix1);


// int[,,] matrix2 = {{{66, 27}, {25, 90}}, {{34, 26}, {41, 55}}};
// System.Console.WriteLine("Матрица из задания:");
// print_matrix3_int(matrix2);
// // ********************************************************



// // ********************************************************
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] create_spiral(int r){
    int[,] mas = new int[r, r];
    int j = 0;
    int i = 0;
    for(int k = 1; k < r * r + 1; k++){
        mas[i, j] = k;
        if(k >= r * r) break;
        if(i <= j + 1 && i + j < r - 1) j++;
        else if(i < j  && i + j >= r - 1) i++;
        else if(i >= j && i + j > r - 1) j--;
        else if(i > j + 1 && i + j <= r - 1) i--;
    }
    return mas;}



void print_matrix_int(int[,] mas){
    Console.Write("[");
    for(int i = 0; i < mas.GetLength(0); i++){
        for(int j = 0; j < mas.GetLength(1); j++){
            System.Console.Write($"{mas[i, j], 5}");
    }
    System.Console.WriteLine();
    }
    Console.WriteLine($"]");}



System.Console.WriteLine("Введите размерность");
int[,] matrix = create_spiral(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("Массив:");
print_matrix_int(matrix);
