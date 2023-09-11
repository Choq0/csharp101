// Diziler 

internal class Program
{
    private static void Main(string[] args)
    {
        string[] renkler = new string[5];

        string[] hayvanlar = { "Kedi", "Köpek", "At", "Aslan" };
        renkler[0] = "Kırmızı";
        renkler[1] = "Yeşil";

        Console.WriteLine(renkler[1]);
        Console.WriteLine(hayvanlar[2]);

        // Klavyeden alınan N tane sayının ortalamasını hesaplayan Program

        Console.Write("Lütfen dizinin eleman sayısını giriniz :");

        int diziuzunlugu = int.Parse(Console.ReadLine());

        int[] sayidizisi = new int[diziuzunlugu]; // Bu komutla kullanıcının girdiği eleman sayısını işlemiş oluyor.

        for (int i = 0; i < diziuzunlugu; i++) 
        {
            
            Console.Write("Lütfen {0}. sayısını giriniz:", i + 1);
            sayidizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0 ;
            foreach ( var sayi in sayidizisi)
            toplam += sayi ;

        Console.WriteLine("Ortalama:" +toplam/diziuzunlugu) ;  
    }
}
