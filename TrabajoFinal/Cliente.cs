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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            llenarGrid();
        }
        public void limpiar()
        {
            txtDNI_C.Clear();
            txtNOM.Clear();
            txtDIR.Clear();
            txtTEL.Clear();
            txtDNI_S.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CamposCliente camposCliente = new CamposCliente();
            camposCliente.Dni_cliente = int.Parse(txtDNI_C.Text);
            camposCliente.Nombre = txtNOM.Text;
            camposCliente.Direccion = txtDIR.Text;
            camposCliente.Telefono = txtTEL.Text;
            camposCliente.Dni_socio = txtDNI_S.Text;

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dniCliente"].Value);
                if (id != null)
                {
                    camposCliente.Dni_cliente = id;
                    int resultado = OperacionCliente.Update(camposCliente);
                    if (resultado > 0)
                    {
                        MessageBox.Show("registro actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("no se actualizo el registro");
                    }
                }
            }
            else
            {

                int resultado = OperacionCliente.Insertar(camposCliente);

                if (resultado > 0)
                {
                    MessageBox.Show("dato insertado correctamente");
                }
                else
                { MessageBox.Show("error al insertar"); }
            }
            llenarGrid();
        }
        public void llenarGrid()
        {
            dataGridView1.DataSource = OperacionCliente.VisualizarContacto();
            txtDNI_C.Enabled = true;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dniCliente"].Value);
                int resultado = OperacionCliente.Delete(id);
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtDNI_C.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dni_cliente"].Value);
            txtNOM.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            txtDIR.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["direccion"].Value);
            txtTEL.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["telefono"].Value);
            txtDNI_S.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dni_socio"].Value);
           
        }
    }
}
