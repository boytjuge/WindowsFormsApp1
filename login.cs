using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().ToUpper() == "ADMIN"  && textBox2.Text.ToString().ToUpper() == "ADMIN")
            {
                Form1 appform = new Form1();
                this.Hide();
                appform.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("username & password incorrect!!");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Text = "สาขา 1", Value = "1" });
            items.Add(new Item() { Text = "สาขา 2", Value = "2" });
            items.Add(new Item() { Text = "สาขา 3", Value = "3" });

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
        }
    }
    public class Item
    {
        public Item() { }

        public string Value { set; get; }
        public string Text { set; get; }
    }
}
