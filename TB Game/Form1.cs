using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Close Game";
            button2.Text = "Start Game";
            label1.Text = " Welcome to my game.";
            label2.Text = "If u want to continue click 'Start Game' ";
            label3.Text = "If u want to exit click 'Close Game' ";
        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
                DialogResult dr = MessageBox.Show("Are you sure to close this form?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                    
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for playing.");
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
