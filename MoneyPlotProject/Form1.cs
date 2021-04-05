using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyPlotProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var p = new MoneyPlotProject.LoadDataHelper();

            chart1.Series["USD/PLN"].Color = Color.Red;
            chart1.Series["USD/GBP"].Color = Color.Blue;
            chart1.Series["USD/EUR"].Color = Color.Green;

            int year = int.Parse(textBox1.Text);
            int n = 2021 - year + 1;
            for (int i = 0; i < n; i++)
            {
                Money m = await p.Load(i+year);
                chart1.Series["USD/PLN"].Points.AddXY(i+year, m.Rates.PLN);
                chart1.Series["USD/GBP"].Points.AddXY(i+year, m.Rates.GBP);
                chart1.Series["USD/EUR"].Points.AddXY(i+year, m.Rates.EUR);

            }
        }
    }
}
