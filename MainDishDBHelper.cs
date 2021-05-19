using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class MainDishDBHelper : DBHelper
    {
        new public List<MainDishItemEntity> PobierzMenu()
        {
            List<MainDishItemEntity> menu = new List<MainDishItemEntity>();
            try
            {
                Console.WriteLine("Startuję traja.");
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySqlCommand command = new MySqlCommand("SElECT * FROM `dania_glowne` WHERE 1;", connection);
                    Console.WriteLine("Otwieram połączenie.");
                    connection.Open();
                    using (MySqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            menu.Add(new MainDishItemEntity(read["name"].ToString(), int.Parse(read["price"].ToString())));
                            Console.WriteLine(read["name"]);
                        }
                        connection.Close();
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Błąd" + "\n" + ex.ToString());
            }
            return menu;
        }
    }
}
