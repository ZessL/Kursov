using System;
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
    public partial class ShowStringFBase : Form
    {
        public ShowStringFBase()
        {
            InitializeComponent();
        }


        public void ShowString(Structs.Shop shop)
        {
            ShowStringFBase form = new ShowStringFBase();
            form.textBox1.Text = shop.ShopName;
            form.textBox2.Text = shop.Adress;
            form.textBox3.Text = shop.Article.ToString();
            form.textBox4.Text = shop.TovarName;
            form.textBox5.Text = shop.Count.ToString();
            form.textBox6.Text = shop.PricePerEach.ToString();
            form.textBox7.Text = shop.Price4All.ToString();
            form.ShowDialog();
        }

    }
}
