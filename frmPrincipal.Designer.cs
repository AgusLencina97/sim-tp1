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
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numSemilla = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.numA);
            this.gbParametros.Controls.Add(this.numC);
            this.gbParametros.Controls.Add(this.numM);
            this.gbParametros.Controls.Add(this.numericUpDown6);
            this.gbParametros.Controls.Add(this.numSemilla);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.numericUpDown4);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(342, 196);
            this.gbParametros.TabIndex = 6;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(227, 132);
            this.numA.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numA.Size = new System.Drawing.Size(109, 20);
            this.numA.TabIndex = 4;
            this.numA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(227, 106);
            this.numC.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numC.Name = "numC";
            this.numC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numC.Size = new System.Drawing.Size(109, 20);
            this.numC.TabIndex = 3;
            this.numC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numM
            // 
            this.numM.Location = new System.Drawing.Point(227, 161);
            this.numM.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numM.Name = "numM";
            this.numM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numM.Size = new System.Drawing.Size(109, 20);
            this.numM.TabIndex = 5;
            this.numM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(227, 80);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown6.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown6.TabIndex = 2;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSemilla
            // 
            this.numSemilla.Location = new System.Drawing.Point(227, 31);
            this.numSemilla.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numSemilla.Name = "numSemilla";
            this.numSemilla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numSemilla.Size = new System.Drawing.Size(109, 20);
            this.numSemilla.TabIndex = 0;
            this.numSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(227, 57);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown4.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown4.TabIndex = 1;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "a (Cte multiplicativa)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "C (cte aditiva)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "k";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xo (Semilla)";
            // 
            // btnLineal
            // 
            this.btnLineal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineal.Location = new System.Drawing.Point(12, 229);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(342, 35);
            this.btnLineal.TabIndex = 0;
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
            this.btnMultiplicativo.TabIndex = 1;
            this.btnMultiplicativo.Text = "Método Congruencial Multiplicativo\r\n";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.Click += new System.EventHandler(this.btnMultiplicativo_Click);
            // 
            // btnSiguienteValor
            // 
            this.btnSiguienteValor.BackColor = System.Drawing.Color.LightGreen;
            this.btnSiguienteValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteValor.Location = new System.Drawing.Point(12, 311);
            this.btnSiguienteValor.Name = "btnSiguienteValor";
            this.btnSiguienteValor.Size = new System.Drawing.Size(342, 35);
            this.btnSiguienteValor.TabIndex = 2;
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
            this.dgvTablaResultados.AllowUserToDeleteRows = false;
            this.dgvTablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaResultados.Location = new System.Drawing.Point(363, 12);
            this.dgvTablaResultados.Name = "dgvTablaResultados";
            this.dgvTablaResultados.ReadOnly = true;
            this.dgvTablaResultados.Size = new System.Drawing.Size(353, 426);
            this.dgvTablaResultados.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 386);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(342, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar Campos y Tabla";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(745, 452);
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
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSemilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numSemilla;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}

