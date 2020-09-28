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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        HeroStatus filter = new HeroStatus();



        private void button4_Click(object sender, EventArgs e)
        {
            BaseHero chosen = filter.getRandomMage();
            button_clicked(chosen);
        }

        private void Form2_Load(object sender, EventArgs e)
        {            
            button1.Text = "Berserker";
            button2.Text = "Warrior";
            button3.Text = "Druid";
            button4.Text = "Mage";
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            BaseHero chosen = filter.getRandomDruid();
            button_clicked(chosen);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            BaseHero chosen = filter.getRandomBerserker();
            button_clicked(chosen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseHero chosen = filter.getRandomWarrior();
            button_clicked(chosen);
        } 

           private void button_clicked(BaseHero chosenHero)
        {           
                MessageBox.Show($"You have chosen the {chosenHero.Name}  Hero.");
                this.Hide();
                Form3 f3 = new Form3(chosenHero.Name, chosenHero.Status());
                f3.ShowDialog();
            }
        }
        
    }

