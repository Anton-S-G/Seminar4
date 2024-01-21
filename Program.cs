
// Task1
// // while (true) // true == true
// // {
// // Console.Write("Введите текст: ");
// // string text = Console.ReadLine();
// // if (text == "q")
// // {
// // break;
// // }

// // // Нужно проверить, что строчка text cостоит ТОЛЬКО
// // // из цифр
// // int number; // 0, если в строчке есть символы
// // // или само число
// // if (int.TryParse(text, out number)) // == true
// // {
// // // Console.WriteLine("Введенная строчка состоит из ЦИФР");
// //     int sum = 0; // 56 => 6+5
// //     while (number > 0)
// //     {
// //     sum += number % 10;
// //     number /= 10; // Избавляюсь от последней цифры
// //     }
// //         if (sum % 2 == 0)
// //             {
// //             Console.WriteLine("[STOP]");
// //             break;
// //             }
// // }

// // }

// Task2
// // int[] numbers = new int[10]; 
// // Random random = new Random(); // Генератор случайных чисел
// // int evenCount = 0; 
// // for (int i = 0; i < numbers.Length; i++)
// // {
// // numbers[i] = random.Next(100, 1000); 
// // Console.Write(numbers[i] + " "); 
// // // Проверка на четность и увеличение счетчика
// // if (numbers[i] % 2 == 0)
// // {
// // evenCount++;
// // }
// // }
// // Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");


// Task3
 
// // Console.Write("Введите длину массива: ");
// // int N = int.Parse(Console.ReadLine()!);
// // int[] numbers = new int[N];
// // Random random = new Random(); // Генератор случайных чисел
// // Console.Write("Исходный массив: ");
// // for (int i = 0; i < numbers.Length; i++)
// // {
// // numbers[i] = random.Next(1, 100); 
// // Console.Write(numbers[i] + " ");
// // }
// // for (int i = 0; i < numbers.Length / 2; i++)
// // {
// // // Меняем местами элементы
// // int temp = numbers[i];
// // numbers[i] = numbers[numbers.Length - 1 - i];
// // numbers[numbers.Length - 1 - i] = temp;
// // }
// // // Вывод измененного массива
// // Console.Write("\nПеревернутый массив: ");
// // foreach (int number in numbers)
// // {
// // Console.Write(number + " ");
// // }