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
            //código quando o botão logar for clicado

            string mensagem;

            if (textBoxLogin.Text == String.Empty || textBoxSenha.Text == String.Empty)
            {
                mensagem = "necessário preencher algo";
            }
            else
            {
                if (textBoxLogin.TextLength != 11 || textBoxSenha.TextLength != 6)
                {
                    mensagem = "preencha os dados corretamente";
                }
                else
                {
                    if (textBoxLogin.Text == "47393581821" && textBoxSenha.Text == "000000")
                    {
                        mensagem = "Usuário autorizado!";
                    }
                    else
                    {
                        mensagem = "Usuário negado.";
                    }
                }
            }
            //labelmensagem.Text = mensagem  //mensagem em um label
            MessageBox.Show(mensagem, "AVISO!");
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

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVerSenha_Click(object sender, EventArgs e)
        {
            textBoxSenha.UseSystemPasswordChar = false;
        }
    }
}