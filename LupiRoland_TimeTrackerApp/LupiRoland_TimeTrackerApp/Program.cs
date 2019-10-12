using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LupiRoland_TimeTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mainMenuRunning = true; 
            while (mainMenuRunning) //main menu
            {

                Console.Write("" +
                    "\n" +
                    "What Would You Like To Do?" +
                    "\n" +
                    "\n" +
                    "[1] Enter Activity" +
                    "\n" +
                    "[2] View Tracked Data" +
                    "\n" +
                    "[3] Run Calculations" +
                    "\n" +
                    "[4] Exit" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "Choice: ");
                int userMenuChoice = Validation.GetInt(1, 4);

                bool activityMenu = true;
                while (userMenuChoice == 1) //activy option menu
                {

                    Console.WriteLine("" +
                        "\nPick A Category Of Activity:" +
                        "\n");

                    ConnectToSQL("SELECT * FROM activity_categories;");
                    

                    bool activitySub1 = true;
                    while (activitySub1) //first sub menu in activity
                    {
                        Console.WriteLine("" +
                            "\nPick An Activity Description:" +
                            "\n");

                        ConnectToSQL("SELECT * FROM activity_descriptions;");

                        bool activitySub2 = true;
                        while (activitySub2) //second sub menu in activity
                        {
                            Console.WriteLine("" +
                            "\nWhat Date Did You Perform This Activity:" +
                            "\n");

                            ConnectToSQL("SELECT * FROM tracked_calendar_dates;");

                            bool activitySub3 = true;
                            while (activitySub3) //third sub menu in activity
                            {


                                bool activitySub4 = true;
                                while (activitySub4) //fourth sub menu in activity
                                {


                                    bool activitySub5 = true;
                                    while (activitySub5)
                                    {

                                        Console.Clear();
                                    }
                                    Console.Clear();
                                }
                                Console.Clear();
                            }
                            Console.Clear();
                        }
                        Console.Clear();
                    }
                    Console.Clear();
                }

 //------------------------------------------------------------------------------------------------------------------------------

                bool trackedDataMenu = true;
                while (trackedDataMenu) //tracked data menu
                {

                        bool trackedSub1 = true;
                        while (trackedSub1) //tracked data sub menu 1
                        {

                            bool trackedSub2 = true;
                            while (trackedSub2) //tracked data 1 sub menu 1
                            {

                                Console.Clear();
                            }

                            Console.Clear();
                        }

                        //-----------------------------------------------------------------------

                        bool trackedSub3 = true;
                        while (trackedSub3) //tracked data sub menu 1.0
                        {

                            bool trackedSub4 = true;
                            while (trackedSub4) //tracked data 1.0 sub menu 1
                            {

                                
                                Console.Clear();
                            }
                            Console.Clear();
                        }

                        //-----------------------------------------------------------------------

                        bool trackedSub5 = true;
                        while (trackedSub5) //tracked data sub menu 2.0
                        {

                            bool trackedSub6 = true; //tracked data 2.0 sub 1
                            while (trackedSub6)
                            {

                                Console.Clear();
                            }
                            Console.Clear();
                        }

                    //----------------------------------------------------------------------

                        bool trackedExit = true;
                        while (trackedExit)
                        {

                            Console.Clear();
                        }


                        Console.Clear();
                    
                }
//----------------------------------------------------------------------------------------------------------------------------------
                bool runCalcMenu = true;
                while (runCalcMenu) //run calculations menu
                {

                    Console.Clear();
                }
//----------------------------------------------------------------------------------------------------------------------------------
                bool mainMenuExit = true;
                while (mainMenuExit)
                {

                    Console.Clear();
                }

                Console.Clear();
            }
            
        }

        public static void ConnectToSQL(string query)
        {
            // MySQL Database Connection String
            string cs = @"server=10.0.0.126;userid=root;password=root;database=RolandLupi_MDV229_Database_201910;port=8889";

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

                int number = 1;

                while (reader.Read())
                {
                    

                    if (query.Contains("activity_categories"))
                    {


                        Console.WriteLine($"[{number}]" + " " + reader["category_description"].ToString());
                        number++;

                    }
                    else if (query.Contains("activity_description"))
                    {
                        Console.WriteLine($"[{number}]" + " " + reader["activity_description"].ToString());
                        number++;
                    }
                    else if (query.Contains("tracked_calendar_dates"))
                    {
                        Console.WriteLine($"[{number}]" + " " + reader["tracked_calendar_dates"].ToString());
                        number++;
                    }
                }

                Console.Write($"[{number}] Back To Previous Menu");
                Console.Write("\n\n\nChoice: ");

                int mainMenuChoice = Validation.GetInt(1, number);

              
               
              




            }
            catch (MySqlException ex) //if error occurs, print error
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                Console.ReadLine();
            }
            finally //close connection after action is complete
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
    }
}
