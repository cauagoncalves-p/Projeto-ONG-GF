﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MosaicoSolutions.ViaCep;
using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using ZstdSharp.Unsafe;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace Projeto_Socorrista
{
    public partial class frmCadastroVoluntario : Form
    {
        public frmCadastroVoluntario()
        {
            InitializeComponent();
        }

        // configuração de senha e de confirma senha

        // mudando o MaxLengh dos campos
        private void mudandoMaxLength()
        {
            MtxtConfirmeSenha.MaxLength = 15;
            MtxtSenha.MaxLength = 15;
            MtxtCPF.MaxLength = 14;
            MtxtDataNascimento.MaxLength = 10;
            MtxtTelefone.MaxLength = 15;
            MtxtSobrenome.MaxLength = 30;
            MtxtNome.MaxLength = 20;
            MtxtEmail.MaxLength = 100;
        }

        // crianndo metodo de avaliar se a senha é forte ou não
        private void AvaliarForcaSenha(string senha)
        {
            int forca = 0;

            // Tamanho
            if (senha.Length == 15)
                forca++;

            // Contém letra
            if (Regex.IsMatch(senha, @"[a-zA-Z]"))
                forca++;

            // Contém número
            if (Regex.IsMatch(senha, @"\d"))
                forca++;

            // Contém caractere especial
            if (Regex.IsMatch(senha, @"[\W_]"))
                forca++;

            // Atualiza o label conforme a força
            switch (forca)
            {
                case 0:
                case 1:
                    lblError.Text = "Senha fraca";
                    lblError.ForeColor = Color.Red;
                    break;
                case 2:
                case 3:
                    lblError.Text = "Senha média";
                    lblError.ForeColor = Color.DarkOrange;
                    break;
                case 4:
                    lblError.Text = "Senha forte";
                    lblError.ForeColor = Color.Blue;
                    break;
            }
        }

        // verifica se a senha digitada tem caracter especial , número, letra e tamanho mínimo de 10 caracteres
        private void verificaSenhaForte(string senha)
        {
            Regex regexSenhaForte = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[\W_]).{10,}$"); ;

            if (!regexSenhaForte.IsMatch(MtxtSenha.Text))
            {
                MessageBox.Show("A senha deve conter 15 caracteres e incluir letras, números e caracteres especiais.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblError.Text = "Ex: SenhaForte@2025";
                lblError.ForeColor = Color.Red;
                MtxtSenha.Focus();
                return;
            }

            if (MtxtSenha.Text == "SenhaForte@2025")
            {
                MessageBox.Show("Não use a senha de exemplo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void frmLoginVoluntario_Load(object sender, EventArgs e)
        {
            mudandoMaxLength();
            MtxtSenha.TextChanged += (s, args) => AvaliarForcaSenha(MtxtSenha.Text);
        }

        // Trocando imagem ao clicar
        private void picMonstrarSenha_Click(object sender, EventArgs e)
        {
            bool imagemAlternada = false;
            MtxtSenha.UseSystemPasswordChar = !MtxtSenha.UseSystemPasswordChar;

            if (imagemAlternada)
            {
                picMonstrarSenha.Image = Properties.Resources.SenhaEscondida;
            }
            else
            {
                picMonstrarSenha.Image = Properties.Resources.SenhaVisivel;
            }

            imagemAlternada = !imagemAlternada;
        }

        private void picMostrarSenha1_Click(object sender, EventArgs e)
        {
            bool imagemAlternada1 = false;
            MtxtConfirmeSenha.UseSystemPasswordChar = !MtxtConfirmeSenha.UseSystemPasswordChar;

            if (imagemAlternada1)
            {
                picMostrarSenha1.Image = Properties.Resources.SenhaEscondida;
            }
            else
            {
                picMostrarSenha1.Image = Properties.Resources.SenhaVisivel;
            }

            imagemAlternada1 = !imagemAlternada1;
        }

        private void MtxtCPF_TextChanged(object sender, EventArgs e)
        {
            bool editandoInterno = false;

            if (editandoInterno) return; // impede loop infinito

            editandoInterno = true;

            string campoCPF = MtxtCPF.Text.Replace(".", "").Replace("-", "");

            string campoFormatado = "";

            if (campoCPF.Length <= 3)
                campoFormatado = campoCPF;
            else if (campoCPF.Length <= 6)
                campoFormatado = campoCPF.Substring(0, 3) + "." + campoCPF.Substring(3);
            else if (campoCPF.Length <= 9)
                campoFormatado = campoCPF.Substring(0, 3) + "." + campoCPF.Substring(3, 3) + "." + campoCPF.Substring(6);
            else
                campoFormatado = campoCPF.Substring(0, 3) + "." + campoCPF.Substring(3, 3) + "." + campoCPF.Substring(6, 3) + "-" + campoCPF.Substring(9);

            MtxtCPF.Text = campoFormatado;

            // tenta manter o cursor no final

            MtxtCPF.SelectionStart = MtxtCPF.Text.Length;
            editandoInterno = false;
        }

        private void MtxtTelefone_TextChanged(object sender, EventArgs e)
        {
            bool editandoInternoTelefone = false;

            if (editandoInternoTelefone) return; // impede loop infinito

            editandoInternoTelefone = true;

            string CampoTelefone = MtxtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            string campoFormatadoTelefone = "";

            if (CampoTelefone.Length <= 2)
            {
                campoFormatadoTelefone = "(" + CampoTelefone;
            }
            else if (CampoTelefone.Length <= 6)
            {
                campoFormatadoTelefone = "(" + CampoTelefone.Substring(0, 2) + ") " + CampoTelefone.Substring(2);
            }
            else if (CampoTelefone.Length <= 10)
            {
                campoFormatadoTelefone = "(" + CampoTelefone.Substring(0, 2) + ") " + CampoTelefone.Substring(2, 4) + "-" + CampoTelefone.Substring(6);
            }
            else
            {
                campoFormatadoTelefone = "(" + CampoTelefone.Substring(0, 2) + ") " + CampoTelefone.Substring(2, 5) + "-" + CampoTelefone.Substring(7, 4);
            }

            MtxtTelefone.Text = campoFormatadoTelefone;

            // tenta manter o cursor no final

            MtxtTelefone.SelectionStart = MtxtTelefone.Text.Length;
            editandoInternoTelefone = false;
        }

        private void MtxtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            bool editandoInternoDataNascimento = false;

            if (editandoInternoDataNascimento) return;

            editandoInternoDataNascimento = true;

            string campoNascimento = MtxtDataNascimento.Text.Replace("/", "");

            string campoFormatadoNascimento = "";

            if (campoNascimento.Length <= 2)
            {
                campoFormatadoNascimento += campoNascimento;
                //14
            }
            else if (campoNascimento.Length <= 4)
            {
                //14082006
                campoFormatadoNascimento += campoNascimento.Substring(0, 2) + "/" + campoNascimento.Substring(2);
            }
            else
            {
                //14/08/2006
                campoFormatadoNascimento += campoNascimento.Substring(0, 2) + "/" + campoNascimento.Substring(2, 2) + "/" + campoNascimento.Substring(4);
            }

            MtxtDataNascimento.Text = campoFormatadoNascimento;

            // tenta manter o cursor no final

            MtxtDataNascimento.SelectionStart = MtxtDataNascimento.Text.Length;
            editandoInternoDataNascimento = false;
        }

 
        // criando metodo que criptografa a senha do voluntário
        // cria um numero aleatorio para conctenar com a senha 
        public string GerarSaltSeguro(int tamanho = 16)
        {
            byte[] saltBytes = new byte[tamanho];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public string GerarHashComSalt(string senha, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string senhaComSalt = salt + senha;
                byte[] bytes = Encoding.UTF8.GetBytes(senhaComSalt);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        // Criando metodo que envia os dados do voluntário para o banco de dados
        private int enviarVoluntario(
        string nome, string sobrenome, string email, string cpf, string telefone, string dataNascimento,
        string senha,
        string salt) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntario(nomeVoluntario, sobrenomeVoluntario, telCel, cpf, email, dataNascimento, senha, salt) " +
                "values (@nomeVoluntario, @sobrenomeVoluntario, @telCel, @cpf, @email, @dataNascimento, @senha, @salt);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeVoluntario", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@sobrenomeVoluntario", MySqlDbType.VarChar, 100).Value = sobrenome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("cpf", MySqlDbType.VarChar, 14).Value = cpf;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 11).Value = telefone;
            comm.Parameters.Add("@dataNascimento", MySqlDbType.Date).Value = dataNascimento;
            comm.Parameters.Add("senha", MySqlDbType.VarChar, 256).Value = senha; 
            comm.Parameters.Add("@salt", MySqlDbType.VarChar, 64).Value = salt; 

            comm.Connection = ConectaBanco.ObterConexao();
            int resp = comm.ExecuteNonQuery();
            ConectaBanco.FecharConexao();

            return resp;
        }

        // criando metodo que verifica cpf existente
        private bool verficaCPF(string cpf) {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where cpf = @cpf;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("cpf", MySqlDbType.VarChar, 14).Value = cpf;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();
            try {
                string existeCPF = DR.GetString(1);
                if (existeCPF.Equals(""))
                {
                    return false;
                }
            }
            catch (Exception) {
                return false;
            }
            
            ConectaBanco.FecharConexao();

            return true;
        }

        //// criando campo que verifica telefone existente 
        private bool verificaTelCel(string telefone) {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where telCel = @telCel;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("telCel", MySqlDbType.VarChar, 11).Value = telefone;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();
            try
            {
                string existeTelefone = DR.GetString(1);
                if (existeTelefone.Equals(""))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            ConectaBanco.FecharConexao();
            return true;
        }

        // criando metodo que verifica email existente

        private bool verificaEmail(string email)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntario where email = @email;";

            comm.Parameters.Clear();
            comm.Parameters.Add("email", MySqlDbType.VarChar, 100).Value = email;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();
            try
            {
                string existeEmail = DR.GetString(1);
                if (existeEmail.Equals(""))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            ConectaBanco.FecharConexao();
            return true;
        }
        // Verificando se os campos estão vazios
        private bool verificaCamposVazios()
        {
            if (MtxtNome.Text.Equals("") || MtxtSobrenome.Text.Equals("") || MtxtEmail.Text.Equals("")
                || MtxtTelefone.Text.Equals("") || MtxtCPF.Text.Equals("") || MtxtSenha.Text.Equals("") || MtxtDataNascimento.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private bool verificaLengthDosCampos() {

            string cpf = MtxtCPF.Text.Replace(".", "").Replace("-", "");
            if (cpf.Length < 11)
            {
                MessageBox.Show("O CPF informado está inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtCPF.Focus();
                return false;
            }

            string telefone = MtxtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            if (telefone.Length < 11)
            {
                MessageBox.Show("O telefone informado está inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtTelefone.Focus();
                return false;
            }

            string dataNascimento = MtxtDataNascimento.Text.Replace("/", "");
            if (dataNascimento.Length < 8)
            {
                MessageBox.Show("Data de nascimento inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataNascimento.Focus();
                return false;
            }

            if (MtxtSenha.Text.Length < 15 || MtxtConfirmeSenha.Text.Length < 15)
            {
                MessageBox.Show("Sua senha deve conter 15 caracteres", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool verificaFormatacaoDosCampos() {
            if (!Regex.IsMatch(MtxtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtEmail.Focus();
                return false;
            }

            if (!Regex.IsMatch(MtxtCPF.Text, @"^[^a-zA-Z\s]+$"))
            {
                MessageBox.Show("CPF inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtCPF.Focus();
                return false;
            }

            if (!Regex.IsMatch(MtxtTelefone.Text, @"^\(\d{2}\) \d{4,5}-\d{4}$"))
            {
                MessageBox.Show("Telefone inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtTelefone.Focus();
                return false;
            }

            if (!DateTime.TryParse(MtxtDataNascimento.Text, out DateTime dataNascimento))
            {
                MessageBox.Show("Data de nascimento inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataNascimento.Focus();
                return false;
            }

            if (dataNascimento > DateTime.Now)
            {
                MessageBox.Show("Data de nascimento não pode ser no futuro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataNascimento.Focus();
                return false;
            }

            if (dataNascimento > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Você deve ter pelo menos 18 anos para se cadastrar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataNascimento.Focus();
                return false;
            }

            if (dataNascimento < DateTime.Now.AddYears(-90))
            {
                MessageBox.Show("Você esta com idade avançada para ser um colaborador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtDataNascimento.Focus();
                return false;
            }

            if (!MtxtSenha.Text.Equals(MtxtConfirmeSenha.Text))
            {
                MessageBox.Show("As senhas não são iguais", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtSenha.Focus();
                return false;
            }

            return true;
        }

        private bool verificaDadosExistentes() {

            // verifica se o email ja existe no banco
            if (verificaEmail(MtxtEmail.Text))
            {
                MessageBox.Show("O email informado já está em uso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtEmail.Focus();
                return false;
            }

            // verifico se o cpf ja existe no banco
            string cpf = MtxtCPF.Text.Replace(".", "").Replace("-", "");
            if (verficaCPF(cpf))
            {
                MessageBox.Show("CPF informado já está em uso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtCPF.Focus();
                return false;
            }


            //verifica se o telefone ja exite no banco 
            string telefone = MtxtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            if (verificaTelCel(telefone))
            {
                MessageBox.Show("O telefone informado já está em uso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MtxtTelefone.Focus();
                return false;
            }

            return true;
        }

        private bool verificaCampos() {
            if (!verificaCamposVazios())
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!verificaFormatacaoDosCampos())
            {
                return false;
            }

            if (!verificaLengthDosCampos())
            {
                return false;
            }

            if (!verificaDadosExistentes()) {
                return false;
            }

            return true;
        }
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if (!verificaCampos())
            {
                return;
            }

            //Trazendo metodo que verifica a senha
            verificaSenhaForte(MtxtSenha.Text);
            string cpf = MtxtCPF.Text.Replace(".", "").Replace("-", "");
            string telefone = MtxtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            string dataNascimento = MtxtDataNascimento.Text.Replace("/", "");
            DateTime data = DateTime.ParseExact(dataNascimento, "ddMMyyyy", null);
            string dataFormatada = data.ToString("yyyy-MM-dd");
            string salt = GerarSaltSeguro();
            string senhaCriptografada = GerarHashComSalt(MtxtSenha.Text, salt);
       

            //Enviando os dados do voluntário para o banco de dados
           
            string codigoGerado = gerarCodigoAleatorio();
            bool enviarEmail = false;


            if (enviarVoluntario(MtxtNome.Text, MtxtSobrenome.Text, MtxtEmail.Text, cpf, telefone, dataFormatada,
                senhaCriptografada, salt) == 1)
            {
                MessageBox.Show("Conta criada com sucesso!", "Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                emailVoluntario = BuscarVoluntarioPorEmail(MtxtEmail.Text).email;
                enviarEmail = enviarCodigo(emailVoluntario, codigoGerado);

                if (enviarEmail)
                {
                    this.Hide();
                    frmEnviaCodigoCadastro enviarCodigo = new frmEnviaCodigoCadastro(codigoGerado,emailVoluntario, "CadastroVoluntario");
                    enviarCodigo.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao enviar o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o voluntário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string nomeVoluntario = "";
        public string emailVoluntario = "";
        private (string nome, string email) BuscarVoluntarioPorEmail(string email)
        {

            string nome = "";
            string emailVoluntario = "";

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nomeVoluntario, email from tbVoluntario where email = @email";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;

            comm.Connection = ConectaBanco.ObterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                nome = DR.GetString(0);
                emailVoluntario = DR.GetString(1);
            }

            ConectaBanco.FecharConexao();

            return (nome, emailVoluntario);
        }


        // envia codigo para o email informado 


        private string gerarCodigoAleatorio()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private string GerarCorpoEmail(string codigo)
        {
            return $@"
          <!DOCTYPE html>
                <html lang=""pt-BR"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>Seu Código Chegou! ✨</title>
                </head>
                <body style=""font-family: Arial, sans-serif; background-color: #f5f5f5; margin: 0; padding: 0; color: #333;"">
                    <!-- Container Principal -->
                    <div style=""max-width: 600px; margin: 20px auto; background: white; border-radius: 10px; overflow: hidden; box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);"">
                        <!-- Cabeçalho -->
                        <div style=""background: #009E70; color: white; padding: 30px; text-align: center;"">
                            <!-- Imagem (substitua pelo seu link) -->
                            <img src=""https://raw.githubusercontent.com/cauagoncalves-p/imagem/main/logo1.png"" alt=""Logo da Empresa"" style="" width: 250px;"">
                            <h1 style=""margin: 0; font-size: 24px;"">Seu Código Chegou! ✨</h1>
                        </div>

                        <!-- Conteúdo -->
                        <div style=""padding: 30px; text-align: center;"">
                            <p style=""font-size: 16px; line-height: 1.6; margin-bottom: 25px;"">
                                Olá <strong>{nomeVoluntario}</strong>,<br>
                                Obrigado por se cadastrar! Use o código abaixo para confirmar seu e-mail:
                            </p>
            
                            <!-- Caixa do Código -->
                            <div style=""background: #f8f9fa; border: 1px dashed #009E70; border-radius: 8px; padding: 15px; margin: 20px auto; display: inline-block;"">
                                <div style=""font-size: 28px; font-weight: bold; letter-spacing: 5px; color: #009E70;"">{codigo}</div>
                            </div>
          
                            <p style=""margin-top: 25px; font-size: 14px; color: #777;"">
                                Se você não solicitou este código, ignore esta mensagem.
                            </p>
                        </div>

                        <!-- Rodapé -->
                        <div style=""background: #f8f9fa; padding: 20px; text-align: center; font-size: 12px; color: #777;"">
                            <p style=""margin: 0;"">© 2025 Grupo Socrrista. Todos os direitos reservados.</p>
                            <p style=""margin: 10px 0 0;"">
                                <a href=""#"" style=""color: #009E70; text-decoration: none;"">Política de Privacidade</a> | 
                                <a href=""#"" style=""color: #009E70; text-decoration: none;"">Ajuda</a>
                            </p>
                        </div>
                    </div>
                </body>
                </html>
            ";
        }

        private bool enviarCodigo(string destino, string codigo)
        {

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("cauagoncalves2190@gmail.com");
                mail.To.Add(destino);
                mail.Subject = "Código de confirmação";
                mail.Body = GerarCorpoEmail(codigo);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("cauagoncalves2190@gmail.com", "nduu tkmc ayoe joes");
                smtp.EnableSsl = true;
                mail.IsBodyHtml = true;
                smtp.Send(mail);
                return true;
            }
            catch (SmtpFailedRecipientsException ex)
            {
                Console.WriteLine("Erro em destinatários: " + ex.Message);
                return false;
            }
            catch (SmtpFailedRecipientException ex)
            {
                Console.WriteLine("Erro em um destinatário: " + ex.Message);
                return false;
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("Erro SMTP: " + ex.Message);
                return false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Endereço de e-mail mal formatado: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro geral: " + ex.Message);
                return false;
            }
        }
    }
}

