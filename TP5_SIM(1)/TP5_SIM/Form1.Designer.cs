
namespace TP5_SIM
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
            this.chkDisminuir = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.listBoxNombres.Size = new System.Drawing.Size(242, 68);
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
            this.lblTituloTp.Size = new System.Drawing.Size(194, 23);
            this.lblTituloTp.TabIndex = 12;
            this.lblTituloTp.Text = "Trabajo Práctico Nº5";
            // 
            // tabPage2
            // 
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
            // txtProbabilidadEnsambles
            // 
            this.txtProbabilidadEnsambles.Location = new System.Drawing.Point(144, 36);
            this.txtProbabilidadEnsambles.Name = "txtProbabilidadEnsambles";
            this.txtProbabilidadEnsambles.Size = new System.Drawing.Size(44, 20);
            this.txtProbabilidadEnsambles.TabIndex = 38;
            this.txtProbabilidadEnsambles.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 39);
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
            this.label7.Location = new System.Drawing.Point(575, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Listar Desde... Hasta";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(748, 31);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(56, 20);
            this.txtHasta.TabIndex = 32;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(628, 31);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(56, 20);
            this.txtDesde.TabIndex = 30;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(699, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 31;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(575, 33);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 29;
            this.lblDesde.Text = "Desde:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(963, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(829, 29);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(128, 23);
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
            this.dgvResultados.Location = new System.Drawing.Point(10, 67);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(1082, 508);
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(171, 12);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 662);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TP5 - Grupo R - Ensamblaje con Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvResultados;
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
    }
}

