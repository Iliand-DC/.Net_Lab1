using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private static string text;
        public string get()
        {
            return text;
        }
        public void set(string smt_txt)
        {
            text = smt_txt;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void SetTextBox()
        {
            textBox1.Text = text;
        }
        public string GetTextBox()
        {
            return textBox1.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = get();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            set(temp);
            Form2 form2 = new Form2();
            form2.ShowDialog();
            set(form2.GetTextBox());
            SetTextBox();
        }
    }
}