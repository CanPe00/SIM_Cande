namespace TP7_78293
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txt_tempInicial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_FinDespuesDe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_EncenderCada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Media = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this._h = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opcEuler = new System.Windows.Forms.RadioButton();
            this.opcRK = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRK = new System.Windows.Forms.DataGridView();
            this.dgvEuler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1283, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtHasta);
            this.tabPage1.Controls.Add(this.txtDesde);
            this.tabPage1.Controls.Add(this.lblHasta);
            this.tabPage1.Controls.Add(this.lblDesde);
            this.tabPage1.Controls.Add(this.txt_tempInicial);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txt_FinDespuesDe);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txt_EncenderCada);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txt_b);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_a);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_Media);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgvResultados);
            this.tabPage1.Controls.Add(this.txtStock);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnSimular);
            this.tabPage1.Controls.Add(this._h);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.opcEuler);
            this.tabPage1.Controls.Add(this.opcRK);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1275, 681);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulación";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(491, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 86;
            this.label14.Text = "Listar Desde... Hasta";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(644, 37);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(56, 20);
            this.txtHasta.TabIndex = 85;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(538, 36);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(56, 20);
            this.txtDesde.TabIndex = 83;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(600, 40);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 84;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(491, 41);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 82;
            this.lblDesde.Text = "Desde:";
            // 
            // txt_tempInicial
            // 
            this.txt_tempInicial.Location = new System.Drawing.Point(528, 112);
            this.txt_tempInicial.Name = "txt_tempInicial";
            this.txt_tempInicial.Size = new System.Drawing.Size(32, 20);
            this.txt_tempInicial.TabIndex = 81;
            this.txt_tempInicial.Text = "5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(423, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Temperatura inicial:";
            // 
            // txt_FinDespuesDe
            // 
            this.txt_FinDespuesDe.Location = new System.Drawing.Point(363, 112);
            this.txt_FinDespuesDe.Name = "txt_FinDespuesDe";
            this.txt_FinDespuesDe.Size = new System.Drawing.Size(32, 20);
            this.txt_FinDespuesDe.TabIndex = 79;
            this.txt_FinDespuesDe.Text = "15";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Finaliza cocción después de:";
            // 
            // txt_EncenderCada
            // 
            this.txt_EncenderCada.Location = new System.Drawing.Point(164, 112);
            this.txt_EncenderCada.Name = "txt_EncenderCada";
            this.txt_EncenderCada.Size = new System.Drawing.Size(32, 20);
            this.txt_EncenderCada.TabIndex = 77;
            this.txt_EncenderCada.Text = "45";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Horno se enciende cada: ";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(235, 88);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(32, 20);
            this.txt_b.TabIndex = 74;
            this.txt_b.Text = "1,5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "b:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(164, 88);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(32, 20);
            this.txt_a.TabIndex = 72;
            this.txt_a.Text = "0,5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "a:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Tiempo de atención:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Llegada clientes:";
            // 
            // txt_Media
            // 
            this.txt_Media.Location = new System.Drawing.Point(164, 62);
            this.txt_Media.Name = "txt_Media";
            this.txt_Media.Size = new System.Drawing.Size(32, 20);
            this.txt_Media.TabIndex = 68;
            this.txt_Media.Text = "3";
            this.txt_Media.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Media:";
            // 
            // dgvResultados
            // 
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(6, 145);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(1263, 530);
            this.dgvResultados.TabIndex = 66;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(205, 37);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(32, 20);
            this.txtStock.TabIndex = 65;
            this.txtStock.Text = "45";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Stock:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(761, 65);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 23);
            this.btnLimpiar.TabIndex = 55;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(761, 34);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(102, 23);
            this.btnSimular.TabIndex = 54;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click_1);
            // 
            // _h
            // 
            this._h.Location = new System.Drawing.Point(116, 37);
            this._h.Name = "_h";
            this._h.Size = new System.Drawing.Size(32, 20);
            this._h.TabIndex = 53;
            this._h.Text = "0,05";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(94, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "h:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Valores iniciales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Simular con:";
            // 
            // opcEuler
            // 
            this.opcEuler.AutoSize = true;
            this.opcEuler.Checked = true;
            this.opcEuler.Location = new System.Drawing.Point(367, 34);
            this.opcEuler.Name = "opcEuler";
            this.opcEuler.Size = new System.Drawing.Size(49, 17);
            this.opcEuler.TabIndex = 46;
            this.opcEuler.TabStop = true;
            this.opcEuler.Text = "Euler";
            this.opcEuler.UseVisualStyleBackColor = true;
            // 
            // opcRK
            // 
            this.opcRK.AutoSize = true;
            this.opcRK.Location = new System.Drawing.Point(367, 10);
            this.opcRK.Name = "opcRK";
            this.opcRK.Size = new System.Drawing.Size(85, 17);
            this.opcRK.TabIndex = 45;
            this.opcRK.Text = "Runge-Kutta";
            this.opcRK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cantidad de Eventos a Simular:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(164, 10);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(47, 20);
            this.txtCantidad.TabIndex = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRK);
            this.tabPage2.Controls.Add(this.dgvEuler);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1231, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Euler / R-K";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRK
            // 
            this.dgvRK.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRK.Location = new System.Drawing.Point(485, 6);
            this.dgvRK.Name = "dgvRK";
            this.dgvRK.Size = new System.Drawing.Size(740, 621);
            this.dgvRK.TabIndex = 3;
            // 
            // dgvEuler
            // 
            this.dgvEuler.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEuler.Location = new System.Drawing.Point(18, 6);
            this.dgvEuler.Name = "dgvEuler";
            this.dgvEuler.Size = new System.Drawing.Size(461, 621);
            this.dgvEuler.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 731);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Trabajo Prático N° 7 - Pérez, Candela - 78293";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRK;
        private System.Windows.Forms.DataGridView dgvEuler;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton opcEuler;
        private System.Windows.Forms.RadioButton opcRK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox _h;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Media;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_FinDespuesDe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_EncenderCada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tempInicial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
    }
}

