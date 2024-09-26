using System.Formats.Asn1;
using System.Numerics;

namespace CalculatorApplication_V3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Öncelikle bir rakam giriniz: ");
        double number = int.Parse(Console.ReadLine());
        System.Console.WriteLine();



        double total = number;
        double extraction = number;
        double divide = number;
        double multiply = number;


        System.Console.WriteLine("Programı sonlandırmak için 'E' tuşuna basınız.");

        string exit = "";

        do
        {
            System.Console.Write("Yapmak istediğiniz işlemi seçiniz(+,-,/,*): ");
            string opeariton = Console.ReadLine();

            System.Console.Write("İşlem için rakam giriniz: ");

            double numbers = double.Parse(Console.ReadLine());


            if (opeariton.ToUpper() == "E")
            {
                break;
            }
            else if (opeariton == "+")
            {
                total += numbers;
                System.Console.WriteLine($"Toplam: {total}");
            }
            else if (opeariton == "-")
            {
                extraction -= numbers;
                System.Console.WriteLine($"Çıkarma: {extraction}");
            }
            else if (opeariton == "/" && numbers != 0)
            {
                divide /= numbers;
                System.Console.WriteLine($"Bölüm: {divide}");

            }
            else if (opeariton == "*")
            {
                multiply *= numbers;
                System.Console.WriteLine($"Çarpım: {multiply}");
            }
            else
            {
                System.Console.WriteLine("Geçersiz işlem seçimi. Lütfen +, -, /, * işlemlerinden birini seçiniz.");
            }

            System.Console.WriteLine("Devam etmek için bir tuşa basın, çıkmak için 'E' tuşuna basın.");
            exit = Console.ReadLine(); // Kullanıcı çıkmak istediğinde 'E' tuşuna basabilir.



        } while (exit.ToUpper() != "E");
        System.Console.WriteLine("Program sonlandırıldı!");
    }
}
