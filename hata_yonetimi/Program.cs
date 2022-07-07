using System;

namespace hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            // Console.WriteLine("Bir Sayi Giriniz");
            // int sayi = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Girilen Sayi: " + sayi);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata" + ex.Message.ToString());

            // }
            // finally
            // {
            //     Console.WriteLine("İşlem Tamamlandı");
            // }

            try
            {
                int sayi2 = int.Parse("abc");
                Console.WriteLine(sayi2);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format Uygun Değil");
                Console.WriteLine(ex);
            }


            
        }
    }
}