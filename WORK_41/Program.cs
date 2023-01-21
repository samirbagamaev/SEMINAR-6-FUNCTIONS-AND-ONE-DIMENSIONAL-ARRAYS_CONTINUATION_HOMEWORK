// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" 
// и производится при помощи нажатия Enter

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("ВВЕДИТЕ ЧИСЛО(А): ");
//int Array = Convert.ToInt32(Console.ReadLine());
int [] m = 
int count = 0;
for (int i = 0; i < m.Length; i++)
{
    if (m[i] > 0)
    {
        count++; 
    }
    return;
}

Console.WriteLine(string.Join(",", m ));
//Console.WriteLine($"КОЛИЧЕСТВО ЭЛЕМЕНТОВ БОЛЬШЕ 0 РАВНО: {count}");


