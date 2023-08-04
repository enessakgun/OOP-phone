using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_phone
{
  
      public class sqlconnection
    {
            public  void InsertNewPhone(string marka, string model, int fiyat, string renk, int üretimyılı, int hafıza)
            {
                try
                {
                string connectionstring = (@"Data Source=(localdb)\MSSQLLocalDB;Database=phone; Integrated Security=True");

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO phoneInfos (marka, model, fiyat,renk,üretimyılı,hafıza) VALUES (@marka, @model, @fiyat, @renk,@üretimyılı,@hafıza)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@marka", marka);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@fiyat", fiyat);
                        command.Parameters.AddWithValue("@renk", renk);
                        command.Parameters.AddWithValue("@üretimyılı", üretimyılı);
                        command.Parameters.AddWithValue("@hafıza", hafıza);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Yeni telefon başarıyla eklendi.");
                            connection.Close();

                        }
                        else
                        {
                            Console.WriteLine("Telefon eklenirken bir hata oluştu.");
                            connection.Close();

                        }
                    }
                }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.ToString());
                }
            }
            public  void ShowAllPhones(SqlConnection connection)
            {
                try
                {
                    string selectQuery = "SELECT * FROM phoneInfos";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"ıd: {reader["ıd"]}, marka: {reader["marka"]}, model: {reader["model"]}, fiyat: {reader["fiyat"]}, renk: {reader["renk"]}, üretimyılı: {reader["üretimyılı"]}, hafıza: {reader["hafıza"]}");
                                Console.ReadKey();
                            }
                        }
                    }
                }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.ToString());
            }
        }
            private static void AddNewPhone()
            {
            Console.WriteLine("Marka:");
            string marka = Console.ReadLine();

            Console.WriteLine("Model:");
            string model = Console.ReadLine();

            Console.WriteLine("Fiyat:");
            int fiyat = int.Parse(Console.ReadLine());

            Console.WriteLine("Renk:");
            string renk = Console.ReadLine();

            Console.WriteLine("Üretim Yılı:");
            int üretimyılı = int.Parse(Console.ReadLine());

            Console.WriteLine("Hafıza:");
            int hafıza = int.Parse(Console.ReadLine());

            
            sqlconnection _sql = new sqlconnection();
            _sql.InsertNewPhone(marka, model, fiyat, renk, üretimyılı, hafıza);
        }

        public void sqlopen()
            {
                string connectionstring = (@"Data Source=(localdb)\MSSQLLocalDB;Database=phone; Integrated Security=True");

                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    try
                    {

                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                            Console.WriteLine("baglantı başarılı.");
                            Console.ReadKey();
                    }
                       
                        AddNewPhone();
                        ShowAllPhones(connection);
        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.ToString());
                    }
                    
                }

            }
        }
        
    }
    

