using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CompareV2
{
    public class Program
    {
        public static int modelA;
        public static int modelA2;
        public static int modelS;
        public static int modelS2;
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите какой производитель вас интерисует: \n1.Apple \n2.Samsung");
            int brand1 = Convert.ToInt32(Console.ReadLine());
            switch (brand1)
            {
                case 1:
                    Console.WriteLine("Выберите модель:\n1.Iphone 11;\n2.Iphone 11 Pro;\n3.Iphone 11 Pro Max;\n4.Iphone X;\n5.Iphone XS;\n6.Iphone XR.");
                    modelA = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Выберите модель:\n7.Galaxy S20;\n8.Galaxy S20 Plus;\n9.Galaxy S20 Ultra;\n10.Galaxy Note 10;\n11.Galaxy Note 10+;\n12.Galaxy S10;\n13.Galaxy S10+");
                    modelS = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Error! Unknown command. Please try again.");
                    break;
            }

            Console.WriteLine("Выберите какой производитель вас интерисует: \n1.Apple \n2.Samsung");
            int brand2 = Convert.ToInt32(Console.ReadLine());
            switch (brand2)
            {
                case 1:
                    Console.WriteLine("Выберите модель:\n1.Iphone 11;\n2.Iphone 11 Pro;\n3.Iphone 11 Pro Max;\n4.Iphone X;\n5.Iphone XS;\n6.Iphone XR.");
                    modelA2 = Convert.ToInt32(Console.ReadLine());
                    if (brand1 == 1)
                    {
                        Choose(brand1, modelA);
                        Choose(brand2, modelA2);
                    }
                    else if(brand1==2)
                    {
                        Choose(brand1, modelS);
                        Choose(brand2, modelA2);
                    }
                    break;
                case 2:
                    Console.WriteLine("Выберите модель:\n7.Galaxy S20;\n8.Galaxy S20 Plus;\n9.Galaxy S20 Ultra;\n10.Galaxy Note 10;\n11.Galaxy Note 10+;\n12.Galaxy S10;\n13.Galaxy S10+");
                    modelS2 = Convert.ToInt32(Console.ReadLine());
                    if (brand1 == 1)
                    {
                        Choose(brand1, modelA);
                        Choose(brand2, modelS2);
                    }
                    else
                    {
                        Choose(brand1, modelS);
                        Choose(brand2, modelS2);
                    }
                    break;
                default:
                    Console.WriteLine("Error! Unknown command. Please try again.");
                    break;
            }
            Console.ReadKey();

            void Choose(int modelID, int phoneID)
            {
                string connectionString = "Data Source=DESKTOP-ADEUVRA;Initial Catalog=PhoneSpecs;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlExpression = "SELECT * FROM [Phones] WHERE id ='" + phoneID + "' AND ModelID = '" + modelID + "'";
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows) // если есть данные
                    {
                        // выводим названия столбцов
                        Console.WriteLine($"{reader.GetName(0)} {reader.GetName(1)} {reader.GetName(2)} {reader.GetName(3)} {reader.GetName(4)}" +
                        $" {reader.GetName(5)} {reader.GetName(6)} {reader.GetName(7)} {reader.GetName(8)} {reader.GetName(9)} {reader.GetName(10)} " +
                        $"{reader.GetName(11)} {reader.GetName(12)} {reader.GetName(13)} {reader.GetName(14)} {reader.GetName(15)}");
                        while (reader.Read()) // построчно считываем данные
                        {
                            object id = reader.GetValue(0);
                            object modelid = reader.GetValue(1);
                            object brand = reader.GetValue(2);
                            object model = reader.GetValue(3);
                            object screensize = reader.GetValue(4);
                            object screenres = reader.GetValue(5);
                            object screentype = reader.GetValue(6);
                            object ram = reader.GetValue(7);
                            object rom = reader.GetValue(8);
                            object os = reader.GetValue(9);
                            object frontcamera = reader.GetValue(10);
                            object camera = reader.GetValue(11);
                            object processor = reader.GetValue(12);
                            object cores = reader.GetValue(13);
                            object battery = reader.GetValue(14);
                            object weight = reader.GetValue(15);
                            Console.WriteLine($"{id} {modelid} {brand} {model} {screensize} {screenres} {screentype} {ram} {rom} {os} {frontcamera} {camera}" +
                                $" {processor} {cores} {battery} {weight}");

                        }
                    }
                    reader.Close();
                }

            }
        }
    }
}