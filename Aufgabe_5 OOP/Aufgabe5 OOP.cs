using Aufgabe_5;
using System;
using System.Windows.Forms;

namespace LastNr._5

{




    public partial class Form1 : Form
    {
        public Tree t = new Tree();
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Draw_Click(object sender, EventArgs e)
        {
            t.Treeheight = Convert.ToInt32(theight.Text);
            t.Treewidth = Convert.ToInt32(twidth.Text);
            t.Crownheight = Convert.ToInt32(crownheight.Text);

            if (t.Treewidth > 0 && t.Treeheight > 0 && t.Crownheight > 0)
            {
                t.Zeichnen();
            }

            tresult.Text = t.Result;
        }

        private void theight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
