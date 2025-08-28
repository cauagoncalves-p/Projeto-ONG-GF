using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;

namespace Projeto_Socorrista
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }


        private void configDataGridView()
        {
            // Ajustar para ocupar toda a largura
            dgvProdutosRecentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Alternar cores das linhas
            dgvProdutosRecentes.RowsDefaultCellStyle.BackColor = Color.LightGray;
       

            // Aumentar fonte
            dgvProdutosRecentes.RowsDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvProdutosRecentes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Ajustar altura das linhas
            dgvProdutosRecentes.RowTemplate.Height = 40;

            // Habilitar quebra de texto
            dgvProdutosRecentes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Adicionar botões na coluna Ações
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnBaixa = new DataGridViewButtonColumn();
            btnBaixa.HeaderText = "Baixa";
            btnBaixa.Text = "Baixa";
            btnBaixa.UseColumnTextForButtonValue = true;
            dgvProdutosRecentes.Columns.Add(btnEditar);
            dgvProdutosRecentes.Columns.Add(btnBaixa);

            // Ajustar a coluna Quantidade para edição
            dgvProdutosRecentes.Columns[3].ReadOnly = false;

            // Ajustar seleção de célula
            dgvProdutosRecentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutosRecentes.MultiSelect = false;

        }


        private void carregaDados(string busca = "", DateTime? validade = null, string unidade = "", string status = "")
        {
            dgvProdutosRecentes.Rows.Clear();

            MySqlCommand comm = new MySqlCommand();
            comm.Connection = ConectaBanco.ObterConexao();
            comm.CommandType = CommandType.Text;

            comm.CommandText = @"SELECT * FROM tbProdutos
                     WHERE (@busca = '' OR codProd = @busca OR nome LIKE @buscaPattern)
                       AND (@validade IS NULL OR DATE(dataDEValidade) = @validade)
                       AND (@unidade = '' OR unidade = @unidade)
                       AND (@status = '' OR status_validade = @status)
                     ORDER BY codProd;";

            // Parameters 
            comm.Parameters.Clear();
            comm.Parameters.Add("@busca", MySqlDbType.VarChar, 50).Value = busca;
            comm.Parameters.Add("@buscaPattern", MySqlDbType.VarChar, 100).Value = "%" + busca + "%";
            comm.Parameters.Add("@validade", MySqlDbType.Date).Value = validade.HasValue ? validade.Value.Date : (object)DBNull.Value;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 50).Value = unidade == "Selecione..." ? "" : unidade;
            comm.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status == "Selecione..." ? "" : status;

            MySqlDataReader DR = comm.ExecuteReader();
            while (DR.Read())
            {
                string dataArrecadacao = DR["dataArrecadacao"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataArrecadacao"]).ToString("dd/MM/yyyy");
                string dataValidade = DR["dataDEValidade"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataDEValidade"]).ToString("dd/MM/yyyy");

                dgvProdutosRecentes.Rows.Add(
                    DR["codProd"].ToString(),
                    DR["nome"].ToString(),
                    DR["quantidade"].ToString(),
                    DR["unidade"].ToString(),
                    dataArrecadacao,
                    dataValidade,
                    DR["status_validade"].ToString()
                );
            }

            DR.Close();
            ConectaBanco.FecharConexao();
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaDados(txtNomeOrCod.Text);
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            btnSaidaEstoque.BringToFront();
            btnEntradaEstoque.BringToFront();
            btnNovoProduto.BringToFront();
            btnRelatorio.BringToFront();
            dgvProdutosRecentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            configDataGridView();
            carregaDados();
            cbxStatus.SelectedIndex = 0;
            cbxCategoria.SelectedIndex = 0;
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            string unidade = cbxCategoria.Text;
            string unidadeEscolhida = "";

            switch (unidade) {
                case "Quilogramas (kg)":
                    unidadeEscolhida = "kg";
                    break;
                case "Gramas (g)":
                    unidadeEscolhida = "g";
                    break;
                case "Litros (l)":   
                    unidadeEscolhida = "litros";
                    break;

                case "Mililitros (ml)":
                    unidadeEscolhida = "ml";
                    break;
                case "Unidades":
                    unidadeEscolhida = "un";
                    break;
                case "Caixas":
                    unidadeEscolhida = "Caixas";
                    break;
                default:
                    unidadeEscolhida = "";  
                    break;
            }

            //  Data de validade
            DateTime? validadeFiltro = null;
            if (dtpDataValidade.Checked) // só filtra se estiver marcado
            {
                validadeFiltro = dtpDataValidade.Value.Date; // pega só a data sem hora
            }

            //  Chama a função apenas com unidade e validade
            carregaDados("", validadeFiltro, unidadeEscolhida);
        }

        private void txtNomeOrCod_TextChanged(object sender, EventArgs e)
        {
            carregaDados(txtNomeOrCod.Text);
        }
    }
}
