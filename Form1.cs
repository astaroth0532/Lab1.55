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
        int N = 1; // Последнее проверяемое число
        int x; //Число на которое будем делить


        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= N; i++) //общий цикл
            {
                for (x = 2; x < i; x++) //цикл на что делить 
                {
                    if (!(i % x)) //если нет остатка от деления
                    {
                        x = i + 1; // Делаем "x" болше "i" чтоб выйти из цикла
                    }
                }
                if (x == i) // x будет равен i если цикл кончился сам
                {
                    cout << i << endl; // Вывод в терминале
                }
            }
            return 0;// Возврат main = 0 (0 - без ошибок)
        }

    }
}
}

