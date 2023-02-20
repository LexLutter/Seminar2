int i = 0;
int result = 0;
while (i == 0){
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) number = number * (-1);
    if (number > 99 & number < 1000){
        result = (number % 100) / 10;
        Console.WriteLine($"Вторая цифра заданного числа: {result}");
        i++;
    }
    else Console.WriteLine($"Вы ввели некорректное число.");
}