// Функция для ввода данных
int GetData()
{
    Console.Write("_______________________________________________\nВведите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}


// Функция останавливает программу после выполнения
// одной задачи чтобы результат не ушел наверх консоли
void PauseEnt()
{
    Console.Write("_______________________________________________\nЧтобы продолжить, нажмите ENTER... ");
    Console.ReadLine();
    main();
}


// Находим цифру любую по счету слева направо в числе любой разрядноти
// Задачи 10 и 13 похожи поэтому объединил в одну универсальную.
void FindNum()
{
    Console.WriteLine("\n\nУКАЖИТЕ ЧИСЛО С ЛЮБОЙ РАЗРЯДНОСТЬЮ:");
    int x = GetData();
    ret:
    Console.WriteLine("\n\nКАКОЕ ПО СЧЕТУ ЧИСЛО БУДЕМ ИЗВЛЕКАТЬ?");
    int n = GetData();
    string x1 = x.ToString();
    int lng = x1.Length;
    int i = lng;
    int result = 0;
    if (n > lng)
    {
        Console.WriteLine($"\n\nОШИБКА! В УКАЗАННОМ ЧИСЛЕ НЕТ {n}-Й ЦИФРЫ.\n ПОПРОБУЙТЕ ЕЩЕ РАЗ.");
        goto ret;
    }
    else
    {
        while (i > 0)
        {
            if (i < lng)
            {
                x = x / 10;
            }
            if (i == n)
            {
                result = x % 10;          
            }
            i = i - 1;
        }
        Console.WriteLine($"\n================================================\n{n}-Я ЦИФРА ЧИСЛА {x1} = {result}\n================================================\n");
    }
}


// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
void Week()
{
    string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
    ret:
    Console.WriteLine("\nУКАЖИТЕ ДЕНЬ НЕДЕЛИ:\n\n 1. Понедельник\n 2. Вторник\n 3. Среда\n 4. Четверг\n 5. Пятница\n 6. Суббота\n 7. Воскресенье");
    int x = GetData();
    int index = x - 1;
    if (x > 0 && x < 8)
    {
        if (x > 5 && x < 8)
        {
            Console.WriteLine($"\n================================================\n{week[index]} - ВЫХОДНОЙ ДЕНЬ.\n================================================\n");
        }
        else
        {
            Console.WriteLine($"\n================================================\n{week[index]} - РАБОЧИЙ ДЕНЬ.\n================================================\n");
        }
    }
    else
    {
        Console.WriteLine($"{x} - ТАКОГО ДНЯ НЕДЕЛИ НЕТ. ПОПРОБУЙТЕ ЕЩЕ РАЗ...");
        goto ret;
    }

}


// Напишите программу, которая принимает на вход целое число
// любой разрядности число и удаляет вторую цифру слева
// направо этого числа
void RemoveNum()
{
    Console.WriteLine("\n\nУКАЖИТЕ ЧИСЛО С ЛЮБОЙ РАЗРЯДНОСТЬЮ:");
    int x = GetData();
    ret:
    Console.WriteLine("\n\nКАКОЕ ПО СЧЕТУ ЧИСЛО БУДЕМ УДАЛЯТЬ?");
    int n = GetData();
    string x1 = x.ToString();
    int lng = x1.Length;
    int i = lng;
    int result = 0;
    if (n > lng)
    {
        Console.WriteLine($"\n\nОШИБКА! В УКАЗАННОМ ЧИСЛЕ НЕТ {n}-Й ЦИФРЫ.\n ПОПРОБУЙТЕ ЕЩЕ РАЗ.");
        goto ret;
    }
    else
    {
        Console.Write($"\n================================================\n{n}-Я ЦИФРА ИЗ ЧИСЛА {x} УДАЛЕНА: ");
        string r = "";
        while (i > 0)
        {
            if (i < lng)
            {
                x = x / 10;
            }
            if (i != n)
            {
                result = x % 10; 
                r = result+r;
            }
            i = i - 1;
        }
        Console.WriteLine($"{r}\n================================================\n");
    }
}


// Посчитать программистов в комнате и правильно просклонять
// слово программист в соответствии с количеством
void hmp()
{
    Console.WriteLine("\n\nСКОЛЬКО ПРОГРАММИСТОВ В КОМНАТЕ?");
    int x = GetData();
    int x2 = x;
    string p = "Программист";
    string x1 = x.ToString();
    int lng = x1.Length;
    int i = lng;
    int result = 0;
    while (i > 0)
    {
        if (i < lng) x = x / 10;
        if (i == lng) result = x % 10;
        i = i - 1;
    }
    Console.WriteLine(result);
    if (x2 > 4 && x2 < 21) p = "Программистов";
    else if (result == 1) p = "Программист";
    else if (result > 1 && result < 5) p = "Программиста";
    else p = "Программистов";
    Console.WriteLine($"\n================================================\nВ КОМНАТЕ {x1} {p}.\n================================================\n");
}



// Главное меню
void main()
{
    Console.WriteLine("\n\nВЫБЕРИТЕ ДЕЙСТВИЕ....");
    Console.WriteLine("\n================================================\n 1. Найти n-ую цифру числа.\n 2. Удалить n-ую цифру числа.\n 3. Определить выходной по номеру дня недели.\n 4. Сколько программистов в комнате?\n 5. Выход.\n================================================\n");
    int choice = GetData();
    if (choice > 5)
    {
        Console.WriteLine($"\n\n{choice}. ВЫ ВЫБРАЛИ НЕ СУЩЕСТВУЮЩИЙ ПУНКТ МЕНЮ. ПОВТОРИТЕ ПОПЫТКУ.");
        PauseEnt();
    }
    else
    {
        switch (choice)
        {
            case 1:
                FindNum();
                PauseEnt();
                break;
            case 2:
                RemoveNum();
                PauseEnt();
                break;
            case 3:
                Week();
                PauseEnt();
                break;
            case 4:
                hmp();
                PauseEnt();
                break;
            case 5:
                break;
        }
    }
}


try
{
    main();
}


catch
{
    Console.WriteLine("Вы ввели не целое число!!!");
}