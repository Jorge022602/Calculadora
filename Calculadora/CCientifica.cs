using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CCientifica : Form
    {
        public CCientifica()
        {
            InitializeComponent();
        }
        operacion obj = new operacion();
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.FormClosing += (s, args) => this.Show();
            home.Show();
            this.Close();
        }
        private void btn_rai_Click(object sender, EventArgs e)
        {
            if (!obj.EsNumerico(n1.Text))
            {
                total.Text = "Ingrese un numero correcto";
            }
            else
            {
                int rai = obj.Raiz(Convert.ToInt32(n1.Text));
                total.Text = Convert.ToString(rai);
            }
        }

        private void btn_pot_Click(object sender, EventArgs e)
        {
            if (!obj.EsNumerico(n1.Text) && obj.EsNumerico(n2.Text))
            {
                total.Text = "Ingrese un numero correcto";
            }
            else
            {
                int pot = obj.Potencia(Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text));
                total.Text = Convert.ToString(pot);
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (!obj.EsNumerico(n1.Text) && obj.EsNumerico(n2.Text))
            {
                total.Text = "Ingrese un numero correcto";
            }
            else
            {
                int log = obj.Logaritmo(Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text));
                total.Text = Convert.ToString(log);
            }
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            int valorpi = obj.ValorPI();
            total.Text = Convert.ToString(valorpi);

        }
        private void btn_sum_Click(object sender, EventArgs e)
        {
            if (!obj.EsNumerico(n1.Text) && obj.EsNumerico(n2.Text))
            {
                total.Text = "Ingrese un numero correcto";
            }
            else
            {
                int sum = obj.Suma(Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text));
                total.Text = Convert.ToString(sum);
            }
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            if (!obj.EsNumerico(n1.Text) && obj.EsNumerico(n2.Text))
            {
                total.Text = "Ingrese un numero correcto";
            }
            else
            {
                int res = obj.Resta(Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text));
                total.Text = Convert.ToString(res);
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (!obj.EsNumerico(n1.Text) && obj.EsNumerico(n2.Text))
            {
                total.Text = "Ingrese un numero correcto";
            }
            else
            {
                int mul = obj.Mul(Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text));
                total.Text = Convert.ToString(mul);
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (!obj.EsNumerico(n1.Text) && obj.EsNumerico(n2.Text))
            {
                total.Text = "Ingrese un numero correcto";
            }
            else
            {
                int div = obj.Div(Convert.ToInt32(n1.Text), Convert.ToInt32(n2.Text));
                total.Text = Convert.ToString(div);
            }
        }

        private void CCientifica_Load(object sender, EventArgs e)
        {

        }
    }
}
