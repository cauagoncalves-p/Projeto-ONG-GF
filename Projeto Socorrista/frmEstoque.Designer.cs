namespace Projeto_Socorrista
{
    partial class frmEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.lblValidadeAte = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnDistribuicao = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnControleDeEstoque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReceberAlimento = new System.Windows.Forms.Button();
            this.lblNavegacao = new System.Windows.Forms.Label();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnEntradaEstoque = new System.Windows.Forms.Button();
            this.btnSaidaEstoque = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblQRCODE = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNomeOrCod = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCodOrNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataArrecadacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTituloEstoque = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLerQRCode = new System.Windows.Forms.Button();
            this.btnDarBaixa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.dtpDataValidade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAplicarFiltros);
            this.panel1.Controls.Add(this.lblValidadeAte);
            this.panel1.Controls.Add(this.cbxStatus);
            this.panel1.Controls.Add(this.lblFiltros);
            this.panel1.Controls.Add(this.cbxCategoria);
            this.panel1.Controls.Add(this.btnDistribuicao);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnControleDeEstoque);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReceberAlimento);
            this.panel1.Controls.Add(this.lblNavegacao);
            this.panel1.Location = new System.Drawing.Point(2, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 724);
            this.panel1.TabIndex = 0;
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataValidade.Location = new System.Drawing.Point(18, 541);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(208, 20);
            this.dtpDataValidade.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "________________________";
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnAplicarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAplicarFiltros.FlatAppearance.BorderSize = 0;
            this.btnAplicarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(18, 594);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(208, 28);
            this.btnAplicarFiltros.TabIndex = 11;
            this.btnAplicarFiltros.Text = "Aplicar filtros";
            this.btnAplicarFiltros.UseVisualStyleBackColor = false;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click);
            // 
            // lblValidadeAte
            // 
            this.lblValidadeAte.AutoSize = true;
            this.lblValidadeAte.Location = new System.Drawing.Point(15, 515);
            this.lblValidadeAte.Name = "lblValidadeAte";
            this.lblValidadeAte.Size = new System.Drawing.Size(69, 13);
            this.lblValidadeAte.TabIndex = 7;
            this.lblValidadeAte.Text = "Validade até:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Selecione...",
            "Valido",
            "Vencido"});
            this.cbxStatus.Location = new System.Drawing.Point(18, 404);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(208, 21);
            this.cbxStatus.TabIndex = 9;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.ForeColor = System.Drawing.Color.Navy;
            this.lblFiltros.Location = new System.Drawing.Point(10, 327);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(52, 20);
            this.lblFiltros.TabIndex = 10;
            this.lblFiltros.Text = "Filtros";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Selecione...",
            "Quilogramas (kg)",
            "Gramas (g)",
            "Litros (l)",
            "Mililitros (ml)",
            "Unidades",
            "Caixas"});
            this.cbxCategoria.Location = new System.Drawing.Point(18, 476);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(208, 21);
            this.cbxCategoria.TabIndex = 2;
            // 
            // btnDistribuicao
            // 
            this.btnDistribuicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnDistribuicao.FlatAppearance.BorderSize = 0;
            this.btnDistribuicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuicao.Location = new System.Drawing.Point(14, 226);
            this.btnDistribuicao.Name = "btnDistribuicao";
            this.btnDistribuicao.Size = new System.Drawing.Size(239, 36);
            this.btnDistribuicao.TabIndex = 8;
            this.btnDistribuicao.Text = "Distribuição";
            this.btnDistribuicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDistribuicao.UseVisualStyleBackColor = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(15, 447);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.Location = new System.Drawing.Point(14, 97);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(239, 36);
            this.btnDashBoard.TabIndex = 5;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 378);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // btnControleDeEstoque
            // 
            this.btnControleDeEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnControleDeEstoque.FlatAppearance.BorderSize = 0;
            this.btnControleDeEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleDeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleDeEstoque.Location = new System.Drawing.Point(14, 184);
            this.btnControleDeEstoque.Name = "btnControleDeEstoque";
            this.btnControleDeEstoque.Size = new System.Drawing.Size(239, 36);
            this.btnControleDeEstoque.TabIndex = 7;
            this.btnControleDeEstoque.Text = "Controle de Estoque";
            this.btnControleDeEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControleDeEstoque.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "________________________";
            // 
            // btnReceberAlimento
            // 
            this.btnReceberAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnReceberAlimento.FlatAppearance.BorderSize = 0;
            this.btnReceberAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceberAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceberAlimento.Location = new System.Drawing.Point(14, 141);
            this.btnReceberAlimento.Name = "btnReceberAlimento";
            this.btnReceberAlimento.Size = new System.Drawing.Size(239, 36);
            this.btnReceberAlimento.TabIndex = 6;
            this.btnReceberAlimento.Text = "Receber Alimentos";
            this.btnReceberAlimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceberAlimento.UseVisualStyleBackColor = false;
            // 
            // lblNavegacao
            // 
            this.lblNavegacao.AutoSize = true;
            this.lblNavegacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavegacao.ForeColor = System.Drawing.Color.Navy;
            this.lblNavegacao.Location = new System.Drawing.Point(10, 35);
            this.lblNavegacao.Name = "lblNavegacao";
            this.lblNavegacao.Size = new System.Drawing.Size(89, 20);
            this.lblNavegacao.TabIndex = 5;
            this.lblNavegacao.Text = "Navegação";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnNovoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoProduto.Location = new System.Drawing.Point(16, 7);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(99, 23);
            this.btnNovoProduto.TabIndex = 5;
            this.btnNovoProduto.Text = "+ Novo produto";
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // btnEntradaEstoque
            // 
            this.btnEntradaEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnEntradaEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntradaEstoque.Location = new System.Drawing.Point(121, 7);
            this.btnEntradaEstoque.Name = "btnEntradaEstoque";
            this.btnEntradaEstoque.Size = new System.Drawing.Size(99, 23);
            this.btnEntradaEstoque.TabIndex = 6;
            this.btnEntradaEstoque.Text = "Entrada Estoque";
            this.btnEntradaEstoque.UseVisualStyleBackColor = false;
            // 
            // btnSaidaEstoque
            // 
            this.btnSaidaEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnSaidaEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaidaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaidaEstoque.Location = new System.Drawing.Point(229, 7);
            this.btnSaidaEstoque.Name = "btnSaidaEstoque";
            this.btnSaidaEstoque.Size = new System.Drawing.Size(99, 23);
            this.btnSaidaEstoque.TabIndex = 7;
            this.btnSaidaEstoque.Text = "Saída Estoque";
            this.btnSaidaEstoque.UseVisualStyleBackColor = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorio.Location = new System.Drawing.Point(338, 7);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(99, 23);
            this.btnRelatorio.TabIndex = 8;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblQRCODE);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblCodOrNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvEstoque);
            this.panel2.Controls.Add(this.lblSubTitulo);
            this.panel2.Controls.Add(this.lblTituloEstoque);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(251, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 724);
            this.panel2.TabIndex = 1;
            // 
            // lblQRCODE
            // 
            this.lblQRCODE.AutoSize = true;
            this.lblQRCODE.Location = new System.Drawing.Point(30, 226);
            this.lblQRCODE.Name = "lblQRCODE";
            this.lblQRCODE.Size = new System.Drawing.Size(130, 13);
            this.lblQRCODE.TabIndex = 14;
            this.lblQRCODE.Text = "Leitor de código de barras";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.txtNomeOrCod);
            this.panel4.Controls.Add(this.btnPesquisar);
            this.panel4.Controls.Add(this.btnLimpar);
            this.panel4.Location = new System.Drawing.Point(33, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1078, 57);
            this.panel4.TabIndex = 13;
            // 
            // txtNomeOrCod
            // 
            this.txtNomeOrCod.BackColor = System.Drawing.Color.White;
            this.txtNomeOrCod.Location = new System.Drawing.Point(17, 17);
            this.txtNomeOrCod.Multiline = true;
            this.txtNomeOrCod.Name = "txtNomeOrCod";
            this.txtNomeOrCod.Size = new System.Drawing.Size(755, 26);
            this.txtNomeOrCod.TabIndex = 13;
            this.txtNomeOrCod.TextChanged += new System.EventHandler(this.txtNomeOrCod_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(824, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 26);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "   Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Navy;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Location = new System.Drawing.Point(962, 17);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 26);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Dar baixa";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // lblCodOrNome
            // 
            this.lblCodOrNome.AutoSize = true;
            this.lblCodOrNome.Location = new System.Drawing.Point(30, 120);
            this.lblCodOrNome.Name = "lblCodOrNome";
            this.lblCodOrNome.Size = new System.Drawing.Size(89, 13);
            this.lblCodOrNome.TabIndex = 2;
            this.lblCodOrNome.Text = "Código ou Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "_________________________________________________________________________________" +
    "________________";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.produto,
            this.quantidade,
            this.unidade,
            this.dataArrecadacao,
            this.validade,
            this.status});
            this.dgvEstoque.Location = new System.Drawing.Point(36, 327);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.Size = new System.Drawing.Size(1099, 357);
            this.dgvEstoque.TabIndex = 5;
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // unidade
            // 
            this.unidade.HeaderText = "Unidade";
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // dataArrecadacao
            // 
            this.dataArrecadacao.HeaderText = "Arrecadação";
            this.dataArrecadacao.Name = "dataArrecadacao";
            this.dataArrecadacao.ReadOnly = true;
            // 
            // validade
            // 
            this.validade.HeaderText = "Validade";
            this.validade.Name = "validade";
            this.validade.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(26, 63);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(372, 20);
            this.lblSubTitulo.TabIndex = 4;
            this.lblSubTitulo.Text = "Consulta e gerenciamento de produtos em estoque";
            // 
            // lblTituloEstoque
            // 
            this.lblTituloEstoque.AutoSize = true;
            this.lblTituloEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstoque.ForeColor = System.Drawing.Color.Navy;
            this.lblTituloEstoque.Location = new System.Drawing.Point(26, 18);
            this.lblTituloEstoque.Name = "lblTituloEstoque";
            this.lblTituloEstoque.Size = new System.Drawing.Size(188, 24);
            this.lblTituloEstoque.TabIndex = 3;
            this.lblTituloEstoque.Text = "Controle de Estoque ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnLerQRCode);
            this.panel3.Controls.Add(this.btnDarBaixa);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(33, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1078, 57);
            this.panel3.TabIndex = 2;
            // 
            // btnLerQRCode
            // 
            this.btnLerQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.btnLerQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLerQRCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLerQRCode.FlatAppearance.BorderSize = 0;
            this.btnLerQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLerQRCode.Image = ((System.Drawing.Image)(resources.GetObject("btnLerQRCode.Image")));
            this.btnLerQRCode.Location = new System.Drawing.Point(824, 17);
            this.btnLerQRCode.Name = "btnLerQRCode";
            this.btnLerQRCode.Size = new System.Drawing.Size(100, 26);
            this.btnLerQRCode.TabIndex = 12;
            this.btnLerQRCode.Text = "   Ler Código";
            this.btnLerQRCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLerQRCode.UseVisualStyleBackColor = false;
            // 
            // btnDarBaixa
            // 
            this.btnDarBaixa.BackColor = System.Drawing.Color.Navy;
            this.btnDarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarBaixa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDarBaixa.FlatAppearance.BorderSize = 0;
            this.btnDarBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaixa.ForeColor = System.Drawing.Color.Transparent;
            this.btnDarBaixa.Location = new System.Drawing.Point(962, 17);
            this.btnDarBaixa.Name = "btnDarBaixa";
            this.btnDarBaixa.Size = new System.Drawing.Size(84, 26);
            this.btnDarBaixa.TabIndex = 11;
            this.btnDarBaixa.Text = "Dar baixa";
            this.btnDarBaixa.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 26);
            this.textBox1.TabIndex = 11;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1391, 761);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSaidaEstoque);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnEntradaEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de estoque ";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNavegacao;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSaidaEstoque;
        private System.Windows.Forms.Button btnEntradaEstoque;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnDistribuicao;
        private System.Windows.Forms.Button btnControleDeEstoque;
        private System.Windows.Forms.Button btnReceberAlimento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTituloEstoque;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLerQRCode;
        private System.Windows.Forms.Button btnDarBaixa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblValidadeAte;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCodOrNome;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNomeOrCod;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblQRCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataArrecadacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}