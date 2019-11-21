using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebastian_MortaLab1
{
    public partial class FormName : Form
    {
        public FormName()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Prycisk do zmieniania koloru programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) 
        {
            //zmiana koloru tła
            BackColor = Color.Red;
            buttonColor.BackColor = Color.Red;
            Name.BackColor = Color.PowderBlue;

        }

        private void FormName_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Przycisk liczacy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            number += 9;
            MessageBox.Show(number.ToString());
        }
        /// <summary>
        /// Funkcja uruchamiajaca obliczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            //zamiana typu zmiennych
            number = Int32.Parse(textBoxCount.Text);
            //number += 9;
            //MessageBox.Show(number.ToString());
            if (number >= 10 && number<30)
            {
                BackColor = Color.BlanchedAlmond;
            }
            else if (number <= 10)
            {
                BackColor = Color.BlanchedAlmond;
            }
            else
            {
                BackColor = Color.Chocolate;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                // powięksanie co sekundę 
                number2++;
            textBoxCount.Text = number2.ToString();
            if (number2 > 10) BackColor = Color.Coral;
            else if (number2 < 10) BackColor = Color.CadetBlue;
        }
        /// <summary>
        /// funkcja uruchamiająca timer
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //ilość sekund między zdarzeniami
            timerCount.Interval = 1000;
            timerCount.Start();
            buttonStart.Left += number2;

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerCount.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void NewWindow_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            //wyświetlnie nowego okienka
            formAbout.formName = "SEB";
            formAbout.Show();
        }
    }
}
