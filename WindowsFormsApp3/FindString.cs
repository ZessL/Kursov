﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FindString : Form
    {
        public FindString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxesCheck show = new TextBoxesCheck();
            Structs.Shop string2Show = show.ShowStringFromBase(System.Convert.ToInt32(textBox1.Text));
            ShowStringFBase showStringForm = new ShowStringFBase();
            showStringForm.ShowString(string2Show);
        }

        private void FindString_Load(object sender, EventArgs e)
        {

        }
    }
}
