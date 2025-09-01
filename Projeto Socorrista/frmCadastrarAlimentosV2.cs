<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
=======
﻿using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
>>>>>>> master

namespace Projeto_Socorrista
{
    public partial class frmCadastrarAlimentosV2 : Form
    {
        public frmCadastrarAlimentosV2()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void gpbCamposDoProduto_Enter(object sender, EventArgs e)
=======
        private void frmCadastrarAlimentosV2_Load(object sender, EventArgs e)
        {
            //lblTitulo.BringToFront();

            MtxtObservacoes.WordWrap = true;
            limparCamposDeCadastro();
            configDataGridView();
            carregaDoacoes();
            cbbTipoDoacao.SelectedIndex = 0;
            cbbUnidadeMedida.SelectedIndex = 0;
        }

        private void configDataGridView()
        {
            // Estilo geral
            dgvRegistro.BorderStyle = BorderStyle.None;
            dgvRegistro.BackgroundColor = Color.White;
            dgvRegistro.EnableHeadersVisualStyles = false;
            dgvRegistro.GridColor = Color.LightGray;
            dgvRegistro.RowHeadersVisible = false;

            dgvRegistro.RowTemplate.Height = 50;
            dgvRegistro.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Cores de linhas
            dgvRegistro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgvRegistro.DefaultCellStyle.BackColor = Color.White;
            dgvRegistro.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12);
            dgvRegistro.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistro.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#e6e6e6");
            dgvRegistro.DefaultCellStyle.SelectionForeColor = Color.White;

            // Estilo do cabeçalho
            dgvRegistro.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            dgvRegistro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvRegistro.ColumnHeadersHeight = 50;
            dgvRegistro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRegistro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRegistro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Bordas das células
            dgvRegistro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Colunas do datagrid view
            dgvRegistro.Columns[0].HeaderText = "Data de Cadastro";
            dgvRegistro.Columns[1].HeaderText = "Produto";
            dgvRegistro.Columns[2].HeaderText = "Qtd";
            dgvRegistro.Columns[3].HeaderText = "Validade";
            dgvRegistro.Columns[4].HeaderText = "Cadastrado por";
        }

        private void carregaDoacoes()
        {
            MySqlCommand comm = new MySqlCommand();
            string sql = "SELECT DATE_FORMAT(prod.dataArrecadacao, '%d/%m/%Y'), DATE_FORMAT(prod.dataDeValidade, '%d/%m/%Y'), prod.nome, prod.quantidade, prod.unidadeMedida, prod.peso, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu ORDER BY dataArrecadacao DESC;";

            MySqlDataAdapter DA = new MySqlDataAdapter(sql, ConectaBanco.ObterConexao());
            DataTable dt = new DataTable();

            if (DA.Fill(dt) < 1)
            {
                MessageBox.Show("sem informações no banco");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string dataArrecadacao = Convert.ToString(dr.ItemArray[0]);
                    string dataValidade = Convert.ToString(dr.ItemArray[1]);

                    string nomeProduto = dr.ItemArray[2] != DBNull.Value ? dr.ItemArray[2].ToString() : "";
                    string quantidadeProduto = dr.ItemArray[3] != DBNull.Value ? dr.ItemArray[3].ToString() : "";
                    string unidadeMedida = dr.ItemArray[4] != DBNull.Value ? dr.ItemArray[4].ToString() : "";
                    string peso = dr.ItemArray[5] != DBNull.Value ? dr.ItemArray[5].ToString() : "";
                    string cadastradoPor = dr.ItemArray[6] != DBNull.Value ? dr.ItemArray[6].ToString() : "";

                    dgvRegistro.Rows.Add(dataArrecadacao, nomeProduto + " " + peso + " " + unidadeMedida, quantidadeProduto, dataValidade, cadastradoPor);
                }
                DA.Dispose();
            }
            ConectaBanco.FecharConexao();
        }

        private int enviarDoacoes(string nomeProduto, int quantidade, DateTime dataArrecadacao, DateTime dataDeValidade, string unidadeMedida, int peso, int codUsu, string observacao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbprodutos(nome, quantidade, unidadeMedida, peso, dataArrecadacao, dataDeValidade, observacoes, codUsu) VALUES(@nome, @quantidade, @unidadeMedida, @peso, @dataArrecadacao, @dataDeValidade, @observacao, @codUsu);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nomeProduto;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@unidadeMedida", MySqlDbType.VarChar, 5).Value = unidadeMedida;
            comm.Parameters.Add("@peso", MySqlDbType.Int32).Value = peso;
            comm.Parameters.Add("@dataArrecadacao", MySqlDbType.Date).Value = dataArrecadacao;
            comm.Parameters.Add("@dataDeValidade", MySqlDbType.Date).Value = dataDeValidade;
            comm.Parameters.Add("@observacao", MySqlDbType.VarChar, 300).Value = observacao;
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = codUsu;

            comm.Connection = ConectaBanco.ObterConexao();

            int resp = comm.ExecuteNonQuery();

            ConectaBanco.FecharConexao();

            limparCamposDeCadastro();

            return resp;
        }

        private bool VerificaFormatacaoDosCampos()
        {
            DateTime.TryParse(dtpDataEntrada.Text, out DateTime dataRecebimento);
            if (dataRecebimento > DateTime.Today)
            {
                MessageBox.Show("Você inseriu uma data futura", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataEntrada.Focus();
                return false;
            }

            DateTime.TryParse(dtpDataValidade.Text, out DateTime dataValidade);

            if (dataValidade < DateTime.Now.AddMonths(-3))
            {
                MessageBox.Show("O periodo para cadastro de doação excedeu!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDataEntrada.Focus();
                return false;
            }

            if (Regex.IsMatch(txtQuantidade.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Quantidade inválida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return false;
            }
            return true;
        }

        private string SimplificarUnidade(string unidadeSelecionada)
        {
            switch (unidadeSelecionada)
            {
                case "Quilogramas (Kg)":
                    return "Kg";
                case "Gramas (g)":
                    return "g";
                case "Litros (L)":
                    return "L";
                case "Mililitros (ml)":
                    return "ml";
                case "Unidades (und)":
                    return "und";
                case "Caixas (cx)":
                    return "cx";
                default:
                    return "";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeDoItem.Text.Equals("") || txtQuantidade.Text.Equals(""))
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerificaFormatacaoDosCampos())
            {
                return;
            }
            string nomeItem = txtNomeDoItem.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            DateTime dataRecebimento = Convert.ToDateTime(dtpDataEntrada.Text);
            DateTime dataValidade = Convert.ToDateTime(dtpDataValidade.Text);
            string tipoDoacao = cbbTipoDoacao.Text; ;
            string tipoUnidade = SimplificarUnidade(cbbUnidadeMedida.Text);
            int peso = Convert.ToInt32(txtPeso.Text);
            string observacao = MtxtObservacoes.Text;
            int codUsu = 1;

            if (enviarDoacoes(nomeItem, quantidade, dataRecebimento, dataValidade, tipoUnidade, peso, codUsu, observacao) == 1)
            {
                MessageBox.Show("Doação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRegistro.Rows.Clear();
                carregaDoacoes();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar doação!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCamposDeCadastro();
            }

            carregaDoacoes();
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            dgvRegistro.Rows.Clear();
            carregaDoacoes();
        }

        public void limparCamposDeCadastro()
        {
            txtNomeDoItem.Clear();
            txtQuantidade.Clear();
            dtpDataValidade.Value = DateTime.Now;
            DateTime dataRecebimento = Convert.ToDateTime(dtpDataEntrada.Text);
            dtpDataValidade.Value = DateTime.Now;
            cbbTipoDoacao.SelectedIndex = 0;
            cbbUnidadeMedida.SelectedIndex = 0;
            txtPeso.Clear();
            MtxtObservacoes.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
>>>>>>> master
        {

        }
    }
}
