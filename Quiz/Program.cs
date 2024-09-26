namespace Quiz;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Quiz Başlıyor!");

        System.Console.WriteLine();

        int trueOption = 0;
        int falseOption = 0;

        System.Console.WriteLine("Türkiyenin Başkenti Neresidir?");
        System.Console.WriteLine();
        string[] options1 = { "Ankara", "İstanbul", "İzmir" };
        System.Console.WriteLine("Seçenekler: ");
        foreach (string item in options1)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Lütfen seçeneklerden birini giriniz.");
        string answer1 = Console.ReadLine();

        if (answer1.ToUpper() == "ANKARA")
        {
            System.Console.WriteLine("Doğru Cevap!");
            trueOption += 1;
        }
        else
        {
            System.Console.WriteLine("Yanlış Cevap!");
            falseOption += 1;
        }
        System.Console.WriteLine();

        System.Console.WriteLine("Gökyüzü ne renktir?");
        System.Console.WriteLine();
        string[] options2 = { "Mavi", "Pembe", "Mor", "Kırmızı" };
        System.Console.WriteLine("Seçenekler: ");
        foreach (string item1 in options2)
        {
            System.Console.WriteLine(item1);
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Lütfen seçeneklerden birini giriniz.");
        string answer2 = Console.ReadLine();

        if (answer2.ToLower() == "mavi")
        {
            System.Console.WriteLine("Doğru Cevap!");
            trueOption += 1;
        }
        else
        {
            System.Console.WriteLine("Yanlış Cevap!");
            falseOption += 1;
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Quiz Sona Erdi!\nToplam Doğru Sayısı: {trueOption}\nToplam Yanlış Sayısı: {falseOption}");


        /* using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quiz Başlıyor!");
        Console.WriteLine();

        int trueOption = 0;
        int falseOption = 0;

        // Sorular ve cevaplar
        string[] questions = {
            "Türkiyenin Başkenti Neresidir?",
            "Gökyüzü ne renktir?"
        };

        // Her sorunun seçenekleri
        string[][] options = {
            new string[] { "Ankara", "İstanbul", "İzmir" },
            new string[] { "Mavi", "Pembe", "Mor", "Kırmızı" }
        };

        // Doğru cevaplar
        string[] correctAnswers = { "Ankara", "Mavi" };

        // Quiz işlemi
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            Console.WriteLine("\nSeçenekler:");

            foreach (string option in options[i])
            {
                Console.WriteLine(option);
            }

            Console.WriteLine("\nLütfen seçeneklerden birini giriniz:");
            string answer = Console.ReadLine();

            if (answer.Equals(correctAnswers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Doğru Cevap!");
                trueOption++;
            }
            else
            {
                Console.WriteLine("Yanlış Cevap!");
                falseOption++;
            }

            Console.WriteLine();
        }

        // Sonuçları göster
        Console.WriteLine($"Quiz Sona Erdi!\nToplam Doğru Sayısı: {trueOption}\nToplam Yanlış Sayısı: {falseOption}");
    }
}
*/
    }
}
