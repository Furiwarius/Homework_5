// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayGenerator(){
    int number = new Random().Next(2, 11);
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 51);
    }
    return array;
}

int LookForEvenIndex(int[] array){
    int number  = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 != 0)
        {
            number+=array[i];
        }
    }
    return number;
}

int[] newArray = ArrayGenerator();
int evenIndex = LookForEvenIndex(newArray);

System.Console.WriteLine($"[{String.Join(',', newArray)}] -> {evenIndex}");