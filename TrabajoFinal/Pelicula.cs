using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class Pelicula : Form
    {
        public Pelicula()
        {
            InitializeComponent();
            llenarGrid();
        }

        public void limpiar_controles()
        {
            cbEPeli.Items.Clear();
            txtTitulo.Clear();
            cbNac.Items.Clear();
            cbProductor.Items.Clear();
            cbConservacion.Items.Clear();
            txtclave.Clear();
        }
        public void llenarGrid()
        {
            dataGridView1.DataSource = Operacion_pelicula.VisualizarContacto();
            lblClaveD.Enabled = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CamposPelicula camposPelicula = new CamposPelicula();
            camposPelicula.Num_de_ejemplar = int.Parse(cbEPeli.Text);
            camposPelicula.Titulo = txtTitulo.Text;
            camposPelicula.Nacionalidad = cbNac.Text;
            camposPelicula.Productor = cbProductor.Text;
            camposPelicula.Conservacion = cbConservacion.Text;
            camposPelicula.Clave_Director = int.Parse(txtclave.Text);
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDcontacto"].Value);
                if (id != null)
                {
                    camposPelicula.Clave_Director = id;
                    int resultado = Operacion_pelicula.Update(camposPelicula);
                    if (resultado > 0)
                    {
                        MessageBox.Show("resgistro actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("no se actualizo el registro");
                    }
                }
            }
            else
            {

                int resultado = Operacion_pelicula.Insertar(camposPelicula);

                if (resultado > 0)
                {
                    MessageBox.Show("dato insertado correctamente");
                }
                else
                { MessageBox.Show("error al insertar"); }
                llenarGrid();

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDcontacto"].Value);
                int resultado = Operacion_pelicula.Delete(id);
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



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiar_controles();
        }
    }
}

