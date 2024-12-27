Console.WriteLine("Текущая дата и время: " + DateTime.Now);
        Console.WriteLine("Введите дату и время последнего звонка.");
        Console.WriteLine("Год:");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Месяц:");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("День:");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Часы:");
        int hour = int.Parse(Console.ReadLine());
        Console.WriteLine("Минуты:");
        int minute = int.Parse(Console.ReadLine());
        DateTime lastCall = new DateTime(year, month, day, hour, minute, 0);
        DateTime expiration = lastCall.AddYears(1);
        Console.WriteLine("Срок действия пакета истекает: " + expiration);
        int dayOfWeek = (int)expiration.DayOfWeek;
        dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek; 
        Console.WriteLine("День недели: " + dayOfWeek);
 