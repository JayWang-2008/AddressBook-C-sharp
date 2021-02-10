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
    public partial class registered : Form
    {
        public registered()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\User.txt", joinin.HashCode(newtextBox1.Text + newtextBox2.Text )+ ",");
            this.Close();
            Application.Restart();
        }
    }
}
