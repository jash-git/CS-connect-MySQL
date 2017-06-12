using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Threading;

namespace CS_Start_Stop_MySQL
{
    public partial class Main : Form
    {
        private Process m_pro;
        public static string dbHost = "127.0.0.1";//資料庫位址
        public static string dbUser = "root";//資料庫使用者帳號
        public static string dbPass = "usbw";//資料庫使用者密碼
        public static string dbName = "v8";//資料庫名稱
        public static string connStr = "server=" + dbHost + ";Port=3307;uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
        public Main()
        {
            InitializeComponent();
        }

        private void butstart_Click(object sender, EventArgs e)
        {
            if (m_pro == null)
            {
                string path = System.Windows.Forms.Application.StartupPath;
                path += "\\mysql\\bin\\mysqld_v8.exe";
                ProcessStartInfo startInfo = new ProcessStartInfo(path);
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                m_pro = Process.Start(startInfo);
                Thread.Sleep(100);
                try
                {
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        MessageBox.Show("MYSQL connect OK");
                    }
                }
                catch
                {
                    MessageBox.Show("MYSQL connect fail");
                }
            }
        }

        private void butstop_Click(object sender, EventArgs e)
        {
            if (m_pro != null)
            {
                if (!m_pro.HasExited)// 取得程式是否已執行完成
                {
                    m_pro.Kill();//關閉程式
                    m_pro.Close();//把m_pro清空被執行程式的資源,但m_pro實體存在
                    m_pro = null;// 清空m_pro實體
                }
            }
        }

    }
}