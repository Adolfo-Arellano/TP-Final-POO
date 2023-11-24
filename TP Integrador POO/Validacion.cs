using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador_POO
{
    public partial class Validacion : Form
    {
        public Validacion()
        {
            InitializeComponent();
            pictureBox1.SendToBack();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click_1(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Digite la contraseña");
                txtPass.Focus();
            }
            else if (txtUser.Text == "")
            {
                MessageBox.Show("Digite su nombre de usuario");
                txtUser.Focus();
            }
            else
            {
                if (txtPass.Text == "123")
                {
                    MessageBox.Show("Contraseña correcta");
                    Datos misDatos = new Datos();
                    misDatos.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Validacion_Load(object sender, EventArgs e)
        {

        }
    }
}
