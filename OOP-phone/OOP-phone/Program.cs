using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
/*
namespace OOP_phone
{
    internal class Program
    {
        private static object basadon1;


       

        static void Main(string[] args)
        {


            xioami xioami = new xioami();
            samsung samsung = new samsung();
            iphone iphone = new iphone();
          
            while (true)
            {
            basadon1:
                Console.Clear();
                Console.WriteLine("lütfen incelemek istediginiz markayı giriniz.çıkmak için 4 e basınız.");
                Console.WriteLine("1-iphone 2-xioami 3-samsung");


                while (true)
                {

                    string secim = null;
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                    basadon:
                        Console.Clear();
                        iphone.iphonemodelleri();
                        while (true)
                        {
                            string secim1 = null;
                            secim1 = Console.ReadLine();
                            if (secim1 == "1")
                            {
                                iphone.iphonex();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }
                            }
                            else if (secim1 == "2")
                            {
                                iphone.iphone11();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }
                            }
                            else if (secim1 == "3")
                            {
                                iphone.iphone14();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }
                            }
                            else if (secim1 == "4")
                            {
                                Environment.Exit(0);
                            }
                            else if (secim1 == "5")
                            {
                                goto basadon1;
                            }
                            else
                            {
                                Console.WriteLine("hatalı giriş.Enter a bas.");
                                Console.ReadKey();
                                Console.Clear();
                                goto basadon;
                            }
                            
                        }
                    }
                    else if (secim == "2")
                    {
                    basadon:
                        Console.Clear();
                        xioami.xioamimodelleri();

                        while (true)
                        {

                            string secim1 = null;
                            secim1 = Console.ReadLine();
                            if (secim1 == "1")
                            {
                                xioami.Redmi9();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }

                            }
                            else if (secim1 == "2")
                            {
                                xioami.Redmi10();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }

                            }
                            else if (secim1 == "3")
                            {
                                xioami.note10();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }

                            }
                            else if (secim1 == "4")
                            {
                                Environment.Exit(0);
                            }
                            else if (secim1 == "5")
                            {
                                goto basadon1;
                            }
                            else
                            {
                                Console.WriteLine("hatalı giriş.Enter a bas.");
                                Console.ReadKey();
                                Console.Clear();
                                goto basadon;
                            }
                          
                        }
                    }
                    else if (secim == "3")
                    {
                    basadon:
                        Console.Clear();
                        samsung.samsungmodelleri();

                        while (true)
                        {
                            string secim1 = null;
                            secim1 = Console.ReadLine();
                            if (secim1 == "1")
                            {
                                samsung.s22();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }

                            }
                            else if (secim1 == "2")
                            {
                                samsung.note10();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }

                            }
                            else if (secim1 == "3")
                            {
                                samsung.note11();
                                string secim2 = null;
                                secim2 = Console.ReadLine();
                                if (secim2 == "5")
                                {
                                    goto basadon;
                                }
                            }
                            else if (secim1 == "4")
                            {
                                Environment.Exit(0);
                            }
                            else if (secim1 == "5")
                            {
                                goto basadon1;
                            }
                            else
                            {
                                Console.WriteLine("hatalı giriş.Enter a bas.");
                                Console.ReadKey();
                                Console.Clear();
                                goto basadon;
                            }
                            
                        }
                    }
                    else if (secim == "4")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("hatalıı giriş.enter a bas.");
                        Console.ReadKey();
                    }
                    goto basadon1;
                }
            }
              
            }
        }
    }
*/





namespace OOP_phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            xioami xioami = new xioami();
            samsung samsung = new samsung();
            iphone iphone = new iphone();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lütfen incelemek istediğiniz markayı giriniz. Çıkmak için 4'e basınız.");
                Console.WriteLine("1-iphone 2-xioami 3-samsung");

                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        iphone.iphonemodelleri();
                        string secim1 = Console.ReadLine();

                        switch (secim1)
                        {
                            case "1":
                                iphone.iphonex();
                                break;
                            case "2":
                                iphone.iphone11();
                                break;
                            case "3":
                                iphone.iphone14();
                                break;
                            case "4":
                                Environment.Exit(0);
                                break;
                            case "5":
                                break;
                        
                            default:
                                Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                Console.ReadKey();
                                break;
                        }
                        if (secim1 == "5")
                            break;
                        string secim2 = Console.ReadLine();
                        switch(secim2)
                        {
                            case "4":
                             Environment.Exit(0);
                                break;
                            case "5":
                            break;
                            default:
                                Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                Console.ReadKey();
                                break;
                        }

                    }
                }
                else if (secim == "2")
                {
                    while (true)
                    {
                        Console.Clear();
                        xioami.xioamimodelleri();
                        string secim1 = Console.ReadLine();

                        switch (secim1)
                        {
                            case "1":
                                xioami.Redmi9();
                                break;
                            case "2":
                                xioami.Redmi10();
                                break;
                            case "3":
                                xioami.note10();
                                break;
                            case "4":
                                Environment.Exit (0);
                                break;
                            case "5":
                                break;
                            default:
                                Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                Console.ReadKey();
                                break;
                        }
                        if (secim1 == "5")
                            break;

                    }
                }
                else if (secim == "3")
                {
                    while (true)
                    {
                        Console.Clear();
                        samsung.samsungmodelleri();
                        string secim1 = Console.ReadLine();

                        switch (secim1)
                        {
                            case "1":
                                samsung.s22();
                                break;
                            case "2":
                                samsung.note10();
                                break;
                            case "3":
                                samsung.note11();
                                break;
                            case "4":
                                Environment.Exit(0);
                                break;
                            case "5":
                                break;
                            default:
                                Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                Console.ReadKey();
                                break;
                        }
                        if (secim1 == "5")
                            break;


                    }
                }
                else if (secim == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hatalı giriş. Enter'a bas.");
                    Console.ReadKey();
                }
            }
        
        }
    }
}
