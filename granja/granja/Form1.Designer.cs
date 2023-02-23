namespace granja
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
            this.txtEcuacion = new System.Windows.Forms.TextBox();
            this.Ecuación = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grado1 = new System.Windows.Forms.DataGridView();
            this.equis0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.grado2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equis2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grado3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equis3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnLimpia = new System.Windows.Forms.Button();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.grado33 = new System.Windows.Forms.PictureBox();
            this.grado22 = new System.Windows.Forms.PictureBox();
            this.grado11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grado1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado11)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEcuacion
            // 
            this.txtEcuacion.Location = new System.Drawing.Point(133, 51);
            this.txtEcuacion.Name = "txtEcuacion";
            this.txtEcuacion.Size = new System.Drawing.Size(100, 20);
            this.txtEcuacion.TabIndex = 0;
            // 
            // Ecuación
            // 
            this.Ecuación.AutoSize = true;
            this.Ecuación.Location = new System.Drawing.Point(46, 51);
            this.Ecuación.Name = "Ecuación";
            this.Ecuación.Size = new System.Drawing.Size(52, 13);
            this.Ecuación.TabIndex = 1;
            this.Ecuación.Text = "Ecuación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(484, 51);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // grado1
            // 
            this.grado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grado1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equis0,
            this.equis1});
            this.grado1.Location = new System.Drawing.Point(309, 113);
            this.grado1.Name = "grado1";
            this.grado1.Size = new System.Drawing.Size(280, 62);
            this.grado1.TabIndex = 11;
            // 
            // equis0
            // 
            this.equis0.HeaderText = "X0";
            this.equis0.Name = "equis0";
            // 
            // equis1
            // 
            this.equis1.HeaderText = "X1";
            this.equis1.Name = "equis1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 30);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "X=";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(133, 191);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 13;
            // 
            // grado2
            // 
            this.grado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grado2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.equis2});
            this.grado2.Location = new System.Drawing.Point(309, 113);
            this.grado2.Name = "grado2";
            this.grado2.Size = new System.Drawing.Size(387, 63);
            this.grado2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X0";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "X1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // equis2
            // 
            this.equis2.HeaderText = "X2";
            this.equis2.Name = "equis2";
            // 
            // grado3
            // 
            this.grado3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grado3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.equis3});
            this.grado3.Location = new System.Drawing.Point(309, 113);
            this.grado3.Name = "grado3";
            this.grado3.Size = new System.Drawing.Size(492, 65);
            this.grado3.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "X0";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "X1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "X2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // equis3
            // 
            this.equis3.HeaderText = "X3";
            this.equis3.Name = "equis3";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(667, 47);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 17;
            this.btnCalcula.Text = "calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // btnLimpia
            // 
            this.btnLimpia.Location = new System.Drawing.Point(785, 48);
            this.btnLimpia.Name = "btnLimpia";
            this.btnLimpia.Size = new System.Drawing.Size(75, 23);
            this.btnLimpia.TabIndex = 18;
            this.btnLimpia.Text = "Limpia";
            this.btnLimpia.UseVisualStyleBackColor = true;
            this.btnLimpia.Click += new System.EventHandler(this.btnLimpia_Click);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(133, 122);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(63, 17);
            this.radio2.TabIndex = 19;
            this.radio2.TabStop = true;
            this.radio2.Text = "Grado 2";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(133, 145);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(63, 17);
            this.radio3.TabIndex = 20;
            this.radio3.TabStop = true;
            this.radio3.Text = "Grado 3";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(133, 92);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(63, 17);
            this.radio1.TabIndex = 21;
            this.radio1.TabStop = true;
            this.radio1.Text = "Grado 1";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // btnMini
            // 
            this.btnMini.Image = global::granja.Properties.Resources.cirAma;
            this.btnMini.Location = new System.Drawing.Point(587, 4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(26, 23);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 14;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::granja.Properties.Resources.ApagarRojo;
            this.btnCerrar.Location = new System.Drawing.Point(619, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 26);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grado33
            // 
            this.grado33.Image = global::granja.Properties.Resources.grado3;
            this.grado33.Location = new System.Drawing.Point(49, 217);
            this.grado33.Name = "grado33";
            this.grado33.Size = new System.Drawing.Size(811, 273);
            this.grado33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grado33.TabIndex = 8;
            this.grado33.TabStop = false;
            // 
            // grado22
            // 
            this.grado22.Image = global::granja.Properties.Resources.grado2;
            this.grado22.Location = new System.Drawing.Point(156, 228);
            this.grado22.Name = "grado22";
            this.grado22.Size = new System.Drawing.Size(634, 223);
            this.grado22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grado22.TabIndex = 7;
            this.grado22.TabStop = false;
            // 
            // grado11
            // 
            this.grado11.Image = global::granja.Properties.Resources.grado1;
            this.grado11.Location = new System.Drawing.Point(239, 228);
            this.grado11.Name = "grado11";
            this.grado11.Size = new System.Drawing.Size(478, 137);
            this.grado11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grado11.TabIndex = 4;
            this.grado11.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 502);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.btnLimpia);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.grado3);
            this.Controls.Add(this.grado2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.grado33);
            this.Controls.Add(this.grado22);
            this.Controls.Add(this.grado11);
            this.Controls.Add(this.Ecuación);
            this.Controls.Add(this.txtEcuacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grado1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grado11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcuacion;
        private System.Windows.Forms.Label Ecuación;
        private System.Windows.Forms.PictureBox grado11;
        private System.Windows.Forms.PictureBox grado22;
        private System.Windows.Forms.PictureBox grado33;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.DataGridView grado1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.DataGridViewTextBoxColumn equis0;
        private System.Windows.Forms.DataGridViewTextBoxColumn equis1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.DataGridView grado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn equis2;
        private System.Windows.Forms.DataGridView grado3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn equis3;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnLimpia;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio1;
    }
}

