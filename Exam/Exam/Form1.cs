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

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtb1_TextChanged(object sender, EventArgs e)
        {
            user user1 = new user();
            user1.fname = txtb1.Text;
          
        }

        private void txtb3_TextChanged(object sender, EventArgs e)
        {
            user user1 = new user();
            user1.tell = txtb3.Text;
        }

        private void txtb2_TextChanged(object sender, EventArgs e)
        {
            user user1 = new user();
            user1.lname = txtb2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtb1.Clear();
            txtb2.Clear();
            txtb3.Clear();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            string str1 = txtb1.Text;
            string str2 = txtb2.Text;
            string str3 = txtb3.Text;
            if(str1.Length == 0 ||str2.Length == 0 || str3.Length == 0)
            {
                MessageBox.Show("that first name or last name or telephone is empty" , "logic caption", MessageBoxButtons.OKCancel);

            }
            else
            {
                FileStream users = new FileStream("C:\\Users\\1896358\\Desktop\\users.txt" , FileMode.Append );
                using (StreamWriter writer = new StreamWriter(users))
                {
                    writer.WriteLine("[first name:" + txtb1.Text + " last name: " + txtb2.Text + " telephone:" + txtb3.Text);

                }
                using (StreamReader reader = new StreamReader("C:\\Users\\1896358\\Desktop\\users.txt"))
                {
                    string str = reader.ReadToEnd();
                }
              
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           //FileStream users = new FileStream("C:\\Users\\1896358\\Desktop\\users.txt", FileMode.Append);
            var count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\1896358\\Desktop\\users.txt"))
            {
               // string str = reader.ReadToEnd();
                while (reader.ReadLine() != null)
                {
                    count++;
                }

            }
        
            MessageBox.Show("the line is" + count);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
               File.Delete("C:\\Users\\1896358\\Desktop\\users.txt");
               
        }
    }
}
