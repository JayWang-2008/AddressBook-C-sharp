using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录3._0
{
    public partial class findperson : Form
    {
        public findperson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addperson.InputString = textInPut.Text;
            this.Visible = false;
        }
    }
}
