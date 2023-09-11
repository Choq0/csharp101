using System ;

    class Program 

    {
        static void Main(string[] args)

        {
            // Sort
            int [] sayidizisi = {5,41,50,14,12,16,10,25,27} ;

            foreach( var sayi in sayidizisi) 
                Console.WriteLine(sayi) ;

            // Sıralı 
            Console.WriteLine("Bu da sıralı listemiz :") ;

            Array.Sort(sayidizisi) ;

            foreach(var sayi in sayidizisi)
                Console.WriteLine(sayi) ;

            //Reverse (Dizini tersten sıralar)

            Console.WriteLine("Bu da büyükten küçüğe sıralı listemiz:") ;

            Array.Reverse(sayidizisi) ;

            foreach( var sayi in sayidizisi)
                Console.WriteLine(sayi) ;

            // IndexOf
            Console.WriteLine("Dizinde sorgulattığınız sayının kaçıncı elaman olduğunu dönen method :") ;
            Console.WriteLine(Array.IndexOf(sayidizisi,16));
            

        }
    }
