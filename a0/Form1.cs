using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList ogrenciler = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Ogrenci()
        {
            listBox1.Items.Clear();
            foreach (var item in ogrenciler)
            {
                listBox1.Items.Add(item);
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            ogrenciler.Add(textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Ogrenci();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int h = listBox1.SelectedIndex;
            ogrenciler.Insert(h,textBox1.Text);
            Ogrenci();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string h = textBox1.Text;
            ogrenciler.Remove(h);
            Ogrenci();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int h = listBox1.SelectedIndex;
            ogrenciler.RemoveAt(h);
            Ogrenci();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int h = listBox1.SelectedIndex;
            ogrenciler[h] = textBox1.Text;
            Ogrenci();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string h = textBox1.Text;
            if (ogrenciler.Contains(h))
            {
                MessageBox.Show(h + " aranan bulundu","arama sonucu");
            }
            else
            {
                MessageBox.Show(h + " aranan bulunamadı","arama sonucu");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ogrenciler.Reverse();
            Ogrenci();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)listBox1.SelectedItem;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ogrenciler.Sort();
            Ogrenci();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ogrenciler.Sort();
            ogrenciler.Reverse();
            Ogrenci();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
