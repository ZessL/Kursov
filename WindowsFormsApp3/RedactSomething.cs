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
    public partial class RedactSomething : Form
    {
        public RedactSomething()
        {
            InitializeComponent();
        }

        private void RedactSomething_Load(object sender, EventArgs e)
        {
            
        }

        private void RedactSomething_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(RedactSomething.ActiveForm, "Редактирует строку, содержащую выбранный Артикль. Заменяются, те поля, в которых есть информация");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Article = System.Convert.ToInt32(textBox7.Text);
            TextBoxesCheck redact = new TextBoxesCheck();
            redact.RedactAdress(Article, textBox2.Text);
            redact.RedactArticle(Article);
            redact.RedactCount(Article, (textBox5.Text));
            redact.RedactPricePerEach(Article,(textBox6.Text));
            redact.RedactShopname(Article, textBox1.Text);
            redact.RedactTovarname(Article, textBox5.Text);
            MessageBox.Show("Поля успешно отредактированы", "Message");

        }
    }
}
