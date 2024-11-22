using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace carros
{
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
        }

        public void comboBox2_SelectIndexChanged(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");
            string imageFile = Path.Combine(imagePath, comboBox2.Text + ".png");

            //MessageBox.Show("Tentando carregar " + imageFile);

            if (File.Exists(imageFile))
            {
                pictureBox1.ImageLocation = imageFile;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Imagem não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void comboBox1_SelectIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if(comboBox1.Text == "Fiat")
            {
                comboBox2.Items.Add("Argo");
                comboBox2.Items.Add("Toro");
            } 
            
            else if (comboBox1.Text == "Chevrolet")
            {
                comboBox2.Items.Add("Onix");
                comboBox2.Items.Add("Camaro");
            }

            else if (comboBox1.Text == "Honda")
            {
                comboBox2.Items.Add("Civic");
                comboBox2.Items.Add("HRV");
            }

            else if (comboBox1.Text == "Toyota")
            {
                comboBox2.Items.Add("Corolla");
                comboBox2.Items.Add("Yaris");
            }

            else if (comboBox1.Text == "Bmw")
            {
                comboBox2.Items.Add("M3");
                comboBox2.Items.Add("320i");
            }

        }
        /*
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MarcaCarro_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
