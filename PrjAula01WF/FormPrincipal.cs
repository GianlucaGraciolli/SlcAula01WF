using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAula01WF
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //instanciei a classe / criei objeto
            Form1 janelalogin = new Form1();

            //usando metodo show
            janelalogin.Show();
            
            //definindo a janela "pai" para o form janelaLogin ou seja: obrigando a tela de login criada, ser aberta dentro do formprincipal "login"
            janelalogin.MdiParent = this;
        }
    }
}
