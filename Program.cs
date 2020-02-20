using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Compare1
{


    public class Program
    {
        public static int modelA;
        public static int modelA2;
        public static int modelS;
        public static int modelS2;
        public static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-ADEUVRA;Initial Catalog=Phones;Integrated Security=True";

            Console.WriteLine("Выберите какой производитель вас интерисует: \n1.Apple \n2.Samsung");
            int brand = Convert.ToInt32(Console.ReadLine());

            if (brand == 1)
            {
                Console.WriteLine("Выберите модель:\n1.Iphone 11;\n2.Iphone 11 Pro;\n3.Iphone 11 Pro Max;\n4.Iphone X;\n5.Iphone XS;\n6.Iphone XR.");
                modelA = Convert.ToInt32(Console.ReadLine());
                if (modelA <= 0 || modelA >= 7)
                {
                    Console.WriteLine("Error! Unknown command. Please try again.");
                }
                Console.WriteLine("Выберите какой производитель вас интерисует: \n1.Apple \n2.Samsung");
                brand = Convert.ToInt32(Console.ReadLine());
                if (brand == 1)
                {
                    Console.WriteLine("Выберите модель:\n1.Iphone 11;\n2.Iphone 11 Pro;\n3.Iphone 11 Pro Max;\n4.Iphone X;\n5.Iphone XS;\n6.Iphone XR.");
                    modelA2 = Convert.ToInt32(Console.ReadLine());
                    if (modelA2 <= 0 || modelA2 >= 7)
                    {
                        Console.WriteLine("Error! Unknown command. Please try again.");
                    }
                    else
                    {
                        Choose();
                        Choose2();
                    }
                }
                else if (brand == 2)
                {
                    Console.WriteLine("Выберите модель:\n1.Galaxy S20;\n2.Galaxy S20 Plus;\n3.Galaxy S20 Ultra;\n4.Galaxy Note 10;\n5.Galaxy Note 10+;\n6.Galaxy S10;\n7.Galaxy S10+");
                    modelS2 = Convert.ToInt32(Console.ReadLine());
                    if (modelS2 <= 0 || modelS2 >= 8)
                    {
                        Console.WriteLine("Error! Unknown command. Please try again.");
                    }
                    else
                    {
                        Choose();
                        Choose3();
                    }

                }
                else
                {
                    Console.WriteLine("Error! Unknown command. Please try again.");
                }
            }else if (brand == 2)
            {
                Console.WriteLine("Выберите модель:\n1.Galaxy S20;\n2.Galaxy S20 Plus;\n3.Galaxy S20 Ultra;\n4.Galaxy Note 10;\n5.Galaxy Note 10+;\n6.Galaxy S10;\n7.Galaxy S10+");
                modelS2 = Convert.ToInt32(Console.ReadLine());
                if (modelS2 <= 0 || modelS2 >= 8)
                {
                    Console.WriteLine("Error! Unknown command. Please try again.");
                }
                Console.WriteLine("Выберите какой производитель вас интерисует: \n1.Apple \n2.Samsung");
                brand = Convert.ToInt32(Console.ReadLine());
                if (brand == 1)
                {
                    Console.WriteLine("Выберите модель:\n1.Iphone 11;\n2.Iphone 11 Pro;\n3.Iphone 11 Pro Max;\n4.Iphone X;\n5.Iphone XS;\n6.Iphone XR.");
                    modelA2 = Convert.ToInt32(Console.ReadLine());
                    if (modelA2 <= 0 || modelA2 >= 7)
                    {
                        Console.WriteLine("Error! Unknown command. Please try again.");
                    }
                    else
                    {
                        Choose3();
                        Choose2();
                    }
                }
                else if (brand == 2)
                {
                    Console.WriteLine("Выберите модель:\n1.Galaxy S20;\n2.Galaxy S20 Plus;\n3.Galaxy S20 Ultra;\n4.Galaxy Note 10;\n5.Galaxy Note 10+;\n6.Galaxy S10;\n7.Galaxy S10+");
                    modelS = Convert.ToInt32(Console.ReadLine());
                    if (modelS <= 0 || modelS >= 8)
                    {
                        Console.WriteLine("Error! Unknown command. Please try again.");
                    }
                    else
                    {
                        Choose3();
                        Choose4();
                    }

                }
                else
                {
                    Console.WriteLine("Error! Unknown command. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Error! Unknown command. Please try again.");
            }
            Console.ReadKey();
            void Choose() //метод якщо айфон кидають в порівняння першим
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlExpression = "SELECT * FROM [Apple] WHERE id ='" + modelA + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)} {reader.GetName(2)} {reader.GetName(3)} {reader.GetName(4)}" +
                            $" {reader.GetName(5)} {reader.GetName(6)} {reader.GetName(7)} {reader.GetName(8)} {reader.GetName(9)} {reader.GetName(10)} " +
                            $"{reader.GetName(11)} {reader.GetName(12)} {reader.GetName(13)}");



                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object model = reader.GetValue(1);
                            object screensize = reader.GetValue(2);
                            object screenres = reader.GetValue(3);
                            object screentype = reader.GetValue(4);
                            object ram = reader.GetValue(5);
                            object rom = reader.GetValue(6);
                            object os = reader.GetValue(7);
                            object frontcamera = reader.GetValue(8);
                            object camera = reader.GetValue(9);
                            object processor = reader.GetValue(10);
                            object cores = reader.GetValue(11);
                            object battery = reader.GetValue(12);
                            object weight = reader.GetValue(13);

                            Console.WriteLine($"{id} {model} {screensize} {screenres} {screentype} {ram} {rom} {os} {frontcamera} {camera}" +
                                $" {processor} {cores} {battery} {weight}");

                        }
                    }

                    reader.Close();
                }

            }
            void Choose2()  //метод якщо айфон кидають в порівняння другим
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlExpression = "SELECT * FROM [Apple] WHERE id ='" + modelA2 + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)} {reader.GetName(2)} {reader.GetName(3)} {reader.GetName(4)}" +
                            $" {reader.GetName(5)} {reader.GetName(6)} {reader.GetName(7)} {reader.GetName(8)} {reader.GetName(9)} {reader.GetName(10)} " +
                            $"{reader.GetName(11)} {reader.GetName(12)} {reader.GetName(13)}");



                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object model = reader.GetValue(1);
                            object screensize = reader.GetValue(2);
                            object screenres = reader.GetValue(3);
                            object screentype = reader.GetValue(4);
                            object ram = reader.GetValue(5);
                            object rom = reader.GetValue(6);
                            object os = reader.GetValue(7);
                            object frontcamera = reader.GetValue(8);
                            object camera = reader.GetValue(9);
                            object processor = reader.GetValue(10);
                            object cores = reader.GetValue(11);
                            object battery = reader.GetValue(12);
                            object weight = reader.GetValue(13);

                            Console.WriteLine($"{id} {model} {screensize} {screenres} {screentype} {ram} {rom} {os} {frontcamera} {camera}" +
                                $" {processor} {cores} {battery} {weight}");

                        }
                    }

                    reader.Close();
                }
            }
            void Choose3() //метод якщо самсунг кидають в порівняння першим
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlExpression = "SELECT * FROM [Samsung] WHERE id ='" + modelS2 + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)} {reader.GetName(2)} {reader.GetName(3)} {reader.GetName(4)}" +
                            $" {reader.GetName(5)} {reader.GetName(6)} {reader.GetName(7)} {reader.GetName(8)} {reader.GetName(9)} {reader.GetName(10)} " +
                            $"{reader.GetName(11)} {reader.GetName(12)} {reader.GetName(13)}");



                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object model = reader.GetValue(1);
                            object screensize = reader.GetValue(2);
                            object screenres = reader.GetValue(3);
                            object screentype = reader.GetValue(4);
                            object ram = reader.GetValue(5);
                            object rom = reader.GetValue(6);
                            object os = reader.GetValue(7);
                            object frontcamera = reader.GetValue(8);
                            object camera = reader.GetValue(9);
                            object processor = reader.GetValue(10);
                            object cores = reader.GetValue(11);
                            object battery = reader.GetValue(12);
                            object weight = reader.GetValue(13);

                            Console.WriteLine($"{id} {model} {screensize} {screenres} {screentype} {ram} {rom} {os} {frontcamera} {camera}" +
                                $" {processor} {cores} {battery} {weight}");

                        }
                    }

                    reader.Close();
                }
            }
            void Choose4()  //метод якщо самсунг кидають в порівняння першим
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlExpression = "SELECT * FROM [Samsung] WHERE id ='" + modelS + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)} {reader.GetName(2)} {reader.GetName(3)} {reader.GetName(4)}" +
                            $" {reader.GetName(5)} {reader.GetName(6)} {reader.GetName(7)} {reader.GetName(8)} {reader.GetName(9)} {reader.GetName(10)} " +
                            $"{reader.GetName(11)} {reader.GetName(12)} {reader.GetName(13)}");



                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object model = reader.GetValue(1);
                            object screensize = reader.GetValue(2);
                            object screenres = reader.GetValue(3);
                            object screentype = reader.GetValue(4);
                            object ram = reader.GetValue(5);
                            object rom = reader.GetValue(6);
                            object os = reader.GetValue(7);
                            object frontcamera = reader.GetValue(8);
                            object camera = reader.GetValue(9);
                            object processor = reader.GetValue(10);
                            object cores = reader.GetValue(11);
                            object battery = reader.GetValue(12);
                            object weight = reader.GetValue(13);

                            Console.WriteLine($"{id} {model} {screensize} {screenres} {screentype} {ram} {rom} {os} {frontcamera} {camera}" +
                                $" {processor} {cores} {battery} {weight}");

                        }
                    }

                    reader.Close();
                }
            }
            Console.ReadKey();

                }
            }
        }
