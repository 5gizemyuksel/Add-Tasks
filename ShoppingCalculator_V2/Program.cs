namespace ShoppingCalculator_V2;

class Program
{
    static void Main(string[] args)
    {
        string[] shopList = { "deterjan", "yağ", "yumuşatıcı", "zeytin", "peynir", "kaşar", "süt", "yumurta", "şampuan", "diş macunu" };

        int[] price = { 300, 350, 100, 50, 120, 250, 30, 75, 100, 60 };
        int total = 0;
        int counter = 0;

        for (int i = 0; i < shopList.Length; i++)
        {
            System.Console.WriteLine($"{i + 1}. Ürün {shopList[i]} = {price[i]} TL ");
        }

        System.Console.Write("Kaç tane ürün almak istediğinizi giriniz: ");
        int shopping = int.Parse(Console.ReadLine());


        string[] choosenProduct = new string[shopping];

        for (int i = 0; i < shopping; i++)
        {
            System.Console.Write("Almak istediğiniz ürün numarasını giriniz: ");
            int choose = int.Parse(Console.ReadLine());
            total += price[choose - 1];

            choosenProduct[i] = shopList[choose - 1];

        }

        System.Console.WriteLine("Sepetinizdeki Ürünler;");

        foreach (string item in choosenProduct)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine($"Toplam Sepet Tutarı: {total}");






    }
}
