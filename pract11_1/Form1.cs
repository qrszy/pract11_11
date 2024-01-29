using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pract11_1.Form1;

namespace pract11_1
{
    public partial class Form1 :Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }
        public class Abonent
        {
            public string Name;
            public string Fam;
            public string otc;
            public string Adres;
            public double nomk;
            public string tipk;
            public double minme;
            public double ming;

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Abonent abonent1 = new Abonent();
            abonent1.Name = textBox1.Text;
            abonent1.Fam = textBox2.Text;
            abonent1.otc = textBox3.Text;
            abonent1.Adres = textBox4.Text;
            abonent1.nomk = (double) numericUpDown1.Value;
            abonent1.tipk = listBox1.Text;
            abonent1.minme= (double) numericUpDown2.Value;
            abonent1.ming = (double) numericUpDown3.Value;
            if (abonent1.ming < 500)
                MessageBox.Show("Абонент добавлен.\n Вводите новые данные");
            else if (abonent1.ming >= 500)
                MessageBox.Show(string.Format("Абоненты привысил кол-во минут \nФамилия: {0} \nИмя: {1}\nОтчество: {2} \nАдрес: {3} \nНомер карты: {4} \nТип карты: {5}", abonent1.Name, abonent1.Fam, abonent1.otc, abonent1.Adres, abonent1.nomk, abonent1.tipk));
            else if (abonent1.minme > 0)
                MessageBox.Show(string.Format("Абоненты пользовался междугородной связью.\nФамилия: {0} \nИмя: {1}\nОтчество: {2} \nАдрес: {3} \nНомер карты: {4} \nТип карты: {5}", abonent1.Name, abonent1.Fam, abonent1.otc, abonent1.Adres, abonent1.nomk, abonent1.tipk));

        }

        private void button2_Click (object sender, EventArgs e)
        {
            Abonent abonent2 = new Abonent();
            abonent2.Name = textBox1.Text;
            abonent2.Fam = textBox2.Text;
            abonent2.otc = textBox3.Text;
            abonent2.Adres = textBox4.Text;
            abonent2.nomk = (double) numericUpDown1.Value;
            abonent2.tipk = listBox1.Text;
            abonent2.minme = (double) numericUpDown2.Value;
            abonent2.ming = (double) numericUpDown3.Value;
         if(abonent2.ming<500)MessageBox.Show("Абонент добавлен.\n Вводите новые данные");
         else if (abonent2.ming >= 500)MessageBox.Show(string.Format("Абоненты привысил кол-во минут \nФамилия: {0} \nИмя: {1}\nОтчество: {2} \nАдрес: {3} \nНомер карты: {4} \nТип карты: {5}", abonent2.Name, abonent2.Fam, abonent2.otc, abonent2.Adres, abonent2.nomk, abonent2.tipk));
         else if(abonent2.minme>0)MessageBox.Show(string.Format("Абоненты пользовался междугородной связью.\nФамилия: {0} \nИмя: {1}\nОтчество: {2} \nАдрес: {3} \nНомер карты: {4} \nТип карты: {5}", abonent2.Name, abonent2.Fam, abonent2.otc, abonent2.Adres, abonent2.nomk, abonent2.tipk));

        }

        private void button3_Click (object sender, EventArgs e)
        {
            Abonent abonent3 = new Abonent();
            abonent3.Name = textBox1.Text;
            abonent3.Fam = textBox2.Text;
            abonent3.otc = textBox3.Text;
            abonent3.Adres = textBox4.Text;
            abonent3.nomk = (double) numericUpDown1.Value;
            abonent3.tipk = listBox1.Text;
            abonent3.minme = (double) numericUpDown2.Value;
            abonent3.ming = (double) numericUpDown3.Value;
            if (abonent3.ming < 500)
                MessageBox.Show("Абонент добавлен.\n Вводите новые данные");
            else if (abonent3.ming >= 500)
                MessageBox.Show(string.Format("Абоненты привысил кол-во минут \nФамилия: {0} \nИмя: {1}\nОтчество: {2} \nАдрес: {3} \nНомер карты: {4} \nТип карты: {5}", abonent3.Name, abonent3.Fam, abonent3.otc, abonent3.Adres, abonent3.nomk, abonent3.tipk));
            else if (abonent3.ming > 0)
                MessageBox.Show(string.Format("Абоненты пользовался междугородной связью.\nФамилия: {0} \nИмя: {1}\nОтчество: {2} \nАдрес: {3} \nНомер карты: {4} \nТип карты: {5}", abonent3.Name, abonent3.Fam, abonent3.otc, abonent3.Adres, abonent3.nomk, abonent3.tipk));
        }

        private void button4_Click (object sender, EventArgs e)
        {

        }
    }
}
