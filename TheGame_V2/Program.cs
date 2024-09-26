namespace TheGame_V2;

class Program
{
    static void Main(string[] args)
    {

        string[] gameOption = { "TAŞ", "KAĞIT", "MAKAS" };

        System.Console.WriteLine("Oyun Başladı!");


        string exit = "";
        int score = 0;

        do
        {
            System.Console.Write("Lütfen Taş, Kağıt, Makas seçeneklerinden birini giriniz: ");
            string choosen = Console.ReadLine();
            Random rnd = new Random();
            int rndIndex = rnd.Next(gameOption.Length);
            System.Console.WriteLine(gameOption[rndIndex]);
            if (choosen.ToUpper() == gameOption[rndIndex])
            {
                System.Console.WriteLine("Bildin :)");
                score += 10;
            }
            else
            {
                System.Console.WriteLine("Bilemedin :(");
                score -= 10;
            }
            System.Console.WriteLine($"Skor: {score}\nOyundan Çıkmak İçin 'ÇIKIŞ' yazabilirsiniz.\n Devam etmek için 'ENTER'a tıkla. ");
            exit = Console.ReadLine();
        } while (exit.ToUpper() != "ÇIKIŞ");

        System.Console.WriteLine("Oyun Bitti!\n" + "Toplam Skor: " + score);

    }
}
