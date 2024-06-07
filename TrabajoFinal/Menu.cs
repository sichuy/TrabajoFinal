using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new Cliente();
            formulario.Show();
        }

        private void btnPelicula_Click(object sender, EventArgs e)
        {
            Form formulario = new Pelicula();
            formulario.Show();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            Form formulario = new Alquiler();
            formulario.Show();
        }
    }
}
