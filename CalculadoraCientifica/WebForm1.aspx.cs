using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraCientifica
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static Double v1;
        private static string op;
        /* variavel no asp se declara variavel como static*/
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";

            }
            lblDisplay.Text = lblDisplay.Text + "1";
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "2";
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "3";
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "4";
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "5";
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "6";
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "7";
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "8";
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "9";
        }

        protected void Btn0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = lblDisplay.Text + "0";
        }

        protected void BtnSoma_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "+";
        }

        protected void BtnIgual_Click(object sender, EventArgs e)
        {
            if (op.Equals("+"))
            {
                Double v2 = Double.Parse(lblDisplay.Text);
                Double total = v1 + v2;
                lblDisplay.Text = total.ToString();
            }
            if (op.Equals("-"))
            {
                Double v2 = Double.Parse(lblDisplay.Text);
                Double total = v1 - v2;
                lblDisplay.Text = total.ToString();
            }
            if (op.Equals("*"))
            {
                Double v2 = Double.Parse(lblDisplay.Text);
                Double total = v1 * v2;
                lblDisplay.Text = total.ToString();
            }
            if (op.Equals("^"))
            {
                Double v2 = Double.Parse(lblDisplay.Text);
                Double total = Math.Pow(v1, v2);
                lblDisplay.Text = total.ToString();
            }
            
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "-";
        }

        protected void BtnMult_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "*";
        }

        protected void BtnSin_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(lblDisplay.Text);
            Double result = Math.Sin(v1 * Math.PI / 180);
            lblDisplay.Text = result.ToString();
        }

        protected void BtnCos_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(lblDisplay.Text);
            Double result = Math.Cos(v1 * Math.PI / 180);
            lblDisplay.Text = result.ToString();

        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            v1 = 0;
            lblDisplay.Text = "";
        }

        protected void BtnPow_Click(object sender, EventArgs e)
        {
            v1 = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "";
            op = "^";
        }

        protected void BtnPI_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Equals("0"))
            {
                lblDisplay.Text = "";
            }
            lblDisplay.Text = Convert.ToString(Math.PI);
        }

        protected void BtnRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = Convert.ToDouble(lblDisplay.Text);
                Double result = Math.Sqrt(v1);
                lblDisplay.Text = result.ToString();
            }
            catch(Exception erro)
            {
                lblDisplay.Text = "Foi identificado um erro:\n" + erro;
            }
        }
    }
}