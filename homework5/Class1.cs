using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


public static class Message
{
    public static void Word()
    {
        Console.Write("Введите фразу: ");
        string phraze = Console.ReadLine();

        Console.Write("Укажите, не более скольки символов должны содержать выводимые слова: ");
        int n = int.Parse(Console.ReadLine());

        string[] words = phraze.Split(' ', ',', '.', '!', '?', '-');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= n)
            {
                Console.WriteLine($"Слова, содержащие не более {n} букв: {words[i]}");
            }

        }

    }

    public static void DeleteWord()
    {
        Console.Write("Введите фразу: ");
        string phraze = Console.ReadLine();

        Console.Write("Укажите желаемый конечный символ: ");
        char n = Convert.ToChar(Console.ReadLine());

        string[] words = phraze.Split(' ', ',', '.', '!', '?', '-');

        for (int i = 0; i < words.Length; i++)
        {
            if (!words[i].EndsWith(n))
            {
                Console.WriteLine($"Фраза с удаленными словами: {words[i]}");
            }         
        }
    }

    public static void LongestWord()
    {
        int max = 0;

        Console.Write("Введите фразу: ");
        string phraze = Console.ReadLine();
        string maxWord = "";
        string[] words = phraze.Split(' ', ',', '.', '!', '?', '-');

        for (int i = 0; i < words.Length; i++)
        {
             if (words[i].Length > max)
             {
                max = words[i].Length;
                maxWord = words[i];
             } 
        }
        Console.WriteLine($"Самое длинное слово в сообщении: {maxWord}");
    }

    public static void WordBuilder()
    {
        int max = 0;

        Console.Write("Введите фразу: ");
        string phraze = Console.ReadLine();
        string[] words = phraze.Split(' ', ',', '.', '!', '?', '-');
        
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= max)
            {
                max = words[i].Length;
                stringBuilder = stringBuilder.Append(words[i] + " ");

            }
        }

        Console.WriteLine($"Строка из самых длинных слов: {stringBuilder.ToString()}");

    }

}



namespace homework5
{
    internal class Class1
    {
        static void Main()
        {
            Message.Word();
            Message.DeleteWord();
            Message.LongestWord();
            Message.WordBuilder();

        //    static void TwoStrings()
        //    {
        //        Console.Write("Введите фразу: ");
        //        string phraze1 = Console.ReadLine();
        //        Console.Write("Введите вторую фразу: ");
        //        string phraze2 = Console.ReadLine();

        //        char[] chars = phraze1.ToCharArray();
        //        Array.Reverse(chars);
        //        string reversePhraze = new string(phraze1);

        //        Console.Write(reversePhraze);

        //        if (reversePhraze == phraze2)
        //        {
        //            Console.WriteLine($"Строка {phraze2} является перестановкой {phraze1}");
        //        }
        //        else
        //            Console.WriteLine($"Строка {phraze2} не является перестановкой {phraze1}");

        //    }
        //    TwoStrings(); это была моя попытка сделать задание 3, но строка не хочет переворачиваться
        }

    }
}
