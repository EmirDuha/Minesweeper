using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMSDENEME2
{

    public partial class MainMenu : Form
    {

        //CONSTRUCTOR
        public MainMenu()
        {
            InitializeComponent();
        }

        //MENU VARIABLES
        string name;
        int mineNum;
        int gridSize;

        //ISVISIBLE STATEMENTS
        int isVisible_1;
        int isVisible_2;
        int isVisible_3;

        //TEXTBOX1 ENTER FUNCTION
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    name = textBox1.Text;
                    pictureBox1.Visible = true;
                    pictureBox4.Visible = false;
                    isVisible_1 = 1;
                }
                else
                {
                    pictureBox4.Visible = true;
                    pictureBox1.Visible = false;
                    isVisible_1 = 0;
                }
            }
        }

        //COMBOBOX1 ENTER FUNCTION
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(comboBox1.Text))
                {
                    if (10 <= Convert.ToInt16(comboBox1.Text) && Convert.ToInt16(comboBox1.Text) <= 30)
                    {
                        gridSize = Convert.ToInt16(comboBox1.Text);
                        pictureBox3.Visible = true;
                        pictureBox6.Visible = false;
                        isVisible_3 = 1;
                    }
                    else
                    {
                        pictureBox6.Visible = true;
                        pictureBox3.Visible = false;
                        isVisible_3 = 0;
                    }
                }
                else
                {
                    pictureBox6.Visible = true;
                    pictureBox3.Visible = false;
                    isVisible_3 = 0;
                }
            }
        }

        //TEXTBOX2 ENTER FUNCTION
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt16(textBox2.Text) < Convert.ToInt32(Math.Pow(Convert.ToInt16(gridSize), 2)))
                {
                    if (!string.IsNullOrEmpty(textBox2.Text))
                    {
                        if (Convert.ToInt16(textBox2.Text) >= 10)
                        {
                            mineNum = Convert.ToInt16(textBox2.Text);
                            pictureBox2.Visible = true;
                            pictureBox5.Visible = false;
                            isVisible_2 = 1;
                        }
                        else
                        {
                            pictureBox5.Visible = true;
                            pictureBox2.Visible = false;
                            isVisible_2 = 0;
                        }

                    }
                    else
                    {
                        pictureBox5.Visible = true;
                        pictureBox2.Visible = false;
                        isVisible_2 = 0;
                    }
                }
                else
                {
                    mineNum = (Convert.ToInt16(Math.Pow(Convert.ToInt16(comboBox1.Text), 2)) - 1);
                    textBox2.Text = mineNum.ToString();
                    pictureBox2.Visible = true;
                    pictureBox5.Visible = false;
                    isVisible_2 = 1;
                }
            }
        }

        //BUTTONSTART CLICK FUNCTION
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (isVisible_1 == 1 && isVisible_2 == 1 && isVisible_3 == 1)
            {
                this.Hide();
                Form2 form2 = new Form2(name, mineNum, gridSize);
                form2.Show();
            }
            else
            {
                labelError.Text = "Please fill all the boxes correctly!";
            }
        }
    }
}