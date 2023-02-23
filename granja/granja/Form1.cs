using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace granja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grado1.Visible = false;
            grado2.Visible = false;
            grado3.Visible = false;
            grado11.Visible = false;
            grado22.Visible = false;
            grado33.Visible = false;
        }
        //*******************************VARIABLES*********************************************

        int entra;
        double fx0, fx1, fx2, fx3, x,x0, x1, x2, x3,  resultado1, resultado2, resultado3;

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void limpia()
        {
            txtEcuacion.Clear();
            txtResultado.Clear();
            txtX.Clear();
            grado1.Rows.Clear();
            grado2.Rows.Clear();
            grado3.Rows.Clear();
            radio1.Checked = false;
            radio2.Checked = false;
            radio3.Checked = false;
            grado11.Visible = false;
            grado22.Visible = false;
            grado33.Visible = false;
        }

        string ecuacion;
        //objeto
        Calculo AnalizadorDeFunciones = new Calculo();

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            grado1.Visible = false;
            grado2.Visible = false;
            grado3.Visible = true;
            grado11.Visible = false;
            grado22.Visible = false;
            grado33.Visible = true;
            //******
            txtResultado.Clear();
            txtX.Clear();
            grado1.Rows.Clear();
            grado2.Rows.Clear();
            grado3.Rows.Clear();

        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            grado1.Visible = false;
            grado2.Visible = true;
            grado3.Visible = false;
            grado11.Visible = false;
            grado22.Visible = true;
            grado33.Visible = false;
            txtResultado.Clear();
            txtX.Clear();
            grado1.Rows.Clear();
            grado2.Rows.Clear();
            grado3.Rows.Clear();
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            grado1.Visible = true;
            grado2.Visible = false;
            grado3.Visible = false;
            grado11.Visible = true;
            grado22.Visible = false;
            grado33.Visible = false;
            txtResultado.Clear();
            txtX.Clear();
            grado1.Rows.Clear();
            grado2.Rows.Clear();
            grado3.Rows.Clear();
        }
 
        private void btnCalcula_Click(object sender, EventArgs e)
        {
           if (grado1.Visible==true)
            {
                //tomar los valores de la tabla 
                //                          Fila    Columna
                x0 = Convert.ToDouble(grado1.Rows[0].Cells[0].Value.ToString());
                x1 = Convert.ToDouble(grado1.Rows[0].Cells[1].Value.ToString());
                ecuacion = txtEcuacion.Text;
                realizaFun1();

            }
           else if (grado2.Visible == true)
            {
                //tomar los valores de la tabla 

                x0 = Convert.ToDouble(grado2.Rows[0].Cells[0].Value.ToString());
                x1 = Convert.ToDouble(grado2.Rows[0].Cells[1].Value.ToString());
                x2 = Convert.ToDouble(grado2.Rows[0].Cells[2].Value.ToString());
                ecuacion = txtEcuacion.Text;
                realizaFun2();
            }

            else if (grado3.Visible == true)
            {
                //tomar los valores de la tabla 

                x0 = Convert.ToDouble(grado3.Rows[0].Cells[0].Value.ToString());
                x1 = Convert.ToDouble(grado3.Rows[0].Cells[1].Value.ToString());
                x2 = Convert.ToDouble(grado3.Rows[0].Cells[2].Value.ToString());
                x3 = Convert.ToDouble(grado3.Rows[0].Cells[3].Value.ToString());
                ecuacion = txtEcuacion.Text;
                realizaFun3();
               
            }
        }

        private void realizaFun3()
        {
            if (AnalizadorDeFunciones.Sintaxis(ecuacion, 'x'))
            {
                convierteX();
                fx0 = AnalizadorDeFunciones.EvaluaFx(x0);
                fx1 = AnalizadorDeFunciones.EvaluaFx(x1);
                fx2 = AnalizadorDeFunciones.EvaluaFx(x2);
                fx3 = AnalizadorDeFunciones.EvaluaFx(x3);
                resultado1 = (((x - x1) * (x - x2) * (x - x3)) / ((x0 - x1) * (x0 - x2) * (x0 - x3))) * fx0;//+
                resultado1 = resultado1 + (((x - x0) * (x - x2) * (x - x3)) / ((x1 - x0) * (x1 - x2) * (x1 - x3))) * fx1;
                resultado1 = resultado1 + (((x - x0) * (x - x1) * (x - x3)) / ((x2 - x0) * (x2 - x1) * (x2 - x3))) * fx2;
                resultado1 = resultado1 + (((x - x0) * (x - x1) * (x - x2)) / ((x3 - x0) * (x3 - x1) * (x3 - x2))) * fx2;
                txtResultado.Text = Convert.ToString(resultado1);

            }
            else
            {
                MessageBox.Show("Error de Sintaxix");
            }
        }

        private void realizaFun2()
        {
            if (AnalizadorDeFunciones.Sintaxis(ecuacion, 'x'))
            {
                convierteX();
                fx0 = AnalizadorDeFunciones.EvaluaFx(x0);
                fx1 = AnalizadorDeFunciones.EvaluaFx(x1);
                fx2 = AnalizadorDeFunciones.EvaluaFx(x2);
                resultado1 = (((x - x1) * (x - x2)) / ((x0 - x1) * (x0 - x2))) * fx0;//+
                resultado1 = resultado1 + (((x - x0) * (x - x2)) / ((x1 - x0) * (x1 - x2))) * fx1;
                resultado1 = resultado1 + (((x - x0) * (x - x1)) / ((x2 - x0) * (x2 - x1))) * fx2;
                txtResultado.Text = Convert.ToString(resultado1);

            }
            else
            {
                MessageBox.Show("Error de Sintaxix");
            }
        }

        private void realizaFun1()
        {
            if (AnalizadorDeFunciones.Sintaxis(ecuacion, 'x'))
            {
                convierteX();
                fx0 = AnalizadorDeFunciones.EvaluaFx(x0);
                fx1 = AnalizadorDeFunciones.EvaluaFx(x1);
                resultado1 = (((x - x1) / (x0 - x1)) * fx0) + (((x - x0) / (x1 - x0)) * fx1);
                txtResultado.Text = Convert.ToString(resultado1);

            }
            else
            {
                MessageBox.Show("Error de Sintaxix");
            }
        }

        private void convierteX()
        {
            x = Convert.ToDouble(txtX.Text);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    private void salir()
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.txtEcuacion.Focus();
            }
        }
    private void btnCerrar_Click(object sender, EventArgs e)
        {
            salir();
        }
    }
}
