using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLineal_Click(object sender, EventArgs e)
        {
            // Limpiar la grilla
            dgvResultadosLineal.Rows.Clear();

            double valorXo = Int32.Parse(inputXoLineal.Text);
            int valorC = Int32.Parse(inputCcLineal.Text);

            // Verificar que "g" sea un nro entero positivo
            int valorG = verificarEnteroPositivo(inputGLineal.Text, "g");
            if(valorG == -1)
            {
                // Es return; asi deja de ejecutar el codigo que sigue
                return;
            }

            // Verificar que "k" sea un nro entero positivo
            int valorK = verificarEnteroPositivo(inputKLineal.Text, "k");
            if (valorK == -1)
            {
                return;
            }

            // Calcular y mostrar el valor de "a"
            int valorA = 1 + 4 * valorK;
            inputALineal.Text = valorA.ToString();

            // Calcular y mostrar el valor de "m (módulo)"
            double valorM = Math.Pow(2, valorG);
            inputMLineal.Text = valorM.ToString();

            // Controlar que "c" sea relativamente primo a "m" que el unico divisor entre ellos sea el 1 (FALTA!!!!!)

            // Ciclo for para realizar el cálculo del metodo
            for ( int i = 0; i < 20; i++ )
            {
                // Calcular el termino a.Xi + c
                double aXi = ( valorA * valorXo ) + valorC;

                // Calcular el valor del termino X(i+1) que reemplaza a Xo (raiz)
                valorXo = aXi % valorM;

                // Calcular el termino (Xi+1)/(m-1) y redondear a 4 decimales
                double calculoUltimoTermino = valorXo / (valorM - 1);
                decimal resultado = decimal.Round(Convert.ToDecimal(calculoUltimoTermino), 4);

                // Mostrar los valores en la tabla
                dgvResultadosLineal.Rows.Add(i + 1 , aXi, valorXo, resultado);
            }
        }

        private int verificarEnteroPositivo(String nroAValirdar, String nombreNroAValidar)
        {
            int valorResultante;
            bool success = Int32.TryParse(nroAValirdar, out valorResultante);

            if (!success)
            {
                MessageBox.Show("El numero " + nombreNroAValidar + " ingresado debe ser un entero");
                return -1;
            }
            else if (valorResultante < 0)
            {
                MessageBox.Show("El numero " + nombreNroAValidar + " debe ser positivo");
                return -1;
            } else
            {
                return valorResultante;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inputXoLineal.Text = "";
            inputKLineal.Text = "";
            inputGLineal.Text = "";
            inputCcLineal.Text = "";
            inputALineal.Text = "";
            inputMLineal.Text = "";
            dgvResultadosLineal.Rows.Clear();
        }

        private void btnMultiplicativo_Click(object sender, EventArgs e)
        {
            double valorXo = Int32.Parse(inputXoMultiplicativo.Text);

            // Limpiar la grilla
            dgvResultadosMultiplicativo.Rows.Clear();

           
            // Vertificar que K sea entero positivo
            int valorK = verificarEnteroPositivo(inputKMultiplicativo.Text, "k");
            if(valorK == -1)
            {
                return;
            }

            // Verificar que g sea entero
            int valorG;
            bool successG = Int32.TryParse(inputGMultiplicativo.Text, out valorG);
            if(!successG)
            {
                MessageBox.Show("El número g ingresado debe ser un entero");
                return;
            }

            // Verificar que X0 (Semilla) sea un numero impar 
            if (!esImpar(valorXo))
            {
                MessageBox.Show("El valor de Xo (Semilla) no es impar");
                return;
            }

            // Calcular y mostrar el valor de "a"
            int valorA = 3 + (8 * valorK);
            inputAMultiplicativo.Text = valorA.ToString();

            // Calcular y mostrar el valor de "m" (Módulo)
            double valorM = Math.Pow(2, valorG);
            inputMMultiplicativo.Text = valorM.ToString();

            // Ciclo para el cálculo del método
            for( int i = 0; i < 20; i++  )
            {
                // Calcular el termino a.Xi
                double aXi = valorA * valorXo;

                // Calcular el término X(i+1) que reemplaza a Xo
                valorXo = aXi % valorM;

                // Calcular el ultimo termino y redondear a 4 decimales
                double ultimoTermino = valorXo / (valorM - 1);
                decimal resultado = decimal.Round(Convert.ToDecimal(ultimoTermino), 4);

                // Mostrar los valores en la tabla
                dgvResultadosMultiplicativo.Rows.Add(i + 1, aXi, valorXo, resultado);
            }
        }

        private Boolean esImpar(double nro)
        {
           if( nro % 2 == 0 )
            {
                return false;
            } else
            {
                return true;
            }
        }

        private void btnLimpiarMultiplicativo_Click(object sender, EventArgs e)
        {
            inputXoMultiplicativo.Text = "";
            inputKMultiplicativo.Text = "";
            inputGMultiplicativo.Text = "";
            inputAMultiplicativo.Text = "";
            inputMMultiplicativo.Text = "";
            dgvResultadosMultiplicativo.Rows.Clear();
        }

    }
}
