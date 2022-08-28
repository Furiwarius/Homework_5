// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] ArrayGenerator(){
    int number = new Random().Next(2, 11);
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int LookForEvenNumbers(int[] array){
    int number  = 0;
    foreach (int i in array)
    {
        if (i%2 == 0) number+=1;
    }
    return number;
}

int[] newArray = ArrayGenerator();
int evenNumbers = LookForEvenNumbers(newArray);
System.Console.WriteLine($"[{String.Join(',', newArray)}] -> {evenNumbers}");