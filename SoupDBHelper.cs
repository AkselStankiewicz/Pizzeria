using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class SoupDBHelper : DBHelper
    {
        new public List<SoupItemEntity> PobierzMenu()
        {
            List<SoupItemEntity> menu = new List<SoupItemEntity>();
            try
            {
                Console.WriteLine("Startuję traja.");
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySqlCommand command = new MySqlCommand("SElECT * FROM `zupy` WHERE 1;", connection);
                    Console.WriteLine("Otwieram połączenie.");
                    connection.Open();
                    using (MySqlDataReader read = command.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            menu.Add(new SoupItemEntity(read["name"].ToString(), int.Parse(read["price"].ToString())));
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
