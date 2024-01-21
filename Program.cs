 
Console.Write("Введите длину массива: ");
int N = int.Parse(Console.ReadLine()!);
int[] numbers = new int[N];
Random random = new Random(); // Генератор случайных чисел
Console.Write("Исходный массив: ");
for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = random.Next(1, 100); 
Console.Write(numbers[i] + " ");
}
for (int i = 0; i < numbers.Length / 2; i++)
{
// Меняем местами элементы
int temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}
// Вывод измененного массива
Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}