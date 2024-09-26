namespace ShoppingCalculator_V4;

class Program
{
    static void Main(string[] args)
    {

        string[] shopList = { "Deterjan", "Yağ", "Yumuşatıcı", "Zeytin", "Peynir", "Kaşar", "Süt", "Yumurta", "Şampuan", "Diş Macunu" };

        int[] price = { 300, 350, 100, 50, 120, 250, 30, 75, 100, 60 };
        int total = 0;
        int counter = 0;

        int[] stock = { 5, 5, 5, 5, 5, 10, 10, 10, 10, 10 };

        for (int i = 0; i < shopList.Length; i++)
        {
            System.Console.WriteLine($"{i + 1}. Ürün: {shopList[i]} | Ürün Stok Sayısı: {stock[i]} | Ürün Ücreti: {price[i]} TL ");
        }

        System.Console.Write("Kaç tane ürün almak istediğinizi giriniz: ");
        int shopping = int.Parse(Console.ReadLine());


        string[] choosenProduct = new string[shopping];
        int[] choosenStock = new int[shopping];

        for (int i = 0; i < shopping; i++)
        {
            System.Console.Write("Almak istediğiniz ürün numarasını giriniz: ");
            int choose = int.Parse(Console.ReadLine());
            System.Console.Write("Bu üründen kaç adet almak istediğinizi giriniz:");
            int chooseStock = int.Parse(Console.ReadLine());


            choosenProduct[i] = shopList[choose - 1];
            choosenStock[i] = chooseStock;

            total += (price[choose - 1] * choosenStock[i]);

        }

        System.Console.WriteLine("Sepetinizdeki Ürünler;");

        foreach (string item in choosenProduct)
        {
            counter++;
            System.Console.WriteLine(counter + ". Ürün:" + " " + item);
        }
        System.Console.WriteLine("Sepetinizdeki ürünlerden kaç tane eklediğiniz: ");
        for (int i = 0; i < choosenStock.Length; i++)
        {
            counter++;
            System.Console.WriteLine($"{choosenProduct[i]} ürününden {choosenStock[i]} tane sepete eklendi.");
        }



        System.Console.WriteLine($"Toplam Sepet Tutarı: {total} TL");
        System.Console.Write("Kaç TL ödeme yapacaksınız: ");
        int pay = int.Parse(Console.ReadLine());

        int paid = pay - total;
        System.Console.Write($"Para Üstü: {paid}");
    }
}
