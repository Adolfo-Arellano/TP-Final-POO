using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador_POO
{
    public class Cafe
    {
        public string nombre;
        public int precio;

        public Cafe(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }

    public class Comida
    {
        public string nombre;
        public int precio;

        public Comida(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Validacion());


            
        }


    }


}
