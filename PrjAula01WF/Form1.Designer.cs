namespace PrjAula01WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            BotãoEntrar = new Button();
            LabelLogin = new Label();
            LabelSenha = new Label();
            labelMensagem = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.Goldenrod;
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(294, 146);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(265, 29);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = Color.Goldenrod;
            textBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenha.Location = new Point(294, 226);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(265, 29);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.UseSystemPasswordChar = true;
            textBoxSenha.TextChanged += textBoxSenha_TextChanged;
            // 
            // BotãoEntrar
            // 
            BotãoEntrar.BackColor = Color.Beige;
            BotãoEntrar.Font = new Font("SuperFrench", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BotãoEntrar.Location = new Point(382, 275);
            BotãoEntrar.Name = "BotãoEntrar";
            BotãoEntrar.Size = new Size(92, 35);
            BotãoEntrar.TabIndex = 2;
            BotãoEntrar.Text = "Entrar";
            BotãoEntrar.UseVisualStyleBackColor = false;
            BotãoEntrar.Click += button1_Click;
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Monospac821 BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLogin.Location = new Point(393, 119);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(70, 24);
            LabelLogin.TabIndex = 3;
            LabelLogin.Text = "Login";
            LabelLogin.Click += label1_Click;
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSize = true;
            LabelSenha.Font = new Font("Monospac821 BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSenha.Location = new Point(393, 199);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(70, 24);
            LabelSenha.TabIndex = 4;
            LabelSenha.Text = "Senha";
            LabelSenha.Click += LabelSenha_Click;
            // 
            // labelMensagem
            // 
            labelMensagem.AutoSize = true;
            labelMensagem.Font = new Font("Monospac821 BT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelMensagem.Location = new Point(304, 364);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(106, 24);
            labelMensagem.TabIndex = 5;
            labelMensagem.Text = "Mensagem";
            labelMensagem.Click += labelMensagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(773, 523);
            Controls.Add(labelMensagem);
            Controls.Add(LabelSenha);
            Controls.Add(LabelLogin);
            Controls.Add(BotãoEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Name = "Form1";
            Text = "Banjucas - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxSenha;
        private Button BotãoEntrar;
        private Label LabelLogin;
        private Label LabelSenha;
        private Label labelMensagem;
    }
}