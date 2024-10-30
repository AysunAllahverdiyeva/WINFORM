using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm_EfCore_Final_Project
{
    public partial class Form1 : Form
    {

        private string expectedUsername = "Aysun";
        private string expectedEmail = "aysun@1234.com";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text2 = textBox2.Text;
        }

        private bool CheckInput(string username, string email)
        {
            // Daxil edilmiş username və e-poçtun doğruluğunu yoxlayırıq
            if (username == expectedUsername && email == expectedEmail)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox2.Text;

            // Daxil edilmiş məlumatların doğruluğunu yoxlayırıq
            if (CheckInput(username, email))
            {
                // Əgər məlumatlar düzgün daxil edilibsə Form2-ni açırıq
                Form2 form2 = new Form2();

                form2.Show();

                // Form1-i gizlədərik
                this.Hide();
            }
            else
            {
                MessageBox.Show("Xahiş edirəm, doğru username və e-poçt daxil edin.");
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
        }
        private void ResetTextBoxes()
        {
            textBox1.Text = ""; // Username mətn qutusunu təmizlə
            textBox2.Text = ""; // E-poçt mətn qutusunu təmizlə
        }
    }
}
