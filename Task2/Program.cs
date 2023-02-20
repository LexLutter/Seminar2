int i = 0;
int result = 0;
while (i == 0){
    Console.Write("Введите семизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) number = number * (-1);
    if (number >= 1000000 & number < 10000000){
        result = (number / 10000) % 10;
        Console.WriteLine($"Третья цифра заданного числа: {result}");
        i++;
    }
    else{
        if (number < 100) Console.WriteLine($"В введенном вами числе нет 3 цифры.");
        else Console.WriteLine($"Вы ввели некорректное число.");
    }
}
