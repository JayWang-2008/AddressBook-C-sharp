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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        public Boolean Find(ref String[] n, ref String[] n1, ref String[] n2, ref int j1)
        {
            for (int j = 0; j < n.Length; j++)
            {
                if (n[j].Equals(addperson.InputString) || n1[j].Equals(addperson.InputString))
                {
                    j1 = j;
                    return true;
                }
            }
            return false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            String i = File.ReadAllText(@"D:\Name" + joinin.username + ".txt");
            String i1 = File.ReadAllText(@"D:\Number" + joinin.username + ".txt");
            String i2 = File.ReadAllText(@"D:\Address" + joinin.username + ".txt");
            String[] n = i.Split(',');
            String[] n1 = i1.Split(',');
            String[] n2 = i2.Split(',');
            int j1 = 0;
            if (n[0].Equals(""))
            {
                MessageBox.Show("当前账号通讯录为空");
            }
            else
            {
                findperson f = new findperson();
                f.ShowDialog();
                if (f.Visible == false)
                {
                    if (Find(ref n, ref n1, ref n2, ref j1) == true)
                    {
                        showperson f3 = new showperson();
                        f3.labelName.Text = n[j1];
                        f3.labelNumber.Text = n1[j1];
                        f3.labelAddress.Text = n2[j1];
                        f3.Show();
                    }
                    else
                    {
                        MessageBox.Show("当前账号查无此人");
                    }
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new addperson().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            findperson f = new findperson();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\Name"+joinin.username+".txt", "");
            File.WriteAllText(@"D:\Number" + joinin.username + ".txt", "");
            File.WriteAllText(@"D:\Address" + joinin.username + ".txt", "");
            MessageBox.Show("清空成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.j.Close();
        }
    }
    }
