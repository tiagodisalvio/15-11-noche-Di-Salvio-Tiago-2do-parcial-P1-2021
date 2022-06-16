using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto2Parcial
{
    public partial class Form1 : Form
    {

        Lista lista = new Lista();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarLista();
        }
     
        private void Registrar_Click(object sender, EventArgs e)
        {

            {
                lista.Registrarcliente(txtNombre.Text, txtImporte.Text);
                MostrarLista();
            }
        }

        private void MostrarLista()
        {
            listaPacientes.Items.Clear();
            AgreagarNodosAListbox();
        }

       private void AgreagarNodosAListbox()
        {
            Clientes CLIENTE = new Clientes();
            CLIENTE = lista.inicio;
            while (CLIENTE != null)
            {
                listaPacientes.Items.Add(CLIENTE.Nombre+" "+Convert.ToString(CLIENTE.Importe));
                CLIENTE = CLIENTE.proximoNumero;
            }
        }
 
    }

}

