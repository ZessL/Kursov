﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgramm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool CheckTextbox()
        {
            if(textBox1.Text.Length < 1 || textBox2.Text.Length < 1 || textBox3.Text.Length < 1 || textBox4.Text.Length < 1 || textBox5.Text.Length < 1 || textBox6.Text.Length < 1)
            {
                return false;
            }
            else
            { 
                return true;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool isRite = CheckTextbox();
            if (!isRite)
            {
                MessageBox.Show("Одно из полей заполнено неправильно");
            }
            else if (isRite)
            {
                string textbox3 = textBox3.Text;
                string textbox5 = textBox5.Text;
                string textbox6 = textBox6.Text;
                WindowsFormsApp3.TextBoxesCheck check = new WindowsFormsApp3.TextBoxesCheck();
                string[] returnedClearStrings = check.CheckTextBoxes(textbox3, textbox5, textbox6);
                if (returnedClearStrings[0].Length < 1 || returnedClearStrings[1].Length < 1 || returnedClearStrings[2].Length < 1)
                {
                    MessageBox.Show("В числовых полях(Артикль, Кол-во товара, Цена за единицу) не содержится чисел");
                }
                else
                {
                    MessageBox.Show(returnedClearStrings[0] + "  " + returnedClearStrings[1] + "  " + returnedClearStrings[2]);
                    WindowsFormsApp3.TextBoxesCheck addCaption = new WindowsFormsApp3.TextBoxesCheck();
                    int[] ClearInt = new int[3];
                    ClearInt[0] = System.Convert.ToInt32(returnedClearStrings[0]);
                    ClearInt[1] = System.Convert.ToInt32(returnedClearStrings[1]);
                    ClearInt[2] = System.Convert.ToInt32(returnedClearStrings[2]);
                    addCaption.AddCaption(textBox1.Text.Trim(), textBox2.Text.Trim(), ClearInt[0], textBox4.Text.Trim(), ClearInt[1], ClearInt[2]);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
