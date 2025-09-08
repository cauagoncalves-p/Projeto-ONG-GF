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
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Alternar cores das linhas
            dgvEstoque.RowsDefaultCellStyle.BackColor = Color.LightGray;
       

            // Aumentar fonte
            dgvEstoque.RowsDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgvEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Ajustar altura das linhas
            dgvEstoque.RowTemplate.Height = 40;

            // Habilitar quebra de texto
            dgvEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Adicionar botões na coluna Ações
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvEstoque.Columns.Add(btnEditar);

            // Ajustar a coluna Quantidade para edição
            dgvEstoque.Columns[3].ReadOnly = false;

            // Ajustar seleção de célula
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.MultiSelect = false;
        }


        private void carregaDados(string busca = "", DateTime? validade = null, string unidade = "", string status = "")
        {
            dgvEstoque.Rows.Clear();

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"SELECT * FROM tbProdutos
                        WHERE (@busca = '' OR codProd = @busca OR nome LIKE @buscaPattern)
                        AND (@unidade = '' OR unidade = @unidade)
                        AND (@status = '' OR status_validade = @status)
                        AND (@validade IS NULL OR DATE(dataDEValidade) = @validade)
                        ORDER BY codProd;";

            comm.CommandType = CommandType.Text;

            // Parameters 
            comm.Parameters.Clear();
            comm.Parameters.Add("@busca", MySqlDbType.VarChar, 50).Value = busca;
            comm.Parameters.Add("@buscaPattern", MySqlDbType.VarChar, 100).Value = "%" + busca + "%";
            comm.Parameters.Add("@validade", MySqlDbType.Date).Value = validade.HasValue ? validade.Value.Date : (object)DBNull.Value;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 50).Value = unidade == "Selecione..." ? "" : unidade;
            comm.Parameters.Add("@status", MySqlDbType.VarChar, 50).Value = status == "Selecione..." ? "" : status;



            comm.Connection = ConectaBanco.ObterConexao(); 

            MySqlDataReader DR = comm.ExecuteReader();
            while (DR.Read())
            {
                string dataArrecadacao = DR["dataArrecadacao"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataArrecadacao"]).ToString("dd/MM/yyyy");
                string dataValidade = DR["dataDEValidade"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataDEValidade"]).ToString("dd/MM/yyyy");

                dgvEstoque.Rows.Add(
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

        private void AtualizarStatusValidade(){
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = @"UPDATE tbProdutos SET status_validade = CASE
                            WHEN dataDeValidade < CURDATE() THEN 'Vencido'
                            ELSE 'Válido' END; ";
            comm.CommandType = CommandType.Text;
            comm.Connection = ConectaBanco.ObterConexao();
            comm.ExecuteNonQuery();
            ConectaBanco.FecharConexao();
        }


        private void frmEstoque_Load(object sender, EventArgs e)
        { 
            btnSaidaEstoque.BringToFront();
            btnEntradaEstoque.BringToFront();
            btnNovoProduto.BringToFront();
            btnRelatorio.BringToFront();
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            configDataGridView();
            AtualizarStatusValidade(); 

           
            cbxCategoria.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;  
            dtpDataValidade.Value = DateTime.Today;
            dtpDataValidade.Checked = false; 

      
            AplicarFiltros();
        }


        string unidades;
        string unidadeEscolhida;
        string status_validade;
        DateTime? dataValidade = null;

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedIndex == 0 && cbxStatus.SelectedIndex == 0 && dtpDataValidade.Value == DateTime.Today)
            {
                MessageBox.Show("Não há filtros para busca", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            unidades = cbxCategoria.Text;
            status_validade = cbxStatus.Text;

            switch (unidades) {
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
                    unidadeEscolhida = "unidades";
                    break;
                case "Caixas":
                    unidadeEscolhida = "Caixas";
                    break;
                default:
                    unidadeEscolhida = "";  
                    break;
            }

            if (dtpDataValidade.Value.Date != DateTime.Today)
            {
                dataValidade = dtpDataValidade.Value.Date;
            }

            carregaDados(txtNomeOrCod.Text, dataValidade, unidadeEscolhida, status_validade);
        }

        private void AplicarFiltros()
        {
            string busca = txtNomeOrCod.Text;

            DateTime? validade = null;
            if (dtpDataValidade.Checked)
            {
                validade = dtpDataValidade.Value.Date;
            }

            string unidades = cbxCategoria.Text;
            string status_validade = cbxStatus.Text;
            string unidadeEscolhida = "";

            switch (unidades)
            {
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
                    unidadeEscolhida = "unidades";
                    break;
                case "Caixas":
                    unidadeEscolhida = "Caixas";
                    break;
                default:
                    unidadeEscolhida = "";
                    break;
            }
            carregaDados(busca, validade, unidadeEscolhida, status_validade);
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header row
            {
                if (e.ColumnIndex == dgvEstoque.Columns["Editar"].Index)
                {
                    // Obter o código do produto da linha selecionada
                    string codProd = dgvEstoque.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                    frmEditarEstoque f = new frmEditarEstoque(codProd);
                    f.DadosAtualizados += () =>
                    {
                        AtualizarStatusValidade();
                        carregaDados();
                    };

                    f.Show();
                }
            }
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            if (cbxCategoria.SelectedIndex == 0 && cbxStatus.SelectedIndex == 0 && dtpDataValidade.Value == DateTime.Today) {
                MessageBox.Show("Não há filtros para limpar", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            carregaDados();
            cbxCategoria.SelectedIndex = 0;
            cbxStatus.SelectedIndex = 0;
            dtpDataValidade.Value = DateTime.Today;
        }

        private void txtNomeOrCod_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

    }
}
