using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SedapMakanChefModule
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["SedapMakanDB"].ConnectionString;



        public static List<MenuItem> GetMenuItems()
        {
            List<MenuItem> items = new List<MenuItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT MenuItemId, Name, Price, IsAvailable FROM MenuItems";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new MenuItem
                    {
                        MenuItemId = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDecimal(2),
                        IsAvailable = reader.GetBoolean(3)
                    });
                }
            }

            return items;
        }

        public static void AddMenuItem(string name, decimal price, bool isAvailable)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MenuItems (Name, Price, IsAvailable) VALUES (@name, @price, @isAvailable)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@isAvailable", isAvailable);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateMenuAvailability(int menuItemId, bool isAvailable)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE MenuItems SET IsAvailable = @isAvailable WHERE MenuItemId = @menuItemId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@isAvailable", isAvailable);
                cmd.Parameters.AddWithValue("@menuItemId", menuItemId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT OrderId, CustomerName, Status FROM Orders";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new Order
                    {
                        OrderId = reader.GetInt32(0),
                        CustomerName = reader.GetString(1),
                        Status = reader.GetString(2)
                    });
                }
            }

            return orders;
        }

        public static void UpdateOrderStatus(int orderId, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Orders SET Status = @status WHERE OrderId = @orderId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static ChefProfile GetChefProfile()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Username, Password FROM ChefProfile";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new ChefProfile
                    {
                        Username = reader.GetString(0),
                        Password = reader.GetString(1)
                    };
                }
                else
                {
                    return new ChefProfile { Username = "", Password = "" };
                }
            }
        }

        public static void UpdateChefProfile(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE ChefProfile SET Username = @username, Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
