using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRUD_Calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
                {
                    cliente.crear(Int32.Parse(tbNC.Text), tbNombre.Text, Int32.Parse(tbCalculo.Text), Int32.Parse(tbCalidad.Text), Int32.Parse(tbIngles.Text), Int32.Parse(tbAdmon.Text), Int32.Parse(tbTopicos.Text));
                    MessageBox.Show("los datos han sido gurdados");
                }
                tbNC.Text = "";
                tbNombre.Text = "";
                tbCalculo.Text = "";
                tbCalidad.Text = "";
                tbIngles.Text = "";
                tbAdmon.Text = "";
                tbTopicos.Text = "";
            }
            catch
            {
                MessageBox.Show("Ingrese datos para registrar");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
                {
                    if (cliente.modificar(Int32.Parse(tbNC.Text), tbNombre.Text, Int32.Parse(tbCalculo.Text), Int32.Parse(tbCalidad.Text), Int32.Parse(tbIngles.Text), Int32.Parse(tbAdmon.Text), Int32.Parse(tbTopicos.Text)))
                    {
                        MessageBox.Show("los datos han sido modificados");
                    }
                    else
                    {
                        MessageBox.Show("los datos no han sido modificados");
                    }
                }
                tbNC.Text = "";
                tbNombre.Text = "";
                tbCalculo.Text = "";
                tbCalidad.Text = "";
                tbIngles.Text = "";
                tbAdmon.Text = "";
                tbTopicos.Text = "";
            }
            catch
            {
                MessageBox.Show("No hay datos para modificar");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
            {
                try
                {
                    if (cliente.eliminar(Int32.Parse(tbNC.Text)))
                    {
                        MessageBox.Show("los datos han sido eliminados");
                    }
                    else
                    {
                        MessageBox.Show("los datos no existen");
                    }
                }
                catch
                {
                    MessageBox.Show("Seleccione un elemento a eliminar");
                }
            }
            tbNC.Text = "";
            tbNombre.Text = "";
            tbCalculo.Text = "";
            tbCalidad.Text = "";
            tbIngles.Text = "";
            tbAdmon.Text = "";
            tbTopicos.Text = "";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lbxCal.Items.Clear();
            string[] lista;
            using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
            {
                try
                {
                    lista = cliente.leer();
                    for (int i = 0; i < lista.Count<string>(); i = i + 7)
                    {
                        lbxCal.Items.Add(lista[i].ToString() + " " + lista[i + 1].ToString() + " " + lista[i + 2].ToString() + " " + lista[i + 3].ToString() + " " + lista[i + 4].ToString() + " " + lista[i + 5].ToString() + " " + lista[i + 6].ToString());

                    }
                }
                    catch
                     {
                         MessageBox.Show("No existen registros en la base de datos");
                     }
             }
         }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] vector = new string[6];
            using (ServiceReference1.Service2Client cliente = new ServiceReference1.Service2Client())
            {
                try
                {
                    vector = cliente.buscar(Convert.ToInt32(tbNC.Text));
                    if (vector[0] == null)
                    {
                        MessageBox.Show("No hay datos");
                    }
                    else
                    {

                        tbNombre.Text = vector[1];
                        tbCalculo.Text = vector[2];
                        tbCalidad.Text = vector[3];
                        tbIngles.Text = vector[4];
                        tbAdmon.Text = vector[5];
                        tbTopicos.Text = vector[6];
                    }
                  }
                    catch
                    {
                        MessageBox.Show("Ingrese datos para buscar");
                    }
                }
            }
        }
    }
