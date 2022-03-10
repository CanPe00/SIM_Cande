
namespace TP6_SIM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxNombres = new System.Windows.Forms.ListBox();
            this.listBoxPresentacion = new System.Windows.Forms.ListBox();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblTituloTp = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._Dx0 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._x0 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._h = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._c = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._b = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._a = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opcEuler = new System.Windows.Forms.RadioButton();
            this.opcRK = new System.Windows.Forms.RadioButton();
            this.chkDisminuir = new System.Windows.Forms.CheckBox();
            this.txtProbabilidadEnsambles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarEstadisticas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGrafica_dx2_dx = new System.Windows.Forms.Button();
            this.btnGraficar_dx_x = new System.Windows.Forms.Button();
            this.btnGraficar_dx2_x = new System.Windows.Forms.Button();
            this.btnGraficar_Tiempo = new System.Windows.Forms.Button();
            this.dgvRK = new System.Windows.Forms.DataGridView();
            this.dgvEuler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 650);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxNombres);
            this.tabPage1.Controls.Add(this.listBoxPresentacion);
            this.tabPage1.Controls.Add(this.lblIntegrantes);
            this.tabPage1.Controls.Add(this.lblTituloTp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Integrantes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxNombres
            // 
            this.listBoxNombres.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNombres.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNombres.FormattingEnabled = true;
            this.listBoxNombres.ItemHeight = 17;
            this.listBoxNombres.Items.AddRange(new object[] {
            "Bonzano Evangelina",
            "Massei Gino",
            "Petroni Olmos Antonella",
            "Pérez Candela",
            "Pérez Leonardo"});
            this.listBoxNombres.Location = new System.Drawing.Point(398, 178);
            this.listBoxNombres.Name = "listBoxNombres";
            this.listBoxNombres.Size = new System.Drawing.Size(242, 85);
            this.listBoxNombres.TabIndex = 16;
            // 
            // listBoxPresentacion
            // 
            this.listBoxPresentacion.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPresentacion.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPresentacion.FormattingEnabled = true;
            this.listBoxPresentacion.ItemHeight = 17;
            this.listBoxPresentacion.Items.AddRange(new object[] {
            "Cátedra: Simulación",
            "Ingeniería en Sistemas de Información",
            "Universidad Tecnológica Nacional",
            "Facultad Regional Córdoba"});
            this.listBoxPresentacion.Location = new System.Drawing.Point(87, 178);
            this.listBoxPresentacion.Name = "listBoxPresentacion";
            this.listBoxPresentacion.Size = new System.Drawing.Size(262, 68);
            this.listBoxPresentacion.TabIndex = 15;
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.BackColor = System.Drawing.Color.Transparent;
            this.lblIntegrantes.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(394, 137);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(241, 23);
            this.lblIntegrantes.TabIndex = 14;
            this.lblIntegrantes.Text = "Integrantes Grupo R - 2021";
            // 
            // lblTituloTp
            // 
            this.lblTituloTp.AutoSize = true;
            this.lblTituloTp.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTp.Location = new System.Drawing.Point(83, 137);
            this.lblTituloTp.Name = "lblTituloTp";
            this.lblTituloTp.Size = new System.Drawing.Size(195, 23);
            this.lblTituloTp.TabIndex = 12;
            this.lblTituloTp.Text = "Trabajo Práctico Nº6";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._Dx0);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this._x0);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this._h);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this._c);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this._b);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this._a);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.opcEuler);
            this.tabPage2.Controls.Add(this.opcRK);
            this.tabPage2.Controls.Add(this.chkDisminuir);
            this.tabPage2.Controls.Add(this.txtProbabilidadEnsambles);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnMostrarEstadisticas);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtHasta);
            this.tabPage2.Controls.Add(this.txtDesde);
            this.tabPage2.Controls.Add(this.lblHasta);
            this.tabPage2.Controls.Add(this.lblDesde);
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.btnSimular);
            this.tabPage2.Controls.Add(this.dgvResultados);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _Dx0
            // 
            this._Dx0.Location = new System.Drawing.Point(710, 34);
            this._Dx0.Name = "_Dx0";
            this._Dx0.Size = new System.Drawing.Size(32, 20);
            this._Dx0.TabIndex = 55;
            this._Dx0.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(683, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "x\'(0):";
            // 
            // _x0
            // 
            this._x0.Location = new System.Drawing.Point(645, 34);
            this._x0.Name = "_x0";
            this._x0.Size = new System.Drawing.Size(32, 20);
            this._x0.TabIndex = 53;
            this._x0.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "x(0):";
            // 
            // _h
            // 
            this._h.Location = new System.Drawing.Point(577, 34);
            this._h.Name = "_h";
            this._h.Size = new System.Drawing.Size(32, 20);
            this._h.TabIndex = 51;
            this._h.Text = "0,05";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "h:";
            // 
            // _c
            // 
            this._c.Location = new System.Drawing.Point(710, 8);
            this._c.Name = "_c";
            this._c.Size = new System.Drawing.Size(32, 20);
            this._c.TabIndex = 49;
            this._c.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(688, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "c:";
            // 
            // _b
            // 
            this._b.Location = new System.Drawing.Point(645, 8);
            this._b.Name = "_b";
            this._b.Size = new System.Drawing.Size(32, 20);
            this._b.TabIndex = 47;
            this._b.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "b:";
            // 
            // _a
            // 
            this._a.Enabled = false;
            this._a.Location = new System.Drawing.Point(577, 8);
            this._a.Name = "_a";
            this._a.Size = new System.Drawing.Size(32, 20);
            this._a.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "a:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Valores iniciales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Simular con:";
            // 
            // opcEuler
            // 
            this.opcEuler.AutoSize = true;
            this.opcEuler.Checked = true;
            this.opcEuler.Location = new System.Drawing.Point(374, 32);
            this.opcEuler.Name = "opcEuler";
            this.opcEuler.Size = new System.Drawing.Size(49, 17);
            this.opcEuler.TabIndex = 41;
            this.opcEuler.TabStop = true;
            this.opcEuler.Text = "Euler";
            this.opcEuler.UseVisualStyleBackColor = true;
            // 
            // opcRK
            // 
            this.opcRK.AutoSize = true;
            this.opcRK.Location = new System.Drawing.Point(374, 12);
            this.opcRK.Name = "opcRK";
            this.opcRK.Size = new System.Drawing.Size(85, 17);
            this.opcRK.TabIndex = 40;
            this.opcRK.Text = "Runge-Kutta";
            this.opcRK.UseVisualStyleBackColor = true;
            // 
            // chkDisminuir
            // 
            this.chkDisminuir.AutoSize = true;
            this.chkDisminuir.Location = new System.Drawing.Point(13, 581);
            this.chkDisminuir.Name = "chkDisminuir";
            this.chkDisminuir.Size = new System.Drawing.Size(121, 17);
            this.chkDisminuir.TabIndex = 39;
            this.chkDisminuir.Text = "Disminuir en un 20%";
            this.chkDisminuir.UseVisualStyleBackColor = true;
            this.chkDisminuir.CheckedChanged += new System.EventHandler(this.chkDisminuir_CheckedChanged);
            // 
            // txtProbabilidadEnsambles
            // 
            this.txtProbabilidadEnsambles.Location = new System.Drawing.Point(145, 36);
            this.txtProbabilidadEnsambles.Name = "txtProbabilidadEnsambles";
            this.txtProbabilidadEnsambles.Size = new System.Drawing.Size(31, 20);
            this.txtProbabilidadEnsambles.TabIndex = 38;
            this.txtProbabilidadEnsambles.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "o más ensambles en 1 hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Probabilidad de completar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cantidad de Eventos a Simular:";
            // 
            // btnMostrarEstadisticas
            // 
            this.btnMostrarEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarEstadisticas.Location = new System.Drawing.Point(950, 581);
            this.btnMostrarEstadisticas.Name = "btnMostrarEstadisticas";
            this.btnMostrarEstadisticas.Size = new System.Drawing.Size(141, 36);
            this.btnMostrarEstadisticas.TabIndex = 34;
            this.btnMostrarEstadisticas.Text = "Mostrar Estadisticas";
            this.btnMostrarEstadisticas.UseVisualStyleBackColor = true;
            this.btnMostrarEstadisticas.Click += new System.EventHandler(this.btnMostrarEstadisticas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(783, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Listar Desde... Hasta";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(936, 33);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(56, 20);
            this.txtHasta.TabIndex = 32;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(830, 32);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(56, 20);
            this.txtDesde.TabIndex = 30;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(892, 36);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 31;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(783, 37);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 29;
            this.lblDesde.Text = "Desde:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(816, 581);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 36);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(998, 32);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(93, 23);
            this.btnSimular.TabIndex = 4;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(10, 62);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(1082, 513);
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(171, 12);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(47, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGrafica_dx2_dx);
            this.tabPage3.Controls.Add(this.btnGraficar_dx_x);
            this.tabPage3.Controls.Add(this.btnGraficar_dx2_x);
            this.tabPage3.Controls.Add(this.btnGraficar_Tiempo);
            this.tabPage3.Controls.Add(this.dgvRK);
            this.tabPage3.Controls.Add(this.dgvEuler);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1100, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Euler - RK";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGrafica_dx2_dx
            // 
            this.btnGrafica_dx2_dx.Location = new System.Drawing.Point(947, 528);
            this.btnGrafica_dx2_dx.Name = "btnGrafica_dx2_dx";
            this.btnGrafica_dx2_dx.Size = new System.Drawing.Size(144, 37);
            this.btnGrafica_dx2_dx.TabIndex = 5;
            this.btnGrafica_dx2_dx.Text = "Graficar x\'\' en funcion de x\'";
            this.btnGrafica_dx2_dx.UseVisualStyleBackColor = true;
            this.btnGrafica_dx2_dx.Click += new System.EventHandler(this.btnGrafica_dx2_dx_Click);
            // 
            // btnGraficar_dx_x
            // 
            this.btnGraficar_dx_x.Location = new System.Drawing.Point(947, 571);
            this.btnGraficar_dx_x.Name = "btnGraficar_dx_x";
            this.btnGraficar_dx_x.Size = new System.Drawing.Size(144, 37);
            this.btnGraficar_dx_x.TabIndex = 4;
            this.btnGraficar_dx_x.Text = "Graficar x\' en funcion de x";
            this.btnGraficar_dx_x.UseVisualStyleBackColor = true;
            this.btnGraficar_dx_x.Click += new System.EventHandler(this.btnGraficar_dx_x_Click);
            // 
            // btnGraficar_dx2_x
            // 
            this.btnGraficar_dx2_x.Location = new System.Drawing.Point(797, 571);
            this.btnGraficar_dx2_x.Name = "btnGraficar_dx2_x";
            this.btnGraficar_dx2_x.Size = new System.Drawing.Size(144, 37);
            this.btnGraficar_dx2_x.TabIndex = 3;
            this.btnGraficar_dx2_x.Text = "Graficar x\'\' en funcion de x";
            this.btnGraficar_dx2_x.UseVisualStyleBackColor = true;
            this.btnGraficar_dx2_x.Click += new System.EventHandler(this.btnGraficar_dx2_x_Click);
            // 
            // btnGraficar_Tiempo
            // 
            this.btnGraficar_Tiempo.Location = new System.Drawing.Point(797, 528);
            this.btnGraficar_Tiempo.Name = "btnGraficar_Tiempo";
            this.btnGraficar_Tiempo.Size = new System.Drawing.Size(144, 37);
            this.btnGraficar_Tiempo.TabIndex = 2;
            this.btnGraficar_Tiempo.Text = "Graficar x, x\' y x\'\' en funcion del tiempo";
            this.btnGraficar_Tiempo.UseVisualStyleBackColor = true;
            this.btnGraficar_Tiempo.Click += new System.EventHandler(this.btnGraficar_Tiempo_Click);
            // 
            // dgvRK
            // 
            this.dgvRK.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRK.Location = new System.Drawing.Point(490, 19);
            this.dgvRK.Name = "dgvRK";
            this.dgvRK.Size = new System.Drawing.Size(601, 503);
            this.dgvRK.TabIndex = 1;
            // 
            // dgvEuler
            // 
            this.dgvEuler.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEuler.Location = new System.Drawing.Point(23, 19);
            this.dgvEuler.Name = "dgvEuler";
            this.dgvEuler.Size = new System.Drawing.Size(449, 503);
            this.dgvEuler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 662);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TP6 - Grupo R - Ensamblaje con Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEuler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.ListBox listBoxNombres;
        private System.Windows.Forms.ListBox listBoxPresentacion;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblTituloTp;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnMostrarEstadisticas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProbabilidadEnsambles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDisminuir;
        private System.Windows.Forms.TextBox _a;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton opcEuler;
        private System.Windows.Forms.RadioButton opcRK;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.TextBox _Dx0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _x0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _h;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _c;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _b;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvRK;
        private System.Windows.Forms.DataGridView dgvEuler;
        private System.Windows.Forms.Button btnGrafica_dx2_dx;
        private System.Windows.Forms.Button btnGraficar_dx_x;
        private System.Windows.Forms.Button btnGraficar_dx2_x;
        private System.Windows.Forms.Button btnGraficar_Tiempo;
    }
}

