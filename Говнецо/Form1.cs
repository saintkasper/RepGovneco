using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Говнецо
{
    public partial class Form1 : Form
    {
        string SuperSecretCode;

        Random rnd = new Random();
        bool side = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int valueX;
            int valueY;

            int firstX = button2.Location.X;
            int secondY = button2.Location.Y;

            int CursorX = Cursor.Position.X;
            int CursorY = Cursor.Position.Y;

            try
            {
                if (side == true)
                {
                    valueX = rnd.Next(0, 315);
                    valueY = rnd.Next(0, 410);

                    //valueX = GetRandomFromRange(rnd, new Range(0, firstX), new Range((firstX), 240));
                    //valueY = GetRandomFromRange(rnd, new Range(0, secondY), new Range((secondY), 410));
                    button2.Location = new Point(valueX, valueY);
                    side = false;
                }
                else if (side == false)
                {
                    valueX = rnd.Next(315, 630);
                    valueY = rnd.Next(0, 410);

                    //valueX = GetRandomFromRange(rnd, new Range(240, firstX), new Range((firstX), 630));
                    //valueY = GetRandomFromRange(rnd, new Range(0, secondY), new Range((secondY), 410));
                    button2.Location = new Point(valueX, valueY);
                    side = true;
                }
                //valueX = GetRandomFromRange(rnd, new Range(0, firstX - 350), new Range((firstX), 480));
                //valueY = GetRandomFromRange(rnd, new Range(0, secondY - 170), new Range((secondY), 340));
                //button2.Location = new Point(valueX, valueY);
            }
            catch
            {
                valueX = GetRandomFromRange(rnd, new Range(0, firstX), new Range((firstX), 630));
                valueY = GetRandomFromRange(rnd, new Range(0, secondY), new Range((secondY), 410));
                button2.Location = new Point(valueX, valueY);
                MessageBox.Show("не сработало");
            }

        }

        static int GetRandomFromRange(Random rnd, params Range[] ranges)
        {
            int idx = rnd.Next(ranges.Length);
            Range range = ranges[idx];
            return rnd.Next(range.MinValue, range.MaxValue);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кого ты обманываешь?\nТы в лигу играешь");
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SuperSecretCode = "1";
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            SuperSecretCode += "2";
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            SuperSecretCode += "3";
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            SuperSecretCode += "4";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            SuperSecretCode += "5";
            if (SuperSecretCode == "12345")
            {
                MessageBox.Show("Вы победили!\nОтправьте скрин этого окна Теплых Сергею и вы получите 1 рубль!");
            }
            else SuperSecretCode = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я знал, лошара☺");
        }
    }
}
//Кнопка - 150; 50      Начальное положение: 472; 329       Допустимые значения ---- 630; 410
//Окно - 800; 500