using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticasCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int suma(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }

        void mostrarResultado(int resultado)
        {
            resultadoLabel.Text = "El resultado es: \n" + resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroUno = int.Parse(numeroUnoTextBox.Text);
            int numeroDos = int.Parse(numeroDosTextBox.Text);
            
            int resultado = suma(numeroUno, numeroDos);
            mostrarResultado(resultado);
        }
    }
}
