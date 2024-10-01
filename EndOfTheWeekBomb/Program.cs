using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfTheWeekBomb
{
    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            
            //1. Konsola "Merhaba Dünya" yazdıran bir program yazın.
            Console.WriteLine("1.) Hello World.");
            Console.WriteLine("---------------------------");

            //2. Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.
            Console.Write("2.) Lütfen bir sayı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("    Lütfen ikinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"Toplam: {toplam} ");
            Console.WriteLine("---------------------------");
            Console.WriteLine();


            //3. Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.
            Console.Write("Lütfen yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("3.) ");
            string yetiskinMi = (yas >= 18) ? "Yetişkinsiniz" : "Çocuksunuz";
            Console.WriteLine(yetiskinMi);
            Console.WriteLine("---------------------------");
            Console.WriteLine();


            //4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("4.) ");
            string çiftMi = (sayi3 % 2 ==0) ? "Sayı çift sayıdır." : "Sayı tek sayıdır.";
            Console.WriteLine(çiftMi);
            Console.WriteLine("---------------------------");
            Console.WriteLine();


            //5. Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın.

            Console.WriteLine("Lütfen bir sıcaklık değeri girin.(Celcius Cinsinden)");
            int sicaklik = Convert.ToInt32(Console.ReadLine());
            Console.Write("5.) ");
            if (sicaklik < 0)
            {
                Console.WriteLine("Donuyor.");
            }
            else if (sicaklik >= 0 && sicaklik <= 30)
            {
                Console.WriteLine("Normal");
            }
            else
            {
                Console.WriteLine("Yanıyor");
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine();


            //6. Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor.
            //Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.

                Başla:
                Console.WriteLine("6.) Lütfen gün seçmek için 1 - 7 arasınd bir sayı giriniz.");       

                int gunNo = Convert.ToInt32(Console.ReadLine());


                if (gunNo >= 1 && gunNo <= 7)
                {
                    switch ((Gunler)gunNo)
                    {
                        case Gunler.Pazartesi:
                            Console.WriteLine("Pazartesi");
                            break;
                        case Gunler.Salı:
                            Console.WriteLine("Salı");
                            break;
                        case Gunler.Çarşamba:
                            Console.WriteLine("Çarşamba");
                            break;
                        case Gunler.Perşembe:
                            Console.WriteLine("Perşembe");
                            break;
                        case Gunler.Cuma:
                            Console.WriteLine("Cuma");
                            break;
                        case Gunler.Cumartesi:
                            Console.WriteLine("Cumartesi");
                            break;
                        case Gunler.Pazar:
                            Console.WriteLine("Pazar");
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Geçersiz gün");

                     goto Başla; 
                }
                Console.WriteLine("---------------------------");
                Console.WriteLine();

                

            //7. Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın.
            //(0-60 başarısız, 61-80 orta, 81-100 başarılı)
            BaslaNot:
            Console.Write("7.) Lütfen Notunuzu Giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());

            if (not >= 0 && not <= 100)

            {
                if (not >=0 && not <=60)
                {
                    Console.WriteLine("Başarısız.");
                }
                else if (not >= 61 && not <= 80)
                {
                    Console.WriteLine("Orta");
                }
                else 
                {
                    Console.WriteLine("Başarılı");
                }

            }
            else 
            {
                Console.WriteLine("Geçersiz Not\n");

                goto BaslaNot;
            }

            

            //8. Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.
            Console.Write("8.) Lütfen görmek istediğiniz ay için 1 - 12 arasında bir sayı girin: ");
            int ayNumarasi = int.Parse(Console.ReadLine());

            int gunSayisi;
            string ayAdi = "";

            switch (ayNumarasi)
            {
                case 1:
                    gunSayisi = 31;
                    ayAdi = "Ocak";
                    break;
                case 2:
                    gunSayisi = 28;
                    ayAdi = "Şubat";
                    break;
                case 3:
                    gunSayisi = 31;
                    ayAdi = "Mart";
                    break;
                case 4:
                    gunSayisi = 30;
                    ayAdi = "Nisan";
                    break;
                case 5:
                    gunSayisi = 31;
                    ayAdi = "Mayıs";
                    break;
                case 6:
                    gunSayisi = 30;
                    ayAdi = "Haziran";
                    break;
                case 7:
                    gunSayisi = 31;
                    ayAdi = "Temmuz";
                    break;
                case 8:
                    gunSayisi = 31;
                    ayAdi = "Ağustos";
                    break;
                case 9:
                    gunSayisi = 30;
                    ayAdi = "Eylül";
                    break;
                case 10:
                    gunSayisi = 31;
                    ayAdi = "Ekim";
                    break;
                case 11:
                    gunSayisi = 30;
                    ayAdi = "Kasım";
                    break;
                case 12:
                    gunSayisi = 31;
                    ayAdi = "Aralık";
                    break;
                default:
                    Console.WriteLine("Geçersiz bir ay numarası girdiniz.");
                    Console.Read();
                    return;

            }
            Console.WriteLine($"{ayAdi} ayı {gunSayisi} gündür.");

            

            //9. Kullanıcıdan bir şifre isteyin.
            //Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.

            Console.Write("9.) Lütfen şifrenizi giriniz: ");
            string password = Console.ReadLine();


            string dogruMu = (password == "12345" ? "Parola Doğru" : "Parola Geçersiz");
            Console.WriteLine(dogruMu);

            

            //10Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.

            Console.Write("10.) Birinci sayıyı giriniz: ");
            double ilkSayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("     İkinci sayıyı giriniz: ");
            double ikinciSayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bir işlem seçin (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());
            double sonuc;

            switch (islem)
            {
                case '+':
                    sonuc = ilkSayi + ikinciSayi; 
                    Console.WriteLine($"Sonuç: {ilkSayi} + {ikinciSayi} = {sonuc}");
                    break;
                case '-':
                    sonuc = ilkSayi - ikinciSayi;
                    Console.WriteLine($"Sonuç: {ilkSayi} - {ikinciSayi} = {sonuc}");
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi;
                    Console.WriteLine($"Sonuç: {ilkSayi} * {ikinciSayi} = {sonuc}");
                    break;
                case '/':
                    if (ikinciSayi != 0)
                    {
                        sonuc = ilkSayi / ikinciSayi;
                        Console.WriteLine($"Sonuç: {ilkSayi} / {ikinciSayi} = {sonuc}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hata: 0'a bölme yapılamaz!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }





            Console.Read();
        }
    }
}
