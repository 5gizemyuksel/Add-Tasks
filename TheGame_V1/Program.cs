namespace TheGame_V1;

class Program
{
    static void Main(string[] args)
    {
        string[] gameOption = { "TAŞ", "KAĞIT", "MAKAS" };

        System.Console.WriteLine("Oyun Başladı!");

        int live = 3;

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
            }
            else
            {
                System.Console.WriteLine("Bilemedin :(");
                live--;

            }

        } while (live > 0);

        System.Console.WriteLine("Game Over!");





    }
}
