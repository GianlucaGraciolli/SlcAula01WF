namespace PrjAula01WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //c�digo quando o bot�o logar for clicado
            if (textBoxLogin.Text == "47393581821")
            {
                if (textBoxSenha.Text == "000000")
                {
                    labelMensagem.Text = "Usu�rio autenticado!";
                }
                else
                {
                    labelMensagem.Text = "Usu�rio rejeitado.";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMensagem_Click(object sender, EventArgs e)
        {

        }

        private void LabelSenha_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}