int i = 0;
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
while (i == 0){
    if (number > 0 & number < 8){
        if (number == 6 | number == 7)  Console.WriteLine($"Введенный номер дня недели является выходным днем."); 
        else Console.WriteLine($"Введенный номер дня недели не является выходным днем."); 
    }
    else Console.WriteLine($"Вы ввели некорректный номер дня недели. Неделя состоит из 7 дней.");
    i++;
}
