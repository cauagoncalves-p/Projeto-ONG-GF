using MySql.Data.MySqlClient;
using Projeto_Socorrista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Socorrista
{
    public partial class frmEditarEstoque : Form
    {
        private int codProduto;
        public frmEditarEstoque()
        {
            InitializeComponent();
        }

        public frmEditarEstoque(string codProd)
        {
            
            InitializeComponent();
            codProduto = Convert.ToInt32(codProd);
            carregaDadosProduto(codProduto);

        }

        public void carregaDadosProduto(int codProd){
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbProdutos WHERE codProd = @codProd";
            comm.Parameters.AddWithValue("@codProd", codProd);

            comm.Connection = ConectaBanco.ObterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            if (DR.Read())
            {
                txtCodigo.Text = DR["codProd"].ToString();
                txtProduto.Text = DR["nome"].ToString();
                cbxCategoria.Text = DR["unidade"].ToString();
                nudQuantidade.Value = Convert.ToDecimal(DR["quantidade"]);
                dtpValidade.Text = DR["dataDEValidade"] == DBNull.Value ? "" : Convert.ToDateTime(DR["dataDEValidade"]).ToString("dd/MM/yyyy");
            }
        }
    }
}
