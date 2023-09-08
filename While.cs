using System ;

    class Program 

    {
        static void Main(string[] args)

        {

            // While // Kullanıcıdan alınan değere kadar 0'dan başlayarak tek tek sayıları yazar.
            Console.Write("Bir değer giriniz:");
            int sayi = int.Parse(Console.ReadLine()) ;
            int sayac = 0 ;
            while( sayac <sayi )

            {
                sayac ++ ;

                Console.WriteLine(sayac);
            }

        

        }
    }
