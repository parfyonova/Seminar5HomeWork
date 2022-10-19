/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine();
Console.WriteLine("Задача 34:");
int[] array34 = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", array34));
Console.WriteLine($"Кол-во четных чиcел в массиве равно {EvenInt(array34)}");
Console.WriteLine();

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Задача 36:");
int[] array36 = GetArray(10, -100, 101);
Console.WriteLine(String.Join(" ", array36));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {SumOddInt(array36)}");
Console.WriteLine();

/* Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности,
с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Задача 38:");
int[] array38 = GetArray(5, -1000, 1001);
Console.WriteLine(String.Join(" ", array38));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DifMaxMinInt(array38)}");
Console.WriteLine();


// МЕТОДЫ:
// Метод по заполнению архива - ко всем Задачам
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

// Метод по нахождению кол-ва четных чисел в массиве - к Задаче №34
int EvenInt(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
            if (array[i] % 2 == 0){
            count ++;
        }
    }
    return count;
}

// Метод по нахождению суммы элементов, стоящих на нечётных позициях - к Задаче №36

int SumOddInt(int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2){
        sum += array[i];
    }
    return sum;
}

// Метод по нахождению разницы между минимальным и максимальным элементами массива - к Задаче №38
int DifMaxMinInt(int[] array){
    int imin = 0;
    int imax = 0;
    for (int i = 0; i < array.Length; i++){
        if(array[i] < array[imin]){
            imin = i;
        }
        if (array[i] > array[imax]){
            imax = i;
        }
    }
    int result = array[imax] - array[imin];
    return result;
}