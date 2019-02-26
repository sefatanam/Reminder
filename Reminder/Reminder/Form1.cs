using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(timeTextBox.Text);
                string day = dayComboBox.Text;

                if (day == "SAT" || day == "SUN" || day == "MON" || day == "WED" || day == "THU" || day == "FRI" ||
                   day == "sat" || day == "sun" || day == "mon" || day == "wed" || day == "thu" || day == "fri")
                {
                    if (time >= 8 && time <= 20) //here time is 24hour format
                    {
                        MessageBox.Show("Market is open now, Close at 8.00 PM\n" +
                                         "Thanks for check-in Our Market\n\n");

                        dayComboBox.Text = "Select Day from here";
                        timeTextBox.Text = "";
                    }
                    else if (time<8 && time>0)
                    {
                        MessageBox.Show("Today Market is open at 8.00 AM \n" +
                                        "Thanks for check-in Our Market\n\n");

                        dayComboBox.Text = "Select Day from here";
                        timeTextBox.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Market is Already Closed\n" +
                                        " Please,Come Tomorrow at 8.00 AM from 8.00 PM ");

                        dayComboBox.Text = "Select Day from here";
                        timeTextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Tuesday ! Today is our Holiday\n" +
                                    "Please Come at Tomorrow before 8.00 PM\nThanks");

                    dayComboBox.Text = "Select Day from here";
                    timeTextBox.Text = "";
                }

            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dayComboBox.Text = "Select Day from here";
        }
    }
}
