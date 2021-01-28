using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Aufgabe_07_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WordCount_Click(object sender, EventArgs e)
        {
            WordTab wrdTab = new WordTab();
            Parser parser = new Parser(wrdTab);
            try
            {
                parser.Parse(textBox1.Text);
                String table = wrdTab.GetTab();
                wrdTab.PrintTab(table, OutputBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
