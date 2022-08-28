// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

int[] ArrayGenerator(){
    int number = new Random().Next(2, 11);
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
    return array;
}

int FindTheDifference(int[] array){
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max-min;
}

int[] newArray = ArrayGenerator();
int evenIndex = FindTheDifference(newArray);

System.Console.WriteLine($"[{String.Join(',', newArray)}] -> {evenIndex}");