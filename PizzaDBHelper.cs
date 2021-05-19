using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pizzeria
{
    class PizzaDBHelper : DBHelper
    {

        new public List<PizzaItemEntity> PobierzMenu()
        {
            List<PizzaItemEntity> menu = new List<PizzaItemEntity>();
            try
            {
                Console.WriteLine("Startuję traja.");
                using(MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(server))
                {
                    MySqlCommand command = new MySqlCommand("SElECT * FROM `pizza` WHERE 1;", connection);
                    Console.WriteLine("Otwieram połączenie.");
                    connection.Open();
                    using (MySqlDataReader read = command.ExecuteReader())
                    {
                        while(read.Read())
                        {
                            menu.Add(new PizzaItemEntity(read["name"].ToString(), read["ingrediences"].ToString(), int.Parse(read["price"].ToString())));
                            Console.WriteLine(read["name"]);
                        }
                        connection.Close();
                    }
                }
            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Błąd" + "\n" + ex.ToString());
            }
            return menu;
        }
    }
}
