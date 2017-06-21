using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single X;
            bool Number_pi = Single.TryParse(
                textBox1.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out X);
            if (Number_pi == false)
            {
                //Если пользователь ввел не число:
                label1.Text = "Следует вводить числа";
                label1.ForeColor = Color.Red; //цвет текса на метке
                return; //Выход из процедуры или Return
            }
            //Извлечение корня с преобразованием в тип Single:
            var Y = (Single)Math.Sqrt(X);
            //или var Y = Convert.ToSingle(Math.Sqrt(X));
            label1.ForeColor = Color.Black;
            label1.Text = string.Format(""); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Извлечение квадратного корня";
            button1.Text = "Извлечь корень";
            label1.Text = String.Empty;
            textBox1.Clear();
            textBox1.TabIndex = 0;
        }
    }
}
