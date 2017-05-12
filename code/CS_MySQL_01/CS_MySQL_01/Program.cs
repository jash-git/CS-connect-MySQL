using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace CS_MySQL_01
{
    class Program
    {
        public static string dbHost = "127.0.0.1";//資料庫位址
        public static string dbUser = "root";//資料庫使用者帳號
        public static string dbPass = "usbw";//資料庫使用者密碼
        public static string dbName = "test";//資料庫名稱
        public static string connStr = "server=" + dbHost + ";Port=3307;uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
        static void pause()
        {
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
        static void CS_MySQL_Insert()
        {         
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            String account;
            String password;
            int level;
            for (int i = 0; i < 10; i++)
            {
                account = "account" + i.ToString();
                password = "password" + i.ToString();
                level = i * 10;
                command.CommandText = "Insert into member(account,password,level) values('" + account + "','" + password + "'," + level + ")";
                command.ExecuteNonQuery();
            }

            conn.Close();
        }
        static void Main(string[] args)
        {
            CS_MySQL_Insert();
            pause();
        }
    }
}
