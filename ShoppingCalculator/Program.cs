using System.Diagnostics.Metrics;

namespace ShoppingCalculator;

class Program
{
    static void Main(string[] args)
    {
        string[] shopList = { "deterjan", "yağ", "yumuşatıcı", "zeytin", "peynir", "kaşar", "süt", "yumurta" };

        int[] price = { 300, 350, 100, 50, 120, 250, 30, 75 };
        int total = 0;
        int counter = 0;
        foreach (string item in shopList)
        {
            counter++; ;
            System.Console.WriteLine($"{counter}. {item}");

        }



        string exit = "";

        while (exit.ToUpper() != "T")
        {
            System.Console.Write("Lütfen yukarıdaki ürünlerden istediğinizin sayısını giriniz: ");
            int product = int.Parse(Console.ReadLine());
            switch (product)
            {
                case 1:
                    total += price[0];
                    break;

                case 2:
                    total += price[1];
                    break;

                case 3:
                    total += price[2];
                    break;

                case 4:
                    total += price[3];
                    break;

                case 5:
                    total += price[4];
                    break;

                case 6:
                    total += price[5];
                    break;

                case 7:
                    total += price[6];
                    break;

                case 8:
                    total += price[7];
                    break;

                default:
                    System.Console.WriteLine("Lütfen var olan ürün numarası giriniz!");
                    break;


            }

            System.Console.WriteLine(" Ürün eklemeye devam etmek için 'ENTER' tuşuna basınız.\nÜrün seçme işleminiz bittiğinde 'T' tuşuna tıklayarak toplam ücret tutarını görebilirsiniz.");
            string key = Console.ReadLine();
            exit = key.ToUpper();
        }
        System.Console.WriteLine($"Sepet tutarı: {total}");




    }
}
