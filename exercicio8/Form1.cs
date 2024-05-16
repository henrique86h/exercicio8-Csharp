using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                int idade = int.Parse(textBoxIdade.Text);

                if (idade < 18)
                {
                    lblResultado.Text = "Sem permissão";
                    lblResultado.ForeColor = Color.Red;
                }
                else
                {
                    lblResultado.Text = "Permissão concedida";
                    lblResultado.ForeColor = Color.Green;
                }
            }
            catch (FormatException)
            {
                lblResultado.Text = "Idade inválida";
            }
        }
    }
}
