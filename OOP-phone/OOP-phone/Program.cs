﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_phone
{
    internal class Program
    {

        static void Main(string[] args)
        {

           

            anamenu:
            xioami xioami = new xioami();
            samsung samsung = new samsung();
            iphone iphone = new iphone();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("------ Telefon Uygulaması ------");
                Console.WriteLine("1 - Yeni telefon ekle");
                Console.WriteLine("2 - Varolan telefonları incele");
                Console.WriteLine("0 - Çıkış yap");
                Console.Write("Seçiminizi yapın: ");

                string secimana = Console.ReadLine();
                switch (secimana)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        Console.WriteLine("eklemek istedigin markayı seç 1-xioami-2-samsung-3-apple. ");
                        string markasec = Console.ReadLine();
                        switch (markasec)
                        {
                            case "1":
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            default:
                                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                                Console.ReadKey();
                                goto anamenu;
                        }


                        sqlconnection sqlconnection = new sqlconnection();
                        sqlconnection.sqlopen();
                        break;

                    case "2":

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
                                basadon:
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
                                            goto basadon;
                                    }
                                    if (secim1 == "5")
                                        break;
                                    basadon1:
                                    Console.WriteLine("cıkış için4 e bir üst menü için 5 e basınız.");
                                    string secim2 = Console.ReadLine();
                                    switch (secim2)
                                    {
                                        case "4":
                                            Environment.Exit(0);
                                            break;
                                        case "5":
                                            break;
                                        default:
                                            Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                            Console.ReadKey();
                                            goto basadon1;
                                    }

                                }
                            }
                            else if (secim == "2")
                            {
                                while (true)
                                {
                                basadon:
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
                                            Environment.Exit(0);
                                            break;
                                        case "5":
                                            break;
                                        default:
                                            Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                            Console.ReadKey();
                                            goto basadon;

                                    }
                                    if (secim1 == "5")
                                        break;
                                    basadon1:
                                    Console.WriteLine("cıkış için4 e bir üst menü için 5 e basınız.");
                                    string secim2 = Console.ReadLine();
                                    switch (secim2)
                                    {
                                        case "4":
                                            Environment.Exit(0);
                                            break;
                                        case "5":
                                            break;
                                        default:
                                            Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                            Console.ReadKey();
                                            goto basadon1;
                                    }

                                }
                            }
                            else if (secim == "3")
                            {
                                while (true)
                                {
                                basadon:
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
                                            goto basadon;
                                    }
                                    if (secim1 == "5")
                                        break;
                                    basadon1:
                                    Console.WriteLine("cıkış için 4 e bir üst menü için 5 basınız.");
                                    string secim2 = Console.ReadLine();
                                    switch (secim2)
                                    {
                                        case "4":
                                            Environment.Exit(0);
                                            break;
                                        case "5":
                                            break;
                                        default:
                                            Console.WriteLine("Hatalı giriş. Enter'a bas.");
                                            Console.ReadKey();
                                            goto basadon1;

                                    }

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
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        Console.ReadKey();
                        goto anamenu;

                }
                break;
                
            }
           

        }
    }
}


