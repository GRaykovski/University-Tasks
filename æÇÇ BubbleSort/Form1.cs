using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace САА_BubbleSort
{
     public class Event
    {
       public enum  eventType
        {
            Change, Comparison, Reset
        }
        public eventType EventType { get; set; }
        public int index1 { get; set; }
        public int index2 { get; set; }
    }
    public partial class Form1 : Form
    {
        int index = 0;
        static List<Event> events = new List<Event>();
        public int[] IntArray;
        public TextBox[] arr;
        public string[] Info;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntArray = textBox1.Text.Split(',').Select(x => int.Parse(x.ToString())).ToArray();
            GenerateNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntArray = Bubble(IntArray);
            Display();                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        static int[] Bubble(int[] arr)
        {
            int i, j;
            bool swapped;
            for (i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        events.Add(new Event { index1 = j, index2 = j + 1 , EventType = Event.eventType.Comparison});
                        events.Add(new Event { index1 = j, index2 = j + 1 , EventType = Event.eventType.Change });
                        events.Add(new Event { index1 = j, index2 = j + 1 , EventType = Event.eventType.Reset});
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
            return arr;
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            
        }   
        
        public void GenerateNew()
        {
            arr = new TextBox[IntArray.Length];
            int pointX = 12;
            int pointY = 150;
            for (int i = 0; i < IntArray.Length; i++)
            {
                TextBox textBox = new TextBox();          
                textBox.Name = "TxtBox" + i;
                textBox.Multiline = true;
                textBox.Font = new Font(textBox.Font.FontFamily, 14);
                textBox.Text = IntArray[i].ToString();
                textBox.TextAlign = HorizontalAlignment.Center;
                textBox.Location = new Point(pointX, pointY);
                textBox.Size = new Size(45, 40);
                pointX += 50;
                arr[i] = textBox;
                Controls.Add(textBox);
            }
        }    
        
        public void Display()
        {
            if (index < events.Count)
            {
                Event e = events[index++];
                if (e.EventType == Event.eventType.Comparison)
                {
                    arr[e.index1].BackColor = Color.Red;
                    arr[e.index2].BackColor = Color.Red;
                }
                if (e.EventType == Event.eventType.Change)
                {
                    string temp = arr[e.index1].Text;
                    arr[e.index1].Text = arr[e.index2].Text;
                    arr[e.index2].Text = temp;
                }
                if (e.EventType == Event.eventType.Reset)
                {
                    arr[e.index1].BackColor = Color.White;
                    arr[e.index2].BackColor = Color.White;
                }
            }
            else MessageBox.Show("Array is sorted.");
        }
    }
}
