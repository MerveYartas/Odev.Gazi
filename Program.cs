namespace Odev.Gazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seviye; \n kolay \n orta \n zor ");

            Console.WriteLine("Yukardaki seviyelerden birini seçiniz?");
            string cvp = Console.ReadLine();

            if (cvp == "kolay")
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 10);
                int counter = 0;
                int unumber;
                Console.WriteLine("1'den 10'a kadar bir sayı söyleyiniz");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Sayıyı giriniz :");
                    unumber = int.Parse(Console.ReadLine());
                    counter++;
                    if (unumber == number)
                    {
                        Console.WriteLine("Tebrikler kazandınız, puanınız=>100");
                        break;
                    }
                    else if (counter < 3)
                    {
                        Console.WriteLine("Üzgünüm tutmadı,tekrar deneyiniz");
                    }
                    else if (counter == 3)
                    {
                        Console.WriteLine("Oyuncu canınız kalmadı:(");
                    }


                }
            }
            if (cvp == "orta")
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 20);
                int counter = 0;
                int unumber;
                Console.WriteLine("1'den 20'ye kadar bir sayı söyleyiniz");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Sayıyı giriniz:");
                    unumber = int.Parse(Console.ReadLine());
                    counter++;
                    if (unumber == number)
                    {
                        Console.WriteLine("Tebrikler kazandınız, puanınız=>100");
                        break;
                    }
                    else if (counter < 3)
                    {
                        Console.WriteLine("Üzgünüm tutmadı,tekrar deneyiniz");
                    }
                    else if (counter == 3)
                    {
                        Console.WriteLine("Oyuncu canınız kalmadı:(");
                    }

                }
            }
            if (cvp == "zor")
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 30);
                int counter = 0;
                int unumber;
                Console.WriteLine("1'den 30'a kadar bir sayı söyleyiniz");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Sayıyı giriniz:");
                    unumber = int.Parse(Console.ReadLine());
                    counter++;
                    if (unumber == number)
                    {
                        Console.WriteLine("Tebrikler kazandınız, puanınız=>100");
                        break;
                    }
                    else if (counter < 3)
                    {
                        Console.WriteLine("Üzgünüm tutmadı,tekrar deneyiniz");
                    }
                    else if (counter == 3)
                    {
                        Console.WriteLine("Oyuncu canınız kalmadı:(");
                    }
                }
            }
        }
    }
}