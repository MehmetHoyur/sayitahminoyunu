using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.SayiTahmin.App
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                Console.WriteLine("Seviye seçiniz \n 1-) Seviye 1 \n 2-) Seviye 2 \n 3-) Seviye 3");
                int seviye;
                seviye = char.Parse(Console.ReadLine());


                if (seviye == '1')
                {
                    Console.WriteLine("Seviye 1 e yönlendiriliyorsunuz");
                    seviye1();
                }
                else if (seviye == '2')
                {
                    Console.WriteLine("Seviye 2 e yönlendiriliyorsunuz");
                    seviye2();
                }
                else if (seviye == '3')

                {
                    Console.WriteLine("Seviye 3 e yönlendiriliyorsunuz");
                    seviye3();
                }



                else
                {
                    Console.WriteLine("1 ve 3 areasında bir sayı giriniz");
                }
                void seviye1()//Fonksiyon Tanımlama 
                {
                    Console.WriteLine("Sayı Tahmin oyununa Hoş Geldiniz");


                    int belirlenen, tahmin, hak = 4;
                    Random rnd = new Random(); //Rastgele Sayı Belirlemek İçin
                    belirlenen = rnd.Next(1, 10);//tahmin aralığı 
                    Console.WriteLine("Seviye 1'e Hoşgeldiniz bu etapta 6 adet hakkınız bulunmaktadır");

                    while (true)//1. Seviye
                    {
                        if (hak == 0)
                        {
                            Console.WriteLine("hakkınız bitti");
                            seviye1();//Fonksiyon Yönlendirme 


                        }

                        Console.WriteLine("1-10 arasında bir sayı giriniz");
                        tahmin = int.Parse(Console.ReadLine());
                        if (belirlenen == tahmin)
                        {
                            Console.WriteLine("Tebrikler Bildiniz");

                            seviye2();


                        }
                        else if (belirlenen > tahmin)
                        {
                            Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                        }
                        else
                        {
                            Console.WriteLine("Daha küçük bir sayı giriniz");
                        }
                        hak--;
                        Console.WriteLine("Kalan tahmin hakkınız; " + hak);

                    }
                }


                void seviye2()
                {

                    Console.WriteLine("Seviye 2' ye Hoşgeldiniz Bu Etapta 4 adet Hakkınız Bulunmaktadır");


                    int belirlenen2, tahmin2, hak2 = 6;
                    Random rnd2 = new Random();
                    belirlenen2 = rnd2.Next(1, 25);

                    while (true) //2.seviye
                    {
                        if (hak2 == 0)
                        {
                            Console.WriteLine("hakkınız bitti");
                            seviye2();


                        }

                        Console.WriteLine("1-25 arasında bir sayı giriniz");
                        tahmin2 = int.Parse(Console.ReadLine());
                        if (belirlenen2 == tahmin2)
                        {
                            Console.WriteLine("Tebrikler Bildiniz");

                            seviye3();

                        }
                        else if (belirlenen2 > tahmin2)
                        {
                            Console.WriteLine("Daha Büyük Bir SAyı Giriniz");
                        }
                        else
                        {
                            Console.WriteLine("Daha küçük bir sayı giriniz");
                        }
                        hak2--;
                        Console.WriteLine("Kalan tahmin hakkınız; " + hak2);
                    }
                }


                void seviye3()
                {
                    Console.WriteLine("Seviye 3 e Hoş Geldiniz bu etapta 2 adet hakkınız bulunmaktadır");


                    int belirlenen3, tahmin3, hak3 = 10;
                    Random rnd3 = new Random(); //Rastgele Sayı Belirlemek İçin
                    belirlenen3 = rnd3.Next(1, 50);//tahmin aralığı 

                    while (true) //3. Seviye
                    {
                        if (hak3 == 0)
                        {
                            Console.WriteLine("hakkınız bitti");
                            break;
                        }

                        Console.WriteLine("1-50 arasında bir sayı giriniz");
                        tahmin3 = int.Parse(Console.ReadLine());
                        if (belirlenen3 == tahmin3)
                        {
                            Console.WriteLine("Tebrikler Bildiniz");
                            bitis();

                        }
                        else if (belirlenen3 > tahmin3)
                        {
                            Console.WriteLine("Daha Büyük Bir SAyı Giriniz");
                        }
                        else
                        {
                            Console.WriteLine("Daha küçük bir sayı giriniz");
                        }
                        hak3--;
                        Console.WriteLine("Kalan tahmin hakkınız " + hak3);
                    }





                }
                void bitis()
                {
                    Console.WriteLine("Oyunumuz Bitmiştir Oynadığınız için Teşekkürler");
                    Console.WriteLine("Tekrar oynamak için '1' e basınız\n Programı sonlandırmak için '0' a basınız");
                    int Tekrar;
                    Tekrar = int.Parse(Console.ReadLine());
                    if (Tekrar == 1)
                    {
                        seviye1();
                    }
                    else
                    {

                        Environment.Exit(0);
                    }
                }
            }

        }


    }
}
    



