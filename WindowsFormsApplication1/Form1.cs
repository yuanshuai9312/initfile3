using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        IniFiles ini = new IniFiles(Application.StartupPath + @"\MyConfig.INI");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ini.IniWriteValue("登入详细", "用户名", "test");//写入一条数据
            ini.IniWriteValue("登入详细", "密码", "password"); ////写入一条数据

            if (ini.ExistINIFile())//验证是否存在文件，存在就读取
            {
                textBox1.Text = ini.IniReadValue("登入详细", "用户名");
                textBox2.Text = ini.IniReadValue("登入详细", "密码");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
