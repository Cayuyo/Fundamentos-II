// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//1. Imprimir 1-255
using System.Globalization;

Console.WriteLine("**********************[ 1. Imprimir 1-255​ ]***********************");

static void PrintNumbers()
{
    int[] numbers = new int[255];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = i + 1;
        Console.WriteLine(numbers[i]);
    }
}
PrintNumbers();

// 2. Imprimir números impares entre 1-255​
Console.WriteLine("**********************[ 2. Imprimir números impares entre 1-255​​ ]***********************");

static void PrintOdds()
{

    for (int i = 1; i <= 255; i += 2)
    {
        Console.WriteLine(i);
    }
}
PrintOdds();

// 3. Imprimir Suma​
Console.WriteLine("**********************[ 3. Imprimir Suma​​ ]***********************");

static void PrintSum()
{
    int sum = 0;
    for (int i = 0; i <= 255; i++)
    {
        sum += i;
        Console.WriteLine("New number: {0} Sum: {1}", i, sum);
    }
}
PrintSum();

// 4. Iterar a través de una matriz​
Console.WriteLine("**********************[ 4. Iterar a través de una matriz​​ ]***********************");

static void LoopArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}
int[] myNumbers = {1, 2, 3, 4, 5};
LoopArray(myNumbers);

// 5. Encuentra el valor máximo
Console.WriteLine("**********************[ 5. Encuentra el valor máximo​ ]***********************");

static int FindMax(int[] numbers)
{
    int maxNumber = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxNumber)
        {
            maxNumber = numbers[i];
        }
    }
    return maxNumber;
}
int[] myNumbers1 = {-3, -5, -9, -23, -1, -10, -2};
int maxVal = FindMax(myNumbers1);
Console.WriteLine("El valor mas alto es: {0}", maxVal);

// 6. Obtén el Promedio​
Console.WriteLine("**********************[ 6. Obtén el Promedio​​ ]***********************");

static void GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    double prom = (double)sum / numbers.Length;
    Console.WriteLine("El Promedio es: {0}", prom);
}

int[] myNumbers2 = {4, 3, 7, 6};
GetAverage(myNumbers2);

// 7. Lista con números impares​
Console.WriteLine("**********************[ 7. Lista con números impares​​ ]***********************");

static List<int> Oddlist()
{
    List<int> oddNumbers = new List<int>();

    for (int i = 1; i <= 255; i +=2)
    {
        oddNumbers.Add(i);
    }

    return oddNumbers;
}

foreach (int number in Oddlist())
{
    Console.WriteLine(number);
}

// 8. Mayor que Y​
Console.WriteLine("**********************[ 8. Mayor que Y​​ ]***********************");

static int GreaterThanY(List<int> numbers, int y)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number > y)
        {
            count++;
            Console.WriteLine("Número mayor que Y({0}): {1}",y, number);
        }
    }

    return count;
}

List<int> listNumber = new List<int> {10, 33, 43, 99, 123};
int y = 5;
int count = GreaterThanY(listNumber, y);
Console.WriteLine("Los números mayores que Y({0}) son: {1}" ,y, count);

// 9. Haz Cuadrar los Valores​
Console.WriteLine("**********************[ 9. Haz Cuadrar los Valores​​ ]***********************");

static void SquareArrayValues(List<int> numbers)
{
    string formattedList = "Lista de números: {" + string.Join(", ", numbers) + "}";
    Console.WriteLine(formattedList);
    Console.WriteLine("Valores al cuadrado 👇");
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] = numbers[i] * numbers[i];
    }
    
}

List<int> numberList = new List<int> {3, 7, 11, -6, -3, 33};
SquareArrayValues(numberList);

foreach (int number in numberList)
{
    Console.WriteLine(number);
}

// 10. Elimina los Números Negativos​
Console.WriteLine("**********************[ 10. Elimina los Números Negativos​​ ]***********************");

static void EliminateNegatives(List<int> numbers)
{
    string formattedList = "Lista de números: {" + string.Join(", ", numbers) + "}";
    Console.WriteLine(formattedList);

    for (int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < 0)
        {
            numbers[i] = 0;
        }
    }
}

List<int> numberList1 = new List<int> {1, 5, 10, -2, -9, -22, -9000};
EliminateNegatives(numberList1);

foreach (int number in numberList1)
{
    Console.WriteLine(number);
}