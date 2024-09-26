namespace CalculatorAplication_V1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen kaç rakam toplamak istediğinizi giriniz: ");
        int number = int.Parse(Console.ReadLine());
        System.Console.WriteLine();
        System.Console.WriteLine();


        int total = 0;
        int average = 0;



        System.Console.WriteLine("Lütfen toplamak ve ortalamasını bulmak isteediğiniz rakamları giriniz: ");


        for (int i = 1; i <= number; i++)
        {

            System.Console.Write($"Rakam {i}: ");
            int numbers = int.Parse(Console.ReadLine());

            total += numbers;
        }
        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine($"Rakamlar Toplamı: {total}");

        System.Console.WriteLine();
        System.Console.WriteLine();

        average = total / number;

        System.Console.WriteLine($"Rakamların Ortalaması: {average}");
    }
}
