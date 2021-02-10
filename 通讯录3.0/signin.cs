using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录3._0
{
    public partial class joinin : Form
    {
        public joinin()
        {
            InitializeComponent();
        }
        public static List<String> name = new List<String>();
        public static List<String> number = new List<String>();
        public static List<String> address = new List<String>();
        
        public static String[] User1 = new String[0];
        public static menu m = new menu();
        public static String username;
        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"D:\User.txt"))
            {
                String User = File.ReadAllText(@"D:\User.txt");
                User1 = User.Split(',');
            }
            else
            {
                File.Create(@"D:\User.txt").Dispose();

            }
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                for (int i = 0; i < User1.Length; i++)
                {
                    if (User1[i].Equals(HashCode(textBox1.Text + textBox2.Text)))
                    {
                        username = User1[i];
                        this.Visible = false;
                        m.ShowDialog();
                        return;
                    }
                }
                MessageBox.Show("用户名或密码错误");
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            if (File.Exists(@"D:\Name"+username+".txt") && File.Exists(@"D:\Number" + username + ".txt") && File.Exists(@"D:\Address" + username + ".txt"))
            {
                String[] name1 = File.ReadAllLines(@"D:\Name" + username + ".txt");
                String[] number1 = File.ReadAllLines(@"D:\Number" + username + ".txt");
                String[] address1 = File.ReadAllLines(@"D:\Address" + username + ".txt");
                for (int i = 0; i < name1.Length; i++)
                {
                    name.Add(name1[i]);
                    number.Add(number1[i]);
                    address.Add(address1[i]);
                }
            }
            else
            {
                File.Create(@"D:\Name" + username + ".txt").Dispose();
                File.Create(@"D:\Number" + username + ".txt").Dispose();
                File.Create(@"D:\Address" + username + ".txt").Dispose();
            }
           

            
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new registered().ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public static String HashCode(String str)
        {
            string str2 = "";
            MD5 md5 = new MD5CryptoServiceProvider();//创建MD5对象（MD5类为抽象类不能被实例化）

            byte[] date = System.Text.Encoding.Default.GetBytes(str);//将字符串编码转换为一个字节序列

            byte[] date1 = md5.ComputeHash(date);//计算data字节数组的哈希值（加密）

            md5.Clear();//释放类资源

            for (int i = 0; i < date1.Length - 1; i++)//遍历加密后的数值到变量str2

            {

                str2 += date1[i].ToString("X");//（X为大写时加密后的数值里的字母为大写，x为小写时加密后的数值里的字母为小写）

            }
            return str2;
        }
    }
}
