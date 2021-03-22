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
            this.inputModulo = new System.Windows.Forms.TextBox();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputCc = new System.Windows.Forms.TextBox();
            this.inputG = new System.Windows.Forms.TextBox();
            this.inputK = new System.Windows.Forms.TextBox();
            this.inputSemilla = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnMultiplicativo = new System.Windows.Forms.Button();
            this.btnSiguienteValor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvTablaResultados = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aXi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siguienteNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fórmula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.inputModulo);
            this.gbParametros.Controls.Add(this.inputA);
            this.gbParametros.Controls.Add(this.inputCc);
            this.gbParametros.Controls.Add(this.inputG);
            this.gbParametros.Controls.Add(this.inputK);
            this.gbParametros.Controls.Add(this.inputSemilla);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(342, 196);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // inputModulo
            // 
            this.inputModulo.Enabled = false;
            this.inputModulo.Location = new System.Drawing.Point(236, 158);
            this.inputModulo.Name = "inputModulo";
            this.inputModulo.Size = new System.Drawing.Size(100, 20);
            this.inputModulo.TabIndex = 17;
            // 
            // inputA
            // 
            this.inputA.Enabled = false;
            this.inputA.Location = new System.Drawing.Point(236, 132);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 20);
            this.inputA.TabIndex = 16;
            // 
            // inputCc
            // 
            this.inputCc.Location = new System.Drawing.Point(236, 106);
            this.inputCc.Name = "inputCc";
            this.inputCc.Size = new System.Drawing.Size(100, 20);
            this.inputCc.TabIndex = 15;
            // 
            // inputG
            // 
            this.inputG.Location = new System.Drawing.Point(236, 80);
            this.inputG.Name = "inputG";
            this.inputG.Size = new System.Drawing.Size(100, 20);
            this.inputG.TabIndex = 14;
            // 
            // inputK
            // 
            this.inputK.Location = new System.Drawing.Point(236, 54);
            this.inputK.Name = "inputK";
            this.inputK.Size = new System.Drawing.Size(100, 20);
            this.inputK.TabIndex = 13;
            // 
            // inputSemilla
            // 
            this.inputSemilla.Location = new System.Drawing.Point(236, 28);
            this.inputSemilla.Name = "inputSemilla";
            this.inputSemilla.Size = new System.Drawing.Size(100, 20);
            this.inputSemilla.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "m (Módulo)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "a (Cte multiplicativa)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "cc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
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
            this.btnLineal.Location = new System.Drawing.Point(12, 229);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(342, 35);
            this.btnLineal.TabIndex = 1;
            this.btnLineal.Text = "Método Congruencial Lineal\r\n";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicativo.Location = new System.Drawing.Point(12, 270);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(342, 35);
            this.btnMultiplicativo.TabIndex = 2;
            this.btnMultiplicativo.Text = "Método Congruencial Multiplicativo\r\n";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteValor
            // 
            this.btnSiguienteValor.BackColor = System.Drawing.Color.LightGreen;
            this.btnSiguienteValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteValor.Location = new System.Drawing.Point(12, 311);
            this.btnSiguienteValor.Name = "btnSiguienteValor";
            this.btnSiguienteValor.Size = new System.Drawing.Size(342, 35);
            this.btnSiguienteValor.TabIndex = 3;
            this.btnSiguienteValor.Text = "Siguiente Valor";
            this.btnSiguienteValor.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(342, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvTablaResultados
            // 
            this.dgvTablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.aXi,
            this.siguienteNro,
            this.fórmula});
            this.dgvTablaResultados.Location = new System.Drawing.Point(360, 12);
            this.dgvTablaResultados.Name = "dgvTablaResultados";
            this.dgvTablaResultados.Size = new System.Drawing.Size(519, 426);
            this.dgvTablaResultados.TabIndex = 5;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // aXi
            // 
            this.aXi.HeaderText = "aXi";
            this.aXi.Name = "aXi";
            // 
            // siguienteNro
            // 
            this.siguienteNro.HeaderText = "x(i+1)";
            this.siguienteNro.Name = "siguienteNro";
            // 
            // fórmula
            // 
            this.fórmula.HeaderText = "(Xi+1)/(m-1)";
            this.fórmula.Name = "fórmula";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 386);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(342, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvTablaResultados);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSiguienteValor);
            this.Controls.Add(this.btnMultiplicativo);
            this.Controls.Add(this.btnLineal);
            this.Controls.Add(this.gbParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Numeros Aleatorios";
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultados)).EndInit();
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
        private System.Windows.Forms.Button btnSiguienteValor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvTablaResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn aXi;
        private System.Windows.Forms.DataGridViewTextBoxColumn siguienteNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fórmula;
        private System.Windows.Forms.TextBox inputModulo;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputCc;
        private System.Windows.Forms.TextBox inputG;
        private System.Windows.Forms.TextBox inputK;
        private System.Windows.Forms.TextBox inputSemilla;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

