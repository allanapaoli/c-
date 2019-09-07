using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCalculoArea : Form
    {
        public FrmCalculoArea()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            float x, y, z;
            if (rdbQuadrado.Checked)
            {
                if (txtX.Text.Trim() != "")
                {
                    x = float.Parse(txtX.Text);
                    txtAreaVol.Text = area(x).ToString();
                }
                else
                {
                    MessageBox.Show("Preenchimento obrigatório de X!");
                    txtX.Focus();
                    return;
                }
            }
            if (rdbRetangulo.Checked)
            {
                if ((txtX.Text.Trim() != "") && (txtY.Text.Trim() != ""))
                {
                    x = float.Parse(txtX.Text);
                    y = float.Parse(txtY.Text);
                    txtAreaVol.Text = area(x, y).ToString();
                }
                else
                {
                    if ((txtX.Text.Trim() == ""))
                    {
                        MessageBox.Show("Preenchimento obrigatório de X!");
                        txtX.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Preenchimento obrigatório de Y!");
                        txtY.Focus();
                        return;
                    }
                }
            }

        }

        float area (float x) 
        {
            return (x * x);
        }

        float area(float x, float y)
        {
            return (x * y);
        }

        float area(float x, float y, float z)
        {
            return (x * y * z);
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = testes.soUmaVirgula(txtX.Text);
            }
            e.KeyChar = testes.consistNum(e.KeyChar);

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
            txtAreaVol.Text = "";
            txtX.Focus();
            rdbQuadrado.Select();

        }

        private void rdbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Visible = true;
            txtY.Visible = false;
            txtZ.Visible = false;
        }

        private void rdbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Visible = true;
            txtY.Visible = true;
            txtZ.Visible = false;
        }

        private void rdbParalelepipedo_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Visible = true;
            txtY.Visible = true;
            txtZ.Visible = true;
        }
    }

    public class testes
    {
        public static char consistNum(char c) //só aceita números, vírula e backspace
        {
            if (((c < '0') || (c > '9')) && c != ',' && c != (char)8)
            {
                MessageBox.Show("Tecla Inválida...");
                c = (char)0;
            }
            return (c);
        }

        public static char soUmaVirgula(string text)
        {
            int i;
            i = text.IndexOf(',');
            if (i >= 0)
            {
                MessageBox.Show("Vírgula já existente...");
                return ((char)0);
            }
            else
            {
                return (',');
            }

        }
    }
}


