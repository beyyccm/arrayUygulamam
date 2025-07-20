using System;

class Program
{
    static void Main()
    {
        // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlanıyor
        int[] sayilar = new int[10];

        // 2 - Dizi elemanlarını for döngüsü ile kullanıcıdan alıyoruz
        Console.WriteLine("10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Foreach döngüsü ile dizi elemanlarını ekrana yazdırıyoruz
        Console.WriteLine("\nGirdiğiniz sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }

        // 3 - Kullanıcıdan alınan yeni değeri diziye (11. eleman olarak) ekliyoruz
        Console.WriteLine("\n\nYeni bir sayı giriniz (11. sayı): ");
        int yeniSayi = Convert.ToInt32(Console.ReadLine());

        // Yeni sayı ile birlikte yeni bir dizi tanımlıyoruz
        int[] yeniDizi = new int[sayilar.Length + 1];

        // Eski dizinin elemanlarını yeni diziye kopyalıyoruz
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }

        // Yeni elemanı dizinin sonuna ekliyoruz
        yeniDizi[yeniDizi.Length - 1] = yeniSayi;

        // 4 - Diziyi büyükten küçüğe sıralayıp ekrana yazdırıyoruz
        Array.Sort(yeniDizi);            // Küçükten büyüğe sıralar
        Array.Reverse(yeniDizi);         // Sıralamayı ters çevirerek büyükten küçüğe yapar

        Console.WriteLine("\nBüyükten küçüğe sıralanmış hali:");
        foreach (int sayi in yeniDizi)
        {
            Console.Write(sayi + " ");
        }

        Console.WriteLine(); // Alt satıra geçmek için
    }
}
