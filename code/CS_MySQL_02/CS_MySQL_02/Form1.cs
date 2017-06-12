using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CS_MySQL_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//OPEN
        {
            if (MySQL.open())
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MySQL.m_conn.State == ConnectionState.Open)
            {
                String createtablestring;
                String StrSQL;
                createtablestring = "CREATE TABLE Controller_Model (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT, Serial_Number INTEGER);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Controller_Connection (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Controller_Communication (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Controller_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY,C_name TEXT, CM_uid INTEGER, CCon_uid INTEGER, CCom_uid INTEGER, ConData TEXT,Memo TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE P_Department (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE P_Job_Title (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE P_Job_Category (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE People_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY,C_name TEXT,ID TEXT, Password TEXT, PD_uid INTEGER, PJT_uid INTEGER, PJC_uid INTEGER, Memo TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Card_Type (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Card_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY, CT_uid INTEGER, PL_uid INTEGER,Data TEXT,Password TEXT,Validity_start TEXT,Validity_end TEXT, Memo TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Fingerprint_Type (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Fingerprint_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY, PL_uid INTEGER, CL_uid INTEGER, FT_uid INTEGER,Data TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE FDevice_Group (uid INTEGER AUTO_INCREMENT PRIMARY KEY,ID char(100) UNIQUE,C_name TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE FDevice_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY,FDG_uid INTEGER,ID TEXT ,SN TEXT,C_name TEXT,IP TEXT, port TEXT,memo TEXT,count TEXT);";
                MySQL.InsertUpdateDelete(createtablestring);

                createtablestring = "CREATE TABLE Record_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY, PL_uid INTEGER, CL_uid INTEGER,FL_uid INTEGER, FDL_uid INTEGER, FDL_index INTEGER,state INTEGER);";//v0101的版本
                MySQL.InsertUpdateDelete(createtablestring);

                StrSQL = String.Format("INSERT INTO Card_Type (uid,Name) VALUES ({0},'{1}')", "1", "32 bit");
                MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                StrSQL = String.Format("INSERT INTO FDevice_Group (ID,C_name) VALUES ('{0}','{1}')", "0000", "Not defined");
                MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                //SQLiteInsertUpdateDelete(DBpath, "DELETE FROM P_Department;");//部門資料清空
                StrSQL = String.Format("INSERT INTO P_Department (uid,Name) VALUES ({0},'{1}')", "1", "Not defined");
                MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                //SQLiteInsertUpdateDelete(DBpath, "DELETE FROM P_Job_Title;");//職稱資料清空
                StrSQL = String.Format("INSERT INTO P_Job_Title (uid,Name) VALUES ({0},'{1}')", "1", "Not defined");
                MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                //SQLiteInsertUpdateDelete(DBpath, "DELETE FROM P_Job_Category;");//職別資料清空
                StrSQL = String.Format("INSERT INTO P_Job_Category (uid,Name) VALUES ({0},'{1}')", "1", "Not defined");
                MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增
            }
            MessageBox.Show("Finish");
        }
        public void showSQLiteTable2GridView()
        {
            String StrSQL = String.Format("SELECT uid AS NO,ID AS {0},C_name AS {1} FROM FDevice_Group;", CW10_label01.Text.Replace(' ', '_').Substring(0, CW10_label01.Text.Length - 1), CW10_label02.Text.Replace(' ', '_').Substring(0, CW10_label02.Text.Length - 1));
            DataTable dt = MySQL.GetDataTable(StrSQL);
            CW10_dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (MySQL.CreateDB("syris_fingerprint"))
            {
                if (MySQL.open())
                {
                    if (MySQL.m_conn.State == ConnectionState.Open)
                    {
                        String createtablestring;
                        String StrSQL;
                        createtablestring = "CREATE TABLE Controller_Model (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT, Serial_Number INTEGER);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Controller_Connection (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Controller_Communication (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Controller_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY,C_name TEXT, CM_uid INTEGER, CCon_uid INTEGER, CCom_uid INTEGER, ConData TEXT,Memo TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE P_Department (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE P_Job_Title (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE P_Job_Category (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE People_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY,C_name TEXT,ID TEXT, Password TEXT, PD_uid INTEGER, PJT_uid INTEGER, PJC_uid INTEGER, Memo TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Card_Type (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Card_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY, CT_uid INTEGER, PL_uid INTEGER,Data TEXT,Password TEXT,Validity_start TEXT,Validity_end TEXT, Memo TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Fingerprint_Type (uid INTEGER AUTO_INCREMENT PRIMARY KEY,Name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Fingerprint_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY, PL_uid INTEGER, CL_uid INTEGER, FT_uid INTEGER,Data TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE FDevice_Group (uid INTEGER AUTO_INCREMENT PRIMARY KEY,ID char(100) UNIQUE,C_name TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE FDevice_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY,FDG_uid INTEGER,ID TEXT ,SN TEXT,C_name TEXT,IP TEXT, port TEXT,memo TEXT,count TEXT);";
                        MySQL.InsertUpdateDelete(createtablestring);

                        createtablestring = "CREATE TABLE Record_List (uid INTEGER AUTO_INCREMENT PRIMARY KEY, PL_uid INTEGER, CL_uid INTEGER,FL_uid INTEGER, FDL_uid INTEGER, FDL_index INTEGER,state INTEGER);";//v0101的版本
                        MySQL.InsertUpdateDelete(createtablestring);

                        StrSQL = String.Format("INSERT INTO Card_Type (uid,Name) VALUES ({0},'{1}')", "1", "32 bit");//新增失敗時，uid也會增加 所以要先判斷有無資料庫否則旗標會跳很快
                        MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                        StrSQL = String.Format("INSERT INTO FDevice_Group (ID,C_name) VALUES ('{0}','{1}')", "0000", "Not defined");
                        MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                        //SQLiteInsertUpdateDelete(DBpath, "DELETE FROM P_Department;");//部門資料清空
                        StrSQL = String.Format("INSERT INTO P_Department (uid,Name) VALUES ({0},'{1}')", "1", "Not defined");
                        MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                        //SQLiteInsertUpdateDelete(DBpath, "DELETE FROM P_Job_Title;");//職稱資料清空
                        StrSQL = String.Format("INSERT INTO P_Job_Title (uid,Name) VALUES ({0},'{1}')", "1", "Not defined");
                        MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增

                        //SQLiteInsertUpdateDelete(DBpath, "DELETE FROM P_Job_Category;");//職別資料清空
                        StrSQL = String.Format("INSERT INTO P_Job_Category (uid,Name) VALUES ({0},'{1}')", "1", "Not defined");
                        MySQL.InsertUpdateDelete(StrSQL);//防呆預設資料新增
                    }
                    showSQLiteTable2GridView();
                }
            }
        }
        public bool checkUNIQUE(String Data)//判斷是否為一ID用函數
        {
            bool blnAns = false;
            String StrSQL = String.Format("SELECT ID FROM FDevice_Group WHERE ID='{0}';", Data);
            MySqlDataReader DataReader = MySQL.GetDataReader(StrSQL);
            while (DataReader.Read())
            {
                blnAns = true;
                break;
            }
            DataReader.Close();
            return !blnAns;
        }
        private void CW10_button01_Click(object sender, EventArgs e)
        {
            if ((CW10_textBox01.Text != "") && checkUNIQUE(CW10_textBox01.Text))//ID要有值且不能重複
            {
                String StrSQL = String.Format("INSERT INTO FDevice_Group (ID,C_name) VALUES ('{0}','{1}');", CW10_textBox01.Text, CW10_textBox02.Text);
                MySQL.InsertUpdateDelete(StrSQL);
            }
            else
            {
                MessageBox.Show("ADD ERROR", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showSQLiteTable2GridView();
        }

        private void CW10_button02_Click(object sender, EventArgs e)
        {
            if ((CW10_textBox01.Text != ""))//ID要有值且不能重複
            {
                String StrSQL = String.Format("UPDATE FDevice_Group SET ID='{0}',C_name='{1}' WHERE uid={2};", CW10_textBox01.Text, CW10_textBox02.Text, CW10_textBox00.Text);
                MySQL.InsertUpdateDelete(StrSQL);
            }
            else
            {
                MessageBox.Show("UPDATE ERROR", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showSQLiteTable2GridView();
        }

        private void CW10_button03_Click(object sender, EventArgs e)
        {
            String StrSQL = String.Format("DELETE FROM FDevice_Group WHERE uid={0};", CW10_textBox00.Text);
            MySQL.InsertUpdateDelete(StrSQL);
            CW10_textBox00.Text = "";
            CW10_textBox01.Text = "";
            CW10_textBox02.Text = "";
            showSQLiteTable2GridView();
        }

        private void CW10_button04_Click(object sender, EventArgs e)
        {
            CW10_textBox00.Text = "";
            CW10_textBox01.Text = "";
            CW10_textBox02.Text = "";
        }

        public void selectDBData2GUI(int uid)
        {
            String StrSQL = String.Format("SELECT uid AS no,ID,C_name FROM fdevice_group AS fdg WHERE fdg.uid={0};", uid);//元件不允許使用別名搜尋
            MySqlDataReader DataReader = MySQL.GetDataReader(StrSQL);
            while (DataReader.Read())
            {
                CW10_textBox00.Text = DataReader["no"].ToString();
                CW10_textBox01.Text = DataReader["ID"].ToString();
                CW10_textBox02.Text = DataReader["C_name"].ToString();
            }
            DataReader.Close();
        }

        private void CW10_dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = CW10_dataGridView1.SelectedRows[0].Index;//取得被選取的第一列位置
                string Struid = CW10_dataGridView1.Rows[index].Cells[0].Value.ToString();
                int uid = Convert.ToInt32(Struid);
                selectDBData2GUI(uid);
            }
            catch
            {
            }
        }
    }
}
