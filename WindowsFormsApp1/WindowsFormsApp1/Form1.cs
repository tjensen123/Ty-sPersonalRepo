using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string answer = "";

        public Form1()
        {
            InitializeComponent();
            this.controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void controller()
        {
            Calculator c = new Calculator();
            answer = c.Evaluate()+"";
            equationLabel.Text = c.GetString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (answer == textBox1.Text)
                {
                    textBox1.ResetText();

                    InfoLabel.Text = "Correct!";
                    InfoLabel.ForeColor = Color.LightGreen;
                    ShowInfoLabel(1);
                    controller();

                }
                else
                {
                    textBox1.ResetText();
                    InfoLabel.Text = "Incorrect!";
                    InfoLabel.ForeColor = Color.Red;
                    ShowInfoLabel(1);
                }
            }

            

        }


        private void ShowInfoLabel(int seconds)
        {
            InfoLabel.Visible = true;
            Timer t = new Timer() { Enabled = true };
            t.Interval = seconds * 1000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                InfoLabel.Visible = false;
                t.Stop();
            };
            t.Start();

            
        }

    }
}
