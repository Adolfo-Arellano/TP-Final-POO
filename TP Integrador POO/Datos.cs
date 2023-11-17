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
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();

            comboBox1.Items.Add("Realizar un pedido");
            comboBox1.Items.Add("Modificar pedido");
            comboBox1.Items.Add("Eliminar pedido");
            comboBox1.Items.Add("Ver pedido");
            comboBox1.Items.Add("Realizar pago");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = comboBox1.SelectedItem.ToString();

            switch (opcionSeleccionada)
            {
                case "Realizar un pedido":
                    FormRealizarPedido formRealizarPedido = new FormRealizarPedido();
                    formRealizarPedido.Show();
                    break;

                case "Modificar pedido":
                    // Permitir la modificación del pedido (si es posible desde este formulario)
                    // Se asume que se podrá modificar el pedido desde este formulario
                    // Aquí podrías implementar la lógica para modificar el pedido
                    MessageBox.Show("Se permitirá modificar el pedido");
                    break;

                case "Ver pedido":
                    // Mostrar un resumen o detalles del pedido
                    //FormVerPedido formVerPedido = new FormVerPedido();
                    //formVerPedido.Show();
                    break;

                case "Eliminar pedido":
                    // Eliminar todo el pedido realizado
                    // Aquí podrías implementar la lógica para eliminar el pedido
                    MessageBox.Show("Se eliminará todo el pedido realizado");
                    break;

                case "Realizar pago":
                    // Redirigir al formulario de realizar pago
                    //FormRealizarPago formRealizarPago = new FormRealizarPago();
                    //formRealizarPago.Show();
                    break;

                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
