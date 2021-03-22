using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp1
{
    public partial class frmPrincipal : Form
    {
        DataTable tablaValores;
        enum Metodo
        { lineal, multiplicativo }
        Metodo metodoActual;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tablaValores = new DataTable();
            tablaValores.Columns.Add("I");
            tablaValores.Columns.Add("Xi+1");
            tablaValores.Columns.Add("Num Aleatorio");
            btnSiguienteValor.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numA.ResetText();
            numC.ResetText();
            numM.ResetText();
            numSemilla.ResetText();
            tablaValores.Clear();
            dgvTablaResultados.Refresh();
            btnSiguienteValor.Enabled = false;
        }

        private void btnLineal_Click(object sender, EventArgs e)
        {
            metodoActual = Metodo.lineal;
            Congruente_Lineal();
            btnSiguienteValor.Enabled = true;

        }

        private void btnMultiplicativo_Click(object sender, EventArgs e)
        {
            metodoActual = Metodo.multiplicativo;
            CongruenteMultiplicativo();
            btnSiguienteValor.Enabled = true;
        }

        private void btnSiguienteValor_Click(object sender, EventArgs e)
        {
            if (metodoActual == Metodo.lineal)
            {
                int n = tablaValores.Rows.Count + 1;

                Congruente_Lineal(n);
            }
            else if (metodoActual == Metodo.multiplicativo)
            {
                int n = tablaValores.Rows.Count + 1;
                CongruenteMultiplicativo(n);
            }
        }

        private void CongruenteMultiplicativo(int n = 20)
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
            for (int i = 0; i < n; i++)
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

        private void Congruente_Lineal(int n = 20)
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
            for (int i = 0; i < n; i++)
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
                Xi = (valorA * Xi1) + valorC;

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
    }
}
