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
    public partial class Form3 : Form 
    {
        public Form3(string MyLabelText, string MyStatusText)
        {
            InitializeComponent();
            this.label1.Text = MyLabelText;
            this.textBox2.Text = MyStatusText; 
        }
     
        private void Form3_Load(object sender, EventArgs e)
        {
         
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // to activity log - {chosenhero} has attacked
        }
    }
}
