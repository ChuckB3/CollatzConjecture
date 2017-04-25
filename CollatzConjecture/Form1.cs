using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CollatzConjecture
{
    public partial class Collatz_Conjecture : Form
    {
        public int steps;
        public int startNum;
        public Collatz_Conjecture()
        {
            InitializeComponent();
        }

        public int collatzSteps(int n)
        {
            steps = 0;
            while(n!=1)
            {
                if(n%2==0)
                {
                    n = n / 2;
                    steps++;
                }
                else
                {
                    n = (3 * n) + 1;
                    steps++;
                }
                
            }
            return steps;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(startBox.Text)>=1)
            {
                try
                {
                    startNum = Int32.Parse(startBox.Text);
                    MessageBox.Show("1 reached in " + collatzSteps(startNum) + " steps.", "Results");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error!", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Enter an integer greater than 0.");
            } 
            
        }
    }
}
