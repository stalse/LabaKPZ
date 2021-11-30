using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PobeliatskyiKPZ
{
    public partial class Form1 : Form
    {
        int a, b, c, d, e, f, g;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(Convert.ToInt32(Convert.ToString(comboBox1.SelectedItem)));
            }
            catch
            {

            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        void CreatePicture(Control Parent, Point Pos)
        {
            PictureBox pct = new PictureBox();
            pct.BackColor = Color.White;
            pct.Location = Pos;
            pct.Size = new Size(150, 70);
            pct.Text = listBox1.Text;
            Parent.Controls.Add(pct); 
        }

        int i = -70;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Це не число, введіть будь-ласка число");
                textBox1.Clear();
            }
            i += 80;
            CreatePicture(this, new Point(500, i));    
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
