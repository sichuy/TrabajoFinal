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
    public partial class Alquiler : Form
    {
        public Alquiler()
        {
            InitializeComponent();
            llenarGrid();
        }
        public void limpiar()
        {

        }
        public void llenarGrid()
        {
            dataGridView1.DataSource = OperacionAlquiler.VisualizarContacto();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDcontacto"].Value);
                int resultado = OperacionAlquiler.Delete(id);
                if (resultado > 0)
                {
                    MessageBox.Show("eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("no se elimino");
                }
            }
            llenarGrid();
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
