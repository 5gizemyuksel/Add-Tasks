namespace CalculatorApplication_V2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Hangi İşlemi Yapmak İstersiniz(+,-,*,/ | işlem işareti giriniz!):");
        string key = Console.ReadLine();
        System.Console.WriteLine();

        System.Console.Write("Kaç adet rakam ile işlem yapacaksınız: ");
        int number = int.Parse(Console.ReadLine());
        System.Console.WriteLine();



        System.Console.WriteLine("İşlem yapmak istediğiniz rakamları giriniz: ");

        System.Console.Write($"Rakam 1: ");
        int result = int.Parse(Console.ReadLine());
        int total = result;
        int extraction = result;
        int split = result;
        int multiply = result;


        for (int i = 2; i <= number; i++)
        {
            System.Console.Write($"Rakam {i}: ");
            int numbers = int.Parse(Console.ReadLine());
            if (key == "+")
            {
                total += numbers;
                System.Console.WriteLine($"Toplam: {total}");

            }
            if (key == "-")
            {

                extraction -= numbers;
                System.Console.WriteLine($"Çıkarma: {extraction}");

            }
            if (key == "/" && i != 0)
            {
                split /= numbers;
                System.Console.WriteLine($"Bölme: {split}");

            }
            if (key == "*")
            {
                multiply *= numbers;
                System.Console.WriteLine($"Çarpma: {multiply}");
            }

        }




    }
}
