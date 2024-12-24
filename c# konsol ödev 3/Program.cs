using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int[] numbers = new int[500];
        int[] primes = new int[500];
        int i = 0;
        int primeNumbers = 0;
        Random random = new Random();
        //diziler ve değişkenler atandı
        Console.Write("Rastgele Oluşturulan Dizi: ");
        for (i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(10000);
            Console.Write(numbers[i] + " ");//rastgele oluşturlan sayıları diziye dahil edip yazdırma
        }
        Console.Write("\nAsal Sayılar Dizisi:");
        for (i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            int primeCheck = 0;
            for (int x = 2; x <= Math.Sqrt(number); x++)
            {
                //asal sayı kontrolü
                if (number % x == 0)
                {
                    primeCheck += 1;
                    break; // eğer bir bölen bulunursa , döngüden çık sayı asal değildir.
                }
            }
            if (primeCheck == 0 && number > 1)
            {
                // primecheck değişmediyse asal sayı olduğunu anlarız.
                primes[primeNumbers] = number;
                primeNumbers++;
            }
        }
        for (i = 0; i < primeNumbers; i++)
        {
            Console.Write(primes[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Toplam Asal Sayı Adedi: " + primeNumbers);
    }
}