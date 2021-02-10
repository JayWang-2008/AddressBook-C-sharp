using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录3._0
{
    public partial class addperson : Form
    {
        public addperson()
        {
            InitializeComponent();
        }
        public static String InputString = "-----";
        private void button1_Click(object sender, EventArgs e)
        {
            joinin.name.Add(textBox1.Text + ",");
            joinin.number.Add(textBox3.Text + ",");
            joinin.address.Add(textBox4.Text + ",");
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            String[] na = new String[0];
            String[] nu = new String[0];
            String[] ad = new String[0];
            for (int i = 0; i < joinin.name.Count; i++)
            {
                na = joinin.name.ToArray();
                nu = joinin.number.ToArray();
                ad = joinin.address.ToArray();
            }
            for (int i = 0; i < joinin.name.Count; i++)
            {
                sb.Append(na[i]);
                sb1.Append(nu[i]);
                sb2.Append(ad[i]);
            }
            String s = sb.ToString();
            String s1 = sb1.ToString();
            String n2 = sb2.ToString();
            File.AppendAllText(@"D:\Name" + joinin.username + ".txt", s);
            File.AppendAllText(@"D:\Number" + joinin.username + ".txt", s1);
            File.AppendAllText(@"D:\Address" + joinin.username + ".txt", n2);
            joinin.name.Clear();
            joinin.number.Clear();
            joinin.address.Clear();
            MessageBox.Show("添加成功");
            this.Close();
            joinin.m.Visible = true;
        }
    }
}
