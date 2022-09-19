// Задание:
// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых менее либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] -> [“-2”]
// [“Russia”, “Denmark”, “Kazan”] -> []

string[] array = new string[] { "Вася", "Петя", "1", "do", "32", "sheep", "yes" };
// Console.WriteLine(String.Join(", ", array));
// string[] mass = new string[array.Length];
// int index = 0;
for (int count = 0; count < array.Length; count++)
{
    if (array[count].Length <= 3) 
    {
        string[] mass = new string[array.Length-count];
        int index = 0;
        mass[index] = array[count];
        Console.Write($"[{mass[index]}] ");
        index++;
    }
}