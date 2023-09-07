internal class Program
{
    static void Main(string[] args)
    {
        {// Ekrandan girilen sayıya kadar 0'dan itibaren yazdırır.
            Console.Write("Bir değer giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
                Console.WriteLine(i);
        }


        // 1 ile 100 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.

        int tekToplam = 0;
        int ciftToplam = 0 ;
        for (int i = 0; i <=100; i++)
        {
            if(i%2 ==1 )
                tekToplam +=i;

            else
                ciftToplam += i; 
            

        }
        Console.WriteLine(tekToplam);
        Console.WriteLine(ciftToplam);


        //Break ve continue 

        for (int i = 1; i <= 10 ; i++)
        {
            if (i ==6 )
                continue ; // break komutu ile 6'ya geldiğinde yazdırmayı bırakır continue komutu ile 6'yı atlayıp devam eder.
            Console.WriteLine(i);
        }        
    }

}
