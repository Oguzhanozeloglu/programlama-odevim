using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hesapmakinesi.cs
  {
    class Program
    {
      Static void Main(string[] args)
      {
        byte secim;
        double sayi1,sayi2,sonuç;
        Console.WriteLine("1.Toplama");
        Console.WriteLine("2.Çıkarma");
        Console.WriteLine("3.Çarpma");
        Console.WriteLine("4.Bölme");
        Console.WriteLine("--------");
        Console.WriteLine("İşlem tipini seçiniz (1-4) :");
        secim = Convert.ToByte(Console.ReadLine());
        if (secim == 1)
        {
        Console.Clear();
        Console.WriteLine("***********************");
        Console.WriteLine("* Seçilen işlem TOPLAMA işlemi *");
        Console.WriteLine("***********************");
        Console.Write("1.Sayıyı giriniz:");
        sayı1 = Convert.ToDouble(Console.ReadLine ());
        Console.Write("2.Sayıyı giriniz:");
        sayı2 = Convert.ToDouble(Console.ReadLine());
        sonuc = sayı1 + sayı2;
        Console.Write("Sonuc={0}", sonuc);
      }
      else if (secim == 2)
      {
        Console.Clear();
        Console.WriteLine("*************************");
        Cosnsole.WriteLine("* Seçilen işlem ÇIKARMA işlemi *");
        Console.WriteLine("*************************");
        Console.Write("1.Sayıyı giriniz:");
        sayı1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2.Sayıyı giriniz:");
        sayi2 = Convert.ToDouble(Console.ReadLine());
        sonuc = sayı1 - sayı2;
        Console.Write("Sonuc={0}", sonuc);
      }
      else if (secim == 3)
      {
        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("* Seçilen işlem ÇARPMA işlemi *");
        Console.WriteLine("**************************");
        Console.Write("1.Sayıyı giriniz:");
        sayı1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2.Sayıyı giriniz:");
        sayı2 = Convert.ToDouble(Console.ReadLine());

        sonuc = sayi1 * sayi2;
        Console.Write("Sonuç{0}", sonuc);
      }
      else if (secim == 4)
      {
        Console.Clear();
        Console.WriteLine("****************************");
        Console.WriteLine("* Seçilen işlem ÇIKARMA işlemi *");
        Console.WriteLine("****************************");
        Console.Write("1.Sayıyı giriniz:");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2.Sayıyı giriniz:");
        sayi2 = Convert.ToDouble(Console.ReadLine());
        if (sayi2 != 0
        {
          sonuc = sayi1 / sayi2;
          Console.Wtite("Sonuc={0}", sonuc);
        }
        else
        ConsoleWriteLine("!!! SIFIRA BÖLME HATASI !!!");
      }
      Console.ReadLine();
