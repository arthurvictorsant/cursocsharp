using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula60
{
    public partial class F_Principal : Form // F_Principal está herdando a classe Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_texto_Click(object sender, EventArgs e)
        {

            lb_text.Text = inp_texto.Text;
            
            
            /*
              
              OU 
            string txt;

            txt = inp_texto.Text; // A variavel recebe o texto do input
            lb_text.Text = txt; // O texto do LABEL receb o o conteudo de txt
                                // que é o texto de input. */

            
        }
    }
}
