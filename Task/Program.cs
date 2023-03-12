﻿// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк, длина которых меньше или равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решение не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.


Console.WriteLine("Введите массив строк разделенные пробелами: "); // Вывод на экран сообщения с просьбой ввести массив строк.
string[] inputArray = Console.ReadLine().Split(' ');               // Создание строковой переменной input и запись данных с клавиатуры 
                                                                   //с использованием метода Console.ReadLine().

List<string> resultList = new List<string>();                     // Создание списка строк resultList.

foreach (string s in inputArray)                                  // Начало цикла, который пробегается по каждому элементу массива inputArray.
{
    if (s.Length <= 3)                                            // Если длина текущей строки меньше либо равна трем символам, 
                                                                  //то выполняется следующая строка кода.
    {
        resultList.Add(s);                                       // Добавление текущей строки в результативный список resultList.
    }
}
System.Console.WriteLine();                                     // Вывод пустой строки для удобочитаемости результата на экране.
Console.WriteLine("Результирующий массив строк:");              // Вывод на экран сообщения о том, что далее идет результирующий массив строк.
Console.WriteLine("[" + string.Join(", ", resultList) + "]");   // Объединение элементов списка с помощью метода Join и вывод на экран. 