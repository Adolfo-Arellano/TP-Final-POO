using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador_POO
{
    public partial class FormRealizarPedido : Form
    {
        public FormRealizarPedido()
        {
            InitializeComponent();

            this.BackColor = Color.White;


            
            comboBox1.Items.Add("Expresso");
            comboBox1.Items.Add("Doble Expresso");
            comboBox1.Items.Add("Americano");
            comboBox1.Items.Add("Cappucchino");
            comboBox1.Items.Add("Mocha");
            comboBox1.Items.Add("Irish Coffee");
            comboBox1.Items.Add("Latte");
            comboBox1.Items.Add("Expresso Cappucchino");
            comboBox1.SelectedIndex = 0;

         
            comboBox2.Items.Add("Dona c/cubierta de fresa");
            comboBox2.Items.Add("Galleta c/chips de Chocolate");
            comboBox2.Items.Add("Dona c/glaseado de fresas");
            comboBox2.Items.Add("Pionono de crema chantilly");
            comboBox2.Items.Add("Muffin de Vainilla");
            comboBox2.Items.Add("Cheesecake");
            comboBox2.Items.Add("Brownie");
            comboBox2.Items.Add("Pasta Frola");
            comboBox2.Items.Add("Pancake c/Frutos rojos");
            comboBox2.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormRealizarPedido_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formMedioDePago = new MedioDePago();
            formMedioDePago.ShowDialog();
        }
    }
}
