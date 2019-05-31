using System;
using System.Data.SqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }


        
        private void button5_MouseHover(object sender, EventArgs e)
        {
            ToolTip butt5 = new ToolTip();
            butt5.SetToolTip(button5, "Добавляет запись в таблицу");
            butt5 = null;
        }


        private void button4_MouseHover(object sender, EventArgs e)
        {
            ToolTip butt4 = new ToolTip();
            butt4.SetToolTip(button4, "Создаёт таблицу данных, согласно варианту задания");
            butt4 = null;
        }


        private void button6_MouseHover(object sender, EventArgs e)
        {
            ToolTip butt6 = new ToolTip();
            butt6.SetToolTip(button6, "Поиск строки, и вывод содержащейся информации. Поиск осуществляется по Артиклю");
            butt6 = null;
        }


        private void button7_MouseHover(object sender, EventArgs e)
        {
            ToolTip butt7 = new ToolTip();
            butt7.SetToolTip(button7, "Редактирует выбранную строку. Выборка производится по номеру Артикля");
        }


        public void button5_Click(object sender, EventArgs e)
        { 
            Form2 form2 = new Form2();
            form2.ShowDialog();  
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (!WindowsFormsApp3.TextBoxesCheck.isCreated)
            {
                MessageBox.Show("База создана", "Message");
                WindowsFormsApp3.TextBoxesCheck.isCreated = false;
            }
            else
            {
                MessageBox.Show("База была создана до этого", "Message");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowsFormsApp3.FindString form = new WindowsFormsApp3.FindString();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowsFormsApp3.RedactSomething form = new WindowsFormsApp3.RedactSomething();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
