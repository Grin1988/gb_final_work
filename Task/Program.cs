// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше или равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решение не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

Console.WriteLine("Введите массив строк разделенные пробелами: ");
string[] inputArray = Console.ReadLine().Split(' '); // Преобразование string в string[] и его запись

List<string> resultList = new List<string>();

foreach (string s in inputArray)
{
    if (s.Length <= 3)
    {
        resultList.Add(s);
    }
}
System.Console.WriteLine();
Console.WriteLine("Результирующий массив строк:");
Console.WriteLine("[" + string.Join(", ", resultList) + "]");