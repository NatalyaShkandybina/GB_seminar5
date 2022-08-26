// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] arr = new int[123];
Random random = new Random();
for(int i=0; i<arr.Length; i++)
arr[i] = random.Next(0,101);
for(int i=0; i<arr.Length; i++)
System.Console.Write($"{arr[i],6}");

int count=0;
for(var i=0; i<arr.Length; i++)
{
   if(i > 10 && i < 99)
    count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count); 