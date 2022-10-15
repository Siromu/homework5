using System.Text.RegularExpressions;

static void Login()
{
    Console.Write($"Введите желаемый логин, он должен содержать от 2 до 10 символов. \nИспользуйте только латинские буквы и цифры");
    string login = Console.ReadLine();

    if (login.Length > 2 && login.Length < 10)
    {
        Regex goodLogin = new Regex("^[a-z]${0,9}");
        if (goodLogin.IsMatch(login))
        {
            Console.WriteLine($"У вас хороший логин! Вы ввели: {login}");
        }
        else
        {
            Console.WriteLine($"Ваш логин не соответствует условиям! Цифра не должна быть первым символом");
        }
    }
    else
    {
        Console.WriteLine("Ваш логин меньше двух символов, либо больше десяти!");
    }

}

Login(); 
