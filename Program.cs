int[] numbers = new int[10]; 
Random random = new Random(); // Генератор случайных чисел
int evenCount = 0; 
for (int i = 0; i < numbers.Length; i++)
{
numbers[i] = random.Next(100, 1000); 
Console.Write(numbers[i] + " "); 
// Проверка на четность и увеличение счетчика
if (numbers[i] % 2 == 0)
{
evenCount++;
}
}
// Вывод количества четных чисел в массиве
Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
