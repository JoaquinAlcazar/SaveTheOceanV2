using SaveTheOceanLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOceanV2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboBox1.Items.Add("Tecnic");
            comboBox1.Items.Add("Veterinari");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                player player = new player();
                player.selectName(textBox3.Text);
                player.selectType(comboBox1.Text);
                player.SaveToXml();

                //Close this form and open Form3
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            } catch (Exception ex)
            {
                MessageBox.Show("Error: Has de rellenar los dos campos");
            }
        }
    }
}
