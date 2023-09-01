internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Girdiğiniz sayı = " + sayi);
        }

        catch (Exception ex)

        {
            Console.WriteLine("Hata:" + ex.Message.ToString());
        }

        finally
        {Console.WriteLine("İşlem tamamlandı");
    
        }
        
    }
}
