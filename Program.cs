
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