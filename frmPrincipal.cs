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
            int constanteK = Int32.Parse(inputK.Text);
            int constanteG = Int32.Parse(inputG.Text);

            // Controlar que "c" sea relativamente primo a "m" que el unico divisor entre ellos sea el 1

            // Calcular y mostrar el valor de "a"
            int valorCteA = 1 + 4 * constanteK;
            inputA.Text = valorCteA.ToString();

            // Calcular y mostrar el valor de "m (módulo)"
            double valorM = Math.Pow(2, constanteG);
            inputModulo.Text = valorM.ToString();

            // Ciclo for para realizar el cálculo del metodo
            for( int i = 0; i < 20; i++ )
            {
                // Mostrar los valores en la tabla
                dgvTablaResultados.Rows.Add(i, 2, 3, 6);
            }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inputSemilla.Text = "";
            inputK.Text = "";
            inputG.Text = "";
            inputCc.Text = "";
            inputA.Text = "";
            inputModulo.Text = "";
        }
    }
}
