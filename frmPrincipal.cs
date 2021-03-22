using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp1
{
    public partial class frmPrincipal : Form
    {
        DataTable tablaValores;
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
            decimal valorXo = numSemilla.Value;
            int valorC = Convert.ToInt32(numC.Value);


            // Calcular y mostrar el valor de "a"
            int valorA = Convert.ToInt32(numA.Value);
            //inputA.Text = valorA.ToString();

            // Calcular y mostrar el valor de "m (módulo)"
            double valorM = Convert.ToInt32(numM.Value);
            //inputModulo.Text = valorM.ToString();

            tablaValores.Clear();
            // Ciclo for para realizar el cálculo del metodo
            for ( int i = 0; i < 20; i++ )
            {
                int Xi, Xi1 = 0;

                if (i == 0)
                {
                    Xi1 = Convert.ToInt32(valorXo);
                }
                else
                {
                    int ans = i - 1;
                    Xi1 = int.Parse(tablaValores.Rows[ans][1].ToString());
                }
                // Calcular el termino a.Xi + c
                Xi = ( valorA * Xi1 ) + valorC;

                // Calcular el valor del termino X(i+1) que reemplaza a Xo (raiz)
                Xi1 = Convert.ToInt32(Xi % valorM);

                // Calcular el termino (Xi+1)/(m-1) y redondear a 4 decimales
                double numAleatorio = Math.Round((Xi1 / valorM) , 4)  ;
                //decimal resultado = decimal.Round(Convert.ToDecimal(calculoUltimoTermino), 4);

                // Mostrar los valores en la tabla
                tablaValores.Rows.Add(i, Xi1, numAleatorio);
            }

            dgvTablaResultados.DataSource = tablaValores;
            dgvTablaResultados.Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numA.ResetText();
            numC.ResetText();
            numM.ResetText();
            numSemilla.ResetText();
            dgvTablaResultados.Rows.Clear();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tablaValores = new DataTable();
            tablaValores.Columns.Add("I");
            tablaValores.Columns.Add("Xi+1");
            tablaValores.Columns.Add("Num Aleatorio");
        }

        private void btnMultiplicativo_Click(object sender, EventArgs e)
        {
            decimal valorXo = numSemilla.Value;
            int valorC = Convert.ToInt32(numC.Value);


            // Calcular y mostrar el valor de "a"
            int valorA = Convert.ToInt32(numA.Value);
            //inputA.Text = valorA.ToString();

            // Calcular y mostrar el valor de "m (módulo)"
            double valorM = Convert.ToInt32(numM.Value);
            //inputModulo.Text = valorM.ToString();
            tablaValores.Clear();

            // Ciclo for para realizar el cálculo del metodo
            for (int i = 0; i < 20; i++)
            {
                int Xi, Xi1 = 0;

                if (i == 0)
                {
                    Xi1 = Convert.ToInt32(valorXo);
                }
                else
                {
                    int ans = i - 1;
                    Xi1 = int.Parse(tablaValores.Rows[ans][1].ToString());
                }
                // Calcular el termino a.Xi
                Xi = (valorA * Xi1);

                // Calcular el valor del termino X(i+1) que reemplaza a Xo (raiz)
                Xi1 = Convert.ToInt32(Xi % valorM);

                // Calcular el termino (Xi+1)/(m-1) y redondear a 4 decimales
                double numAleatorio = Math.Round((Xi1 / valorM), 4);
                //decimal resultado = decimal.Round(Convert.ToDecimal(calculoUltimoTermino), 4);

                // Mostrar los valores en la tabla
                tablaValores.Rows.Add(i, Xi1, numAleatorio);
            }

            dgvTablaResultados.DataSource = tablaValores;
            dgvTablaResultados.Refresh();
        }
        /*
private void btnMultiplicativo_Click(object sender, EventArgs e)
{
double valorXo = Int32.Parse(inputSemilla.Text);

// Limpiar la grilla
dgvTablaResultados.Rows.Clear();

// Limpiar y desabilitar "c" porque no se necesita para el calculo
inputCc.Text = "0";
inputCc.Enabled = false;


// Calcular y mostrar el valor de "a"
int valorA = 3 + (8 * valorK);
inputA.Text = valorA.ToString();

// Calcular y mostrar el valor de "m" (Módulo)
double valorM = Math.Pow(2, valorG);
inputModulo.Text = valorM.ToString();

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
dgvTablaResultados.Rows.Add(i + 1, aXi, valorXo, resultado);
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
} */
    }
}
