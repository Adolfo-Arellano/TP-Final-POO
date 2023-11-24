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
    public partial class MedioDePago : Form
    {
        public MedioDePago(Seleccion seleccion)
        {
            InitializeComponent();

            var listaCafes = new List<Cafe>();
            var listaComida = new List<Comida>();

            listaCafes.Add(new Cafe("Expresso", 5));
            listaCafes.Add(new Cafe("Doble Expresso", 7));
            listaCafes.Add(new Cafe("Americano", 4));
            listaCafes.Add(new Cafe("Capuccino", 5));
            listaCafes.Add(new Cafe("Mocha", 10));
            listaCafes.Add(new Cafe("Irish Coffee", 15));
            listaCafes.Add(new Cafe("Latte", 3));
            listaCafes.Add(new Cafe("Expresso Cappucchino", 8)); 
            
            listaComida.Add(new Comida("Dona c/cubierta de fresa", 4));
            listaComida.Add(new Comida("Galleta c/chips de Chocolate", 5));
            listaComida.Add(new Comida("Dona c/glaseado de fresas", 5));
            listaComida.Add(new Comida("Pionono de crema chantilly", 9));
            listaComida.Add(new Comida("Muffin de Vainilla", 20));
            listaComida.Add(new Comida("Cheesecake", 25));
            listaComida.Add(new Comida("Brownie", 20));
            listaComida.Add(new Comida("Pasta Frola", 13));
            listaComida.Add(new Comida("Pancake c/Frutos rojos", 12));

            //resumen
            var cafe = listaCafes[seleccion.cafe];
            productoUno.Text = cafe.nombre;
            var comida = listaComida[seleccion.comida];
            productoDos.Text = comida.nombre;
            cantUno.Text = seleccion.cantCafe.ToString();
            cantDos.Text = seleccion.cantComida.ToString();

            //precios

            var totalCafe = cafe.precio * seleccion.cantCafe;
            precioCafe.Text = $"${totalCafe.ToString()}";

            var totalComida = comida.precio * seleccion.cantComida;
            precioComida.Text = $"${totalComida.ToString()}";

            //precio Total
            var precioTotal = totalCafe + totalComida;
            total.Text = $"${precioTotal.ToString()}";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void MedioDePago_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cantDos_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formComprobante = new Comprobante();
            formComprobante.ShowDialog();
        
        }
    }
}
