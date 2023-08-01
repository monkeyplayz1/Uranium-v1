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
using Hovac_API;





namespace Uranium_V2
{
    public partial class Form1 : Form
    {
        ExploitAPI exploitAPI = new ExploitAPI();
         
        
        public Form1()
        {
            
            
            InitializeComponent();
            
        }
        Point lastPoint;
       

        private void button2_Click(object sender, EventArgs e)
        {
            exploitAPI.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";

                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                using (Stream S = File.Open(saveFileDialog1.FileName, FileMode.CreateNew)) 
                using(StreamWriter sw = new StreamWriter(S))
                {


                    sw.Write(fastColoredTextBox1.Text);
                }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

       

        

       
        private void button8_Click(object sender, EventArgs e)
        {
            Options options = new Options(); // Create a new instance of the Options form
            options.Show(); // Show the Options form
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Script_Hub openform = new Script_Hub();
            openform.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
         
        {
            


            exploitAPI.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            exploitAPI.LaunchExploit();
                
           
            
        }
    }
}
