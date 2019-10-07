using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace LupiRoland_FiveStarRating
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database Location
            //string cs = @"server= 127.0.0.1;userid=root;password=root;database=SampleRestaurantDatabase;port=8889";
            //Output Location
            //string _directory = @"../../output/";﻿﻿


            
            bool running = true; //holder for loop
            while (running)
            {
                Console.Write( //menu set up
                    "\n\t\t\t\t\tHello User, How Would You Like To Sort The Data?" +
                    "\n\n\n" +
                    "\t\t\t\t[1] List Restaurants Alphabetically (Show Rating Next To Name)" +
                    "\n\n" +
                    "\t\t\t\t[2] List Restaurants in Reverse Alphabetical (Show Rating Next To Name)" +
                    "\n\n" +
                    "\t\t\t\t[3] Sort Restaurants From Best to Worst (Show Rating Next To Name)" +
                    "\n\n" +
                    "\t\t\t\t[4] Sort Restaurants From Worst to Best (Show Rating Next To Name)" +
                    "\n\n" +
                    "\t\t\t\t[5] Show Only X and Up" +
                    "\n\n" +
                    "\t\t\t\t[6] Exit" +
                    "\n\n\n" +
                    "\t\t\t\tChoice: "
                    );
                int userInput = Validation.GetInt(1, 6); //restrict range of choices

                switch (userInput) //cycle through choices
                {
                    case 1:
                        {
                            
                        }
                        break;
                    case 2:
                        {

                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {

                        }
                        break;
                    case 5:
                        {

                        }
                        break;
                    case 6:
                        {
                            running = false;
                        }
                        break;
                }
                Console.Clear();
            }
        }

        public static void ConnectToSQL(string query)
        {
            // MySQL Database Connection String
            string cs = @"server=10.0.0.124;userid=root;password=root;database=SampleRestaurant;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            try
            {

                // Open a connection to MySQL 
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = query;


                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL Statement and Convert Results to a String
                string response = Convert.ToString(cmd);

                // Output Results
                MySqlDataReader reader = cmd.ExecuteReader();

                //List<Restaurant> restaurants = new List<Restaurant> { }; //create list of restaurant objects to store data

                //while (reader.Read()) //while the reader is reading ... do this
                //{
                //    //store data from database as a property of the restaurant object
                //    restaurants.Add(new Restaurant(reader["id"].ToString(), reader["RestaurantName"].ToString(), reader["Address"].ToString(), reader["Phone"].ToString(), reader["HoursOfOperation"].ToString(), reader["Price"].ToString(), reader["USACityLocation"].ToString(), reader["Cuisine"].ToString(), reader["FoodRating"].ToString(), reader["ServiceRating"].ToString(), reader["AmbienceRating"].ToString(), reader["ValueRating"].ToString(), reader["OverallRating"].ToString(), reader["OverallPossibleRating"].ToString()));
                //}

                //using (StreamWriter file = new StreamWriter(@"Z:\Desktop\Project & Portfolio 2\LupiRoland_ConvertedData.JSON")) //use streamwrite class to save following to a .JSON file at location of my choosing
                //{

                //    file.Write("[");
                //    foreach (Restaurant restaurant in restaurants) //foreach restaurant object in the list of objects
                //    {

                //        file.WriteLine(restaurant.ToString()); //write out its contents 

                //        if (restaurant != restaurants[restaurants.Count - 1]) //check to see if the object is the last object in the database
                //        {
                //            //if it is then add comma
                //            file.Write(",");
                //        }
                //    }
                //    file.Write("]");

                //}



            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
    }
}
