using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace CS_MySQL_02
{
    public class MySQL
    {
        public static string dbHost = "127.0.0.1";//資料庫位址
        public static string dbport = "3307"; 
        public static string dbUser = "root";//資料庫使用者帳號
        public static string dbPass = "usbw";//資料庫使用者密碼
        public static string dbName = "test";//資料庫名稱
        public static string connStr = "server=" + dbHost + ";Port=" + dbport + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
        public static MySqlConnection m_conn=null;
        public static bool CreateDB(String DBName)
        {
            connStr = "server=" + dbHost + ";Port=" + dbport + ";uid=" + dbUser + ";pwd=" + dbPass + ";";
            m_conn = new MySqlConnection(connStr);
            try
            {
                m_conn.Open();
                if (m_conn.State == ConnectionState.Open)
                {
                    String s0 = String.Format("CREATE DATABASE IF NOT EXISTS `{0}`;",DBName);
                    MySqlCommand cmd = new MySqlCommand(s0, m_conn);
                    cmd.ExecuteNonQuery();
                    m_conn.Close();
                    dbName = DBName;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool open(String StrHost, String port, String User, String PassWord, String DataBase)
        {
            dbHost = StrHost;//資料庫位址
            dbport = port;
            dbUser = User;//資料庫使用者帳號
            dbPass = PassWord;//資料庫使用者密碼
            dbName = DataBase;//資料庫名稱
            connStr = "server=" + dbHost + ";Port=" + dbport + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            return open();
        }
        public static bool open()
        {
            connStr = "server=" + dbHost + ";Port=" + dbport + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            m_conn = new MySqlConnection(connStr);
            try
            {
                m_conn.Open();
                if (m_conn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static void InsertUpdateDelete(String SqlString)//新增資料程式
        {
            MySqlTransaction transaction = m_conn.BeginTransaction();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SqlString, m_conn, transaction);
                cmd.ExecuteNonQuery();
                transaction.Commit();//交易完成
            }
            catch
            {
                transaction.Rollback();//取消交易，復原至交易前
            }
        }
        public static MySqlDataReader GetDataReader(String SqlString)//讀取資料程式
        {
            MySqlDataReader reader=null;
            try
            {
                MySqlCommand cmd = new MySqlCommand(SqlString, m_conn);
                reader = cmd.ExecuteReader();
                /*
                while (reader.Read())
                {
                    String Str1 = reader["uid"].ToString();
                    String Str2 = reader["ID"].ToString();
                    String Str3 = reader["C_name"].ToString();
                }
                */ 
            }
            catch
            {
                reader.Close();
            }
            return reader;//--使用完釋放資源 reader.Close();
        }
        public static DataTable GetDataTable(String SqlString)
        {
            DataTable myDataTable = new DataTable();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.Connection = m_conn;
            cmd.CommandText = SqlString;
            cmd.CommandTimeout = 600;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            myDataTable = ds.Tables[0];

            return myDataTable;
        }
    }
}
