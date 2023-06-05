using System;
using System.Linq;

class HelloWorld
{
    static void Main()
    {
        var numbers = (from num in Console.ReadLine().Split()
                       select int.Parse(num)).ToList();

        DisplayNumbers(numbers);

        Console.WriteLine("Удаление отрицательных элементов . . . ");

        numbers.RemoveAll(x => x < 0);
        DisplayNumbers(numbers);
    }

    static void DisplayNumbers(IEnumerable<int> numbers)
    {
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        var positiveNumbers = from num in numbers
                              where num > 0
                              select num;

        var nonZeroNumbers = from num in numbers
                             where num != 0
                             select num;

        Console.WriteLine($@"
Минимальное значение: {numbers.Min()}
Максимальное значение: {numbers.Max()}
Количество четных чисел: {evenNumbers.Count()}
Количество положительных чисел: {positiveNumbers.Count()}
Количество ненулевых чисел: {nonZeroNumbers.Count()}
");
    }
}
