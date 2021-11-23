using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTransport;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Transport transport;
        Display display;
        public Form1()
        {
            InitializeComponent();
            display = new Display();
            transport = new Transport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.price.Visible = false;
            transport.n = int.Parse(display.n.Text);
            transport.dayOrNight = display.dayOrNight.Text;
            display.ShowDialog();
            display.price.Visible = true;
            display.price.Text = transport.GetPrice().ToString();
            display.Show();
        }
    }
}
