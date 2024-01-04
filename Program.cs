internal class Program
{
    private static void Main(string[] args)
    {
        // Console.Write("Lütfen bir sayı giriniz");
        // int sayac = int.Parse(Console.ReadLine());
        // for (int i = 0; i < sayac; i++)
        // {
        //     if (i % 2 == 1)
        //         Console.WriteLine(i);

        // }

        // int tekToplam = 0;
        // int ciftToplam = 0;

        // //  1 ile 1000 arasındaki tek ve çift sayıları kendi içinde topla
        // for (int i = 0; i < 1000; i++)
        // {
        //     if (i % 2 == 0)
        //         tekToplam += i;
        //     else
        //         ciftToplam += i;
        // }

        // Console.WriteLine("Tek toplam :" + tekToplam);
        // Console.WriteLine("Çift toplam :" + ciftToplam);

        // break , continue

        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
                break;
            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
                continue;
            Console.WriteLine(i);
        }
    }
}