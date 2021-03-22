namespace sim_tp1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.inputMLineal = new System.Windows.Forms.TextBox();
            this.inputALineal = new System.Windows.Forms.TextBox();
            this.inputCcLineal = new System.Windows.Forms.TextBox();
            this.inputGLineal = new System.Windows.Forms.TextBox();
            this.inputKLineal = new System.Windows.Forms.TextBox();
            this.inputXoLineal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnMultiplicativo = new System.Windows.Forms.Button();
            this.btnSiguienteValorLineal = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvResultadosLineal = new System.Windows.Forms.DataGridView();
            this.btnLimpiarLineal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputMMultiplicativo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inputAMultiplicativo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputGMultiplicativo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inputKMultiplicativo = new System.Windows.Forms.TextBox();
            this.inputXoMultiplicativo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvResultadosMultiplicativo = new System.Windows.Forms.DataGridView();
            this.i_multiplicativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aXi_multiplicativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xsiguiente_multiplicativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo_multiplicativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguienteValorMultiplicativo = new System.Windows.Forms.Button();
            this.btnLimpiarMultiplicativo = new System.Windows.Forms.Button();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aXi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siguienteNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fórmula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosLineal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosMultiplicativo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.inputMLineal);
            this.gbParametros.Controls.Add(this.inputALineal);
            this.gbParametros.Controls.Add(this.inputCcLineal);
            this.gbParametros.Controls.Add(this.inputGLineal);
            this.gbParametros.Controls.Add(this.inputKLineal);
            this.gbParametros.Controls.Add(this.inputXoLineal);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(502, 88);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros Lineal";
            // 
            // inputMLineal
            // 
            this.inputMLineal.Enabled = false;
            this.inputMLineal.Location = new System.Drawing.Point(393, 54);
            this.inputMLineal.Name = "inputMLineal";
            this.inputMLineal.Size = new System.Drawing.Size(100, 20);
            this.inputMLineal.TabIndex = 17;
            // 
            // inputALineal
            // 
            this.inputALineal.Enabled = false;
            this.inputALineal.Location = new System.Drawing.Point(393, 28);
            this.inputALineal.Name = "inputALineal";
            this.inputALineal.Size = new System.Drawing.Size(100, 20);
            this.inputALineal.TabIndex = 16;
            // 
            // inputCcLineal
            // 
            this.inputCcLineal.Location = new System.Drawing.Point(257, 54);
            this.inputCcLineal.Name = "inputCcLineal";
            this.inputCcLineal.Size = new System.Drawing.Size(100, 20);
            this.inputCcLineal.TabIndex = 15;
            // 
            // inputGLineal
            // 
            this.inputGLineal.Location = new System.Drawing.Point(257, 28);
            this.inputGLineal.Name = "inputGLineal";
            this.inputGLineal.Size = new System.Drawing.Size(100, 20);
            this.inputGLineal.TabIndex = 14;
            // 
            // inputKLineal
            // 
            this.inputKLineal.Location = new System.Drawing.Point(118, 54);
            this.inputKLineal.Name = "inputKLineal";
            this.inputKLineal.Size = new System.Drawing.Size(100, 20);
            this.inputKLineal.TabIndex = 13;
            // 
            // inputXoLineal
            // 
            this.inputXoLineal.Location = new System.Drawing.Point(118, 28);
            this.inputXoLineal.Name = "inputXoLineal";
            this.inputXoLineal.Size = new System.Drawing.Size(100, 20);
            this.inputXoLineal.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "m ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "a ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "cc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "k";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xo (Semilla)";
            // 
            // btnLineal
            // 
            this.btnLineal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineal.Location = new System.Drawing.Point(12, 106);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(243, 35);
            this.btnLineal.TabIndex = 1;
            this.btnLineal.Text = "Método Congruencial Lineal\r\n";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicativo.Location = new System.Drawing.Point(529, 106);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(248, 35);
            this.btnMultiplicativo.TabIndex = 2;
            this.btnMultiplicativo.Text = "Método Congruencial Multiplicativo\r\n";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.Click += new System.EventHandler(this.btnMultiplicativo_Click);
            // 
            // btnSiguienteValorLineal
            // 
            this.btnSiguienteValorLineal.BackColor = System.Drawing.Color.LightGreen;
            this.btnSiguienteValorLineal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteValorLineal.Location = new System.Drawing.Point(261, 106);
            this.btnSiguienteValorLineal.Name = "btnSiguienteValorLineal";
            this.btnSiguienteValorLineal.Size = new System.Drawing.Size(253, 35);
            this.btnSiguienteValorLineal.TabIndex = 3;
            this.btnSiguienteValorLineal.Text = "Siguiente Valor";
            this.btnSiguienteValorLineal.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 617);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(1019, 37);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvResultadosLineal
            // 
            this.dgvResultadosLineal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosLineal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.aXi,
            this.siguienteNro,
            this.fórmula});
            this.dgvResultadosLineal.Location = new System.Drawing.Point(12, 147);
            this.dgvResultadosLineal.Name = "dgvResultadosLineal";
            this.dgvResultadosLineal.Size = new System.Drawing.Size(502, 426);
            this.dgvResultadosLineal.TabIndex = 5;
            // 
            // btnLimpiarLineal
            // 
            this.btnLimpiarLineal.Location = new System.Drawing.Point(12, 579);
            this.btnLimpiarLineal.Name = "btnLimpiarLineal";
            this.btnLimpiarLineal.Size = new System.Drawing.Size(502, 32);
            this.btnLimpiarLineal.TabIndex = 6;
            this.btnLimpiarLineal.Text = "Limpiar Campos y Tabla";
            this.btnLimpiarLineal.UseVisualStyleBackColor = true;
            this.btnLimpiarLineal.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputMMultiplicativo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.inputAMultiplicativo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.inputGMultiplicativo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.inputKMultiplicativo);
            this.groupBox1.Controls.Add(this.inputXoMultiplicativo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(529, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros Multiplicativo";
            // 
            // inputMMultiplicativo
            // 
            this.inputMMultiplicativo.Enabled = false;
            this.inputMMultiplicativo.Location = new System.Drawing.Point(390, 28);
            this.inputMMultiplicativo.Name = "inputMMultiplicativo";
            this.inputMMultiplicativo.Size = new System.Drawing.Size(100, 20);
            this.inputMMultiplicativo.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "m ";
            // 
            // inputAMultiplicativo
            // 
            this.inputAMultiplicativo.Enabled = false;
            this.inputAMultiplicativo.Location = new System.Drawing.Point(250, 53);
            this.inputAMultiplicativo.Name = "inputAMultiplicativo";
            this.inputAMultiplicativo.Size = new System.Drawing.Size(100, 20);
            this.inputAMultiplicativo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "a ";
            // 
            // inputGMultiplicativo
            // 
            this.inputGMultiplicativo.Location = new System.Drawing.Point(250, 26);
            this.inputGMultiplicativo.Name = "inputGMultiplicativo";
            this.inputGMultiplicativo.Size = new System.Drawing.Size(100, 20);
            this.inputGMultiplicativo.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(225, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "g";
            // 
            // inputKMultiplicativo
            // 
            this.inputKMultiplicativo.Location = new System.Drawing.Point(119, 53);
            this.inputKMultiplicativo.Name = "inputKMultiplicativo";
            this.inputKMultiplicativo.Size = new System.Drawing.Size(100, 20);
            this.inputKMultiplicativo.TabIndex = 20;
            // 
            // inputXoMultiplicativo
            // 
            this.inputXoMultiplicativo.Location = new System.Drawing.Point(119, 27);
            this.inputXoMultiplicativo.Name = "inputXoMultiplicativo";
            this.inputXoMultiplicativo.Size = new System.Drawing.Size(100, 20);
            this.inputXoMultiplicativo.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "k";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Xo (Semilla)";
            // 
            // dgvResultadosMultiplicativo
            // 
            this.dgvResultadosMultiplicativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosMultiplicativo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_multiplicativo,
            this.aXi_multiplicativo,
            this.Xsiguiente_multiplicativo,
            this.ultimo_multiplicativo});
            this.dgvResultadosMultiplicativo.Location = new System.Drawing.Point(529, 147);
            this.dgvResultadosMultiplicativo.Name = "dgvResultadosMultiplicativo";
            this.dgvResultadosMultiplicativo.Size = new System.Drawing.Size(502, 426);
            this.dgvResultadosMultiplicativo.TabIndex = 8;
            // 
            // i_multiplicativo
            // 
            this.i_multiplicativo.HeaderText = "i";
            this.i_multiplicativo.Name = "i_multiplicativo";
            // 
            // aXi_multiplicativo
            // 
            this.aXi_multiplicativo.HeaderText = "a.Xi";
            this.aXi_multiplicativo.Name = "aXi_multiplicativo";
            // 
            // Xsiguiente_multiplicativo
            // 
            this.Xsiguiente_multiplicativo.HeaderText = "X(i+1)";
            this.Xsiguiente_multiplicativo.Name = "Xsiguiente_multiplicativo";
            // 
            // ultimo_multiplicativo
            // 
            this.ultimo_multiplicativo.HeaderText = "(Xi+1)/(m-1)";
            this.ultimo_multiplicativo.Name = "ultimo_multiplicativo";
            // 
            // btnSiguienteValorMultiplicativo
            // 
            this.btnSiguienteValorMultiplicativo.BackColor = System.Drawing.Color.LightGreen;
            this.btnSiguienteValorMultiplicativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteValorMultiplicativo.Location = new System.Drawing.Point(779, 106);
            this.btnSiguienteValorMultiplicativo.Name = "btnSiguienteValorMultiplicativo";
            this.btnSiguienteValorMultiplicativo.Size = new System.Drawing.Size(252, 35);
            this.btnSiguienteValorMultiplicativo.TabIndex = 9;
            this.btnSiguienteValorMultiplicativo.Text = "Siguiente Valor";
            this.btnSiguienteValorMultiplicativo.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarMultiplicativo
            // 
            this.btnLimpiarMultiplicativo.Location = new System.Drawing.Point(529, 579);
            this.btnLimpiarMultiplicativo.Name = "btnLimpiarMultiplicativo";
            this.btnLimpiarMultiplicativo.Size = new System.Drawing.Size(502, 32);
            this.btnLimpiarMultiplicativo.TabIndex = 10;
            this.btnLimpiarMultiplicativo.Text = "Limpiar Campos y Tabla";
            this.btnLimpiarMultiplicativo.UseVisualStyleBackColor = true;
            this.btnLimpiarMultiplicativo.Click += new System.EventHandler(this.btnLimpiarMultiplicativo_Click);
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // aXi
            // 
            this.aXi.HeaderText = "a.Xi + c";
            this.aXi.Name = "aXi";
            // 
            // siguienteNro
            // 
            this.siguienteNro.HeaderText = "X(i+1)";
            this.siguienteNro.Name = "siguienteNro";
            // 
            // fórmula
            // 
            this.fórmula.HeaderText = "(Xi+1)/(m-1)";
            this.fórmula.Name = "fórmula";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1043, 663);
            this.Controls.Add(this.btnLimpiarMultiplicativo);
            this.Controls.Add(this.btnSiguienteValorMultiplicativo);
            this.Controls.Add(this.dgvResultadosMultiplicativo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiarLineal);
            this.Controls.Add(this.dgvResultadosLineal);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSiguienteValorLineal);
            this.Controls.Add(this.btnMultiplicativo);
            this.Controls.Add(this.btnLineal);
            this.Controls.Add(this.gbParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Numeros Aleatorios";
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosLineal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosMultiplicativo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnMultiplicativo;
        private System.Windows.Forms.Button btnSiguienteValorLineal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvResultadosLineal;
        private System.Windows.Forms.TextBox inputMLineal;
        private System.Windows.Forms.TextBox inputALineal;
        private System.Windows.Forms.TextBox inputCcLineal;
        private System.Windows.Forms.TextBox inputGLineal;
        private System.Windows.Forms.TextBox inputKLineal;
        private System.Windows.Forms.TextBox inputXoLineal;
        private System.Windows.Forms.Button btnLimpiarLineal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputMMultiplicativo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox inputAMultiplicativo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputGMultiplicativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputKMultiplicativo;
        private System.Windows.Forms.TextBox inputXoMultiplicativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvResultadosMultiplicativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_multiplicativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aXi_multiplicativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xsiguiente_multiplicativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimo_multiplicativo;
        private System.Windows.Forms.Button btnSiguienteValorMultiplicativo;
        private System.Windows.Forms.Button btnLimpiarMultiplicativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn aXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn siguienteNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fórmula;
    }
}

