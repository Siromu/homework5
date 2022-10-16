using System.Text.RegularExpressions;

static void Login()
{
    Console.Write($"Введите желаемый логин, он должен содержать от 2 до 10 символов. Цифра не должна быть первой! \nИспользуйте только латинские буквы и цифры! \nЛогин: ");
    string login = Console.ReadLine();

    Regex goodLogin = new Regex("(^[a-z]|[0-9]){2,10}");

    if (goodLogin.IsMatch(login))
    {
        Console.WriteLine($"У вас хороший логин! Вы ввели: {login}");
    }
    else
    {
        Console.WriteLine("У Вас неверный логин!");
    }

}

Login();
