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

            //int resultado = suma(numeroUno, numeroDos);
            //mostrarResultado(resultado);

            //LOTERIA
            //if (numeroUno == 8)  resultadoLabel.Text = "Te ha tocado";
            //else  resultadoLabel.Text = "No te ha tocado nada";

            //REPASO IF
            //TABLA MULTIPLICAR CON NÚMERO TOPE
            String resultado =  "TABLA DE MULTIPLICAR";
            for(int i=1; i<= numeroDos; i++)
            {
                int resultadoMultiplicacion = i * numeroUno;
                resultado += "\n" + numeroUno + " x " + i + " = " + resultadoMultiplicacion;                
            }
            resultadoLabel.Text = resultado;
        }
    }
}
