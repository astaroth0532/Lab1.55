using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) //захист від дурня
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x; //число, на яке будемо ділити
            int N = Convert.ToInt32(textBox2.Text); //введена змінна
            for (int i = 1; i <= N; i++) //загальний цикл
            {
                for (x = 2; x < i; x++)  //цикл, на що ділити
                {
                    if ((i % x) == 0) //якщо немає залишку від ділення
                    {
                        x = i + 1; // Робимо "x" більше "i" щоб вийти з циклу
                    }
                }
                if (x == i)   // x дорівнюватиме i якщо цикл закінчився сам
                {
                    label5.Text = i.ToString();     //вивід
                }
            }
        }
        
    }
}


