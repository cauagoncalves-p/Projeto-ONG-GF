﻿namespace Projeto_Socorrista
{
    partial class frmReceberAlimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceberAlimentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.lblDistribuicao = new System.Windows.Forms.Label();
            this.btnDistribuicao = new System.Windows.Forms.Button();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.lblCadastraAlimentos = new System.Windows.Forms.Label();
            this.btnCadastroALimentos = new System.Windows.Forms.Button();
            this.lblReceberAlimentos = new System.Windows.Forms.Label();
            this.btnReceberAlimentos = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MtxtDescricoes = new System.Windows.Forms.TextBox();
            this.MtxtInformacoes = new System.Windows.Forms.TextBox();
            this.MtxtQuantidade = new System.Windows.Forms.TextBox();
            this.MtxtDataRecebimento = new System.Windows.Forms.TextBox();
            this.MtxtDataValidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUltimasDoacoes = new System.Windows.Forms.Label();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblDataDeReceber = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cbxTipoDoacao = new System.Windows.Forms.ComboBox();
            this.lblTipoDoacao = new System.Windows.Forms.Label();
            this.lblRegistroDoacao = new System.Windows.Forms.Label();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblRelatorios);
            this.panel1.Controls.Add(this.btnRelatorios);
            this.panel1.Controls.Add(this.lblDistribuicao);
            this.panel1.Controls.Add(this.btnDistribuicao);
            this.panel1.Controls.Add(this.lblEstoque);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.lblCadastraAlimentos);
            this.panel1.Controls.Add(this.btnCadastroALimentos);
            this.panel1.Controls.Add(this.lblReceberAlimentos);
            this.panel1.Controls.Add(this.btnReceberAlimentos);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 749);
            this.panel1.TabIndex = 1;
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRelatorios.ForeColor = System.Drawing.Color.White;
            this.lblRelatorios.Location = new System.Drawing.Point(87, 529);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(101, 25);
            this.lblRelatorios.TabIndex = 11;
            this.lblRelatorios.Text = "Relatórios";
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.Location = new System.Drawing.Point(-12, 520);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(290, 43);
            this.btnRelatorios.TabIndex = 12;
            this.btnRelatorios.Text = "         ";
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            // 
            // lblDistribuicao
            // 
            this.lblDistribuicao.AutoSize = true;
            this.lblDistribuicao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDistribuicao.ForeColor = System.Drawing.Color.White;
            this.lblDistribuicao.Location = new System.Drawing.Point(87, 471);
            this.lblDistribuicao.Name = "lblDistribuicao";
            this.lblDistribuicao.Size = new System.Drawing.Size(119, 25);
            this.lblDistribuicao.TabIndex = 9;
            this.lblDistribuicao.Text = "Distribuição";
            // 
            // btnDistribuicao
            // 
            this.btnDistribuicao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDistribuicao.FlatAppearance.BorderSize = 0;
            this.btnDistribuicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribuicao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistribuicao.ForeColor = System.Drawing.Color.White;
            this.btnDistribuicao.Image = ((System.Drawing.Image)(resources.GetObject("btnDistribuicao.Image")));
            this.btnDistribuicao.Location = new System.Drawing.Point(-15, 462);
            this.btnDistribuicao.Name = "btnDistribuicao";
            this.btnDistribuicao.Size = new System.Drawing.Size(290, 43);
            this.btnDistribuicao.TabIndex = 10;
            this.btnDistribuicao.Text = "         ";
            this.btnDistribuicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDistribuicao.UseVisualStyleBackColor = false;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEstoque.ForeColor = System.Drawing.Color.White;
            this.lblEstoque.Location = new System.Drawing.Point(87, 415);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(83, 25);
            this.lblEstoque.TabIndex = 7;
            this.lblEstoque.Text = "Estoque";
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(-12, 406);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(290, 43);
            this.btnEstoque.TabIndex = 8;
            this.btnEstoque.Text = "         ";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = false;
            // 
            // lblCadastraAlimentos
            // 
            this.lblCadastraAlimentos.AutoSize = true;
            this.lblCadastraAlimentos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCadastraAlimentos.ForeColor = System.Drawing.Color.White;
            this.lblCadastraAlimentos.Location = new System.Drawing.Point(87, 356);
            this.lblCadastraAlimentos.Name = "lblCadastraAlimentos";
            this.lblCadastraAlimentos.Size = new System.Drawing.Size(188, 25);
            this.lblCadastraAlimentos.TabIndex = 5;
            this.lblCadastraAlimentos.Text = "Cadastrar alimentos";
            // 
            // btnCadastroALimentos
            // 
            this.btnCadastroALimentos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastroALimentos.FlatAppearance.BorderSize = 0;
            this.btnCadastroALimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroALimentos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroALimentos.ForeColor = System.Drawing.Color.White;
            this.btnCadastroALimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroALimentos.Image")));
            this.btnCadastroALimentos.Location = new System.Drawing.Point(-15, 344);
            this.btnCadastroALimentos.Name = "btnCadastroALimentos";
            this.btnCadastroALimentos.Size = new System.Drawing.Size(290, 43);
            this.btnCadastroALimentos.TabIndex = 6;
            this.btnCadastroALimentos.Text = "         ";
            this.btnCadastroALimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroALimentos.UseVisualStyleBackColor = false;
            // 
            // lblReceberAlimentos
            // 
            this.lblReceberAlimentos.AutoSize = true;
            this.lblReceberAlimentos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblReceberAlimentos.ForeColor = System.Drawing.Color.White;
            this.lblReceberAlimentos.Location = new System.Drawing.Point(87, 297);
            this.lblReceberAlimentos.Name = "lblReceberAlimentos";
            this.lblReceberAlimentos.Size = new System.Drawing.Size(174, 25);
            this.lblReceberAlimentos.TabIndex = 3;
            this.lblReceberAlimentos.Text = "Receber alimentos";
            // 
            // btnReceberAlimentos
            // 
            this.btnReceberAlimentos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReceberAlimentos.FlatAppearance.BorderSize = 0;
            this.btnReceberAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceberAlimentos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceberAlimentos.ForeColor = System.Drawing.Color.White;
            this.btnReceberAlimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnReceberAlimentos.Image")));
            this.btnReceberAlimentos.Location = new System.Drawing.Point(-15, 285);
            this.btnReceberAlimentos.Name = "btnReceberAlimentos";
            this.btnReceberAlimentos.Size = new System.Drawing.Size(290, 43);
            this.btnReceberAlimentos.TabIndex = 4;
            this.btnReceberAlimentos.Text = "         ";
            this.btnReceberAlimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceberAlimentos.UseVisualStyleBackColor = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(87, 233);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(61, 25);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Início";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(-14, 221);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(290, 43);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "         ";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblLinha);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(298, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 939);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.MtxtDescricoes);
            this.panel3.Controls.Add(this.MtxtInformacoes);
            this.panel3.Controls.Add(this.MtxtQuantidade);
            this.panel3.Controls.Add(this.MtxtDataRecebimento);
            this.panel3.Controls.Add(this.MtxtDataValidade);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblUltimasDoacoes);
            this.panel3.Controls.Add(this.dgvRegistro);
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Controls.Add(this.lblDataDeReceber);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.lblObservacao);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblDescricao);
            this.panel3.Controls.Add(this.cbxUnidadeMedida);
            this.panel3.Controls.Add(this.lblUnidade);
            this.panel3.Controls.Add(this.lblQuantidade);
            this.panel3.Controls.Add(this.cbxTipoDoacao);
            this.panel3.Controls.Add(this.lblTipoDoacao);
            this.panel3.Controls.Add(this.lblRegistroDoacao);
            this.panel3.ForeColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(218, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 574);
            this.panel3.TabIndex = 18;
            // 
            // MtxtDescricoes
            // 
            this.MtxtDescricoes.Location = new System.Drawing.Point(48, 447);
            this.MtxtDescricoes.Multiline = true;
            this.MtxtDescricoes.Name = "MtxtDescricoes";
            this.MtxtDescricoes.Size = new System.Drawing.Size(691, 112);
            this.MtxtDescricoes.TabIndex = 45;
            // 
            // MtxtInformacoes
            // 
            this.MtxtInformacoes.Location = new System.Drawing.Point(37, 668);
            this.MtxtInformacoes.Multiline = true;
            this.MtxtInformacoes.Name = "MtxtInformacoes";
            this.MtxtInformacoes.Size = new System.Drawing.Size(691, 129);
            this.MtxtInformacoes.TabIndex = 44;
            // 
            // MtxtQuantidade
            // 
            this.MtxtQuantidade.Location = new System.Drawing.Point(35, 349);
            this.MtxtQuantidade.Multiline = true;
            this.MtxtQuantidade.Name = "MtxtQuantidade";
            this.MtxtQuantidade.Size = new System.Drawing.Size(298, 31);
            this.MtxtQuantidade.TabIndex = 43;
            // 
            // MtxtDataRecebimento
            // 
            this.MtxtDataRecebimento.Location = new System.Drawing.Point(415, 232);
            this.MtxtDataRecebimento.Multiline = true;
            this.MtxtDataRecebimento.Name = "MtxtDataRecebimento";
            this.MtxtDataRecebimento.Size = new System.Drawing.Size(324, 31);
            this.MtxtDataRecebimento.TabIndex = 42;
            // 
            // MtxtDataValidade
            // 
            this.MtxtDataValidade.Location = new System.Drawing.Point(37, 232);
            this.MtxtDataValidade.Multiline = true;
            this.MtxtDataValidade.Name = "MtxtDataValidade";
            this.MtxtDataValidade.Size = new System.Drawing.Size(298, 31);
            this.MtxtDataValidade.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(33, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Data de validade";
            // 
            // lblUltimasDoacoes
            // 
            this.lblUltimasDoacoes.AutoSize = true;
            this.lblUltimasDoacoes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimasDoacoes.ForeColor = System.Drawing.Color.DimGray;
            this.lblUltimasDoacoes.Location = new System.Drawing.Point(32, 964);
            this.lblUltimasDoacoes.Name = "lblUltimasDoacoes";
            this.lblUltimasDoacoes.Size = new System.Drawing.Size(219, 21);
            this.lblUltimasDoacoes.TabIndex = 38;
            this.lblUltimasDoacoes.Text = "Últimas Doações Recebidas";
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToOrderColumns = true;
            this.dgvRegistro.ColumnHeadersHeight = 30;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.doador,
            this.tipo,
            this.quantidade,
            this.descricao});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistro.Location = new System.Drawing.Point(36, 988);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RowHeadersVisible = false;
            this.dgvRegistro.Size = new System.Drawing.Size(715, 281);
            this.dgvRegistro.TabIndex = 37;
            // 
            // date
            // 
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            // 
            // doador
            // 
            this.doador.HeaderText = "Doador";
            this.doador.Name = "doador";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrições";
            this.descricao.Name = "descricao";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(594, 893);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 49);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar doação";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblDataDeReceber
            // 
            this.lblDataDeReceber.AutoSize = true;
            this.lblDataDeReceber.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeReceber.ForeColor = System.Drawing.Color.DimGray;
            this.lblDataDeReceber.Location = new System.Drawing.Point(421, 189);
            this.lblDataDeReceber.Name = "lblDataDeReceber";
            this.lblDataDeReceber.Size = new System.Drawing.Size(170, 21);
            this.lblDataDeReceber.TabIndex = 20;
            this.lblDataDeReceber.Text = "Data de recebimento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(427, 893);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 49);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.DimGray;
            this.lblObservacao.Location = new System.Drawing.Point(33, 615);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(115, 21);
            this.lblObservacao.TabIndex = 34;
            this.lblObservacao.Text = "Obeservações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 1280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 63);
            this.label9.TabIndex = 32;
            this.label9.Text = "t\r\nç\r\nç";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescricao.Location = new System.Drawing.Point(33, 411);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(156, 21);
            this.lblDescricao.TabIndex = 31;
            this.lblDescricao.Text = "Descrição dos Itens";
            // 
            // cbxUnidadeMedida
            // 
            this.cbxUnidadeMedida.BackColor = System.Drawing.Color.White;
            this.cbxUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadeMedida.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidadeMedida.FormattingEnabled = true;
            this.cbxUnidadeMedida.Items.AddRange(new object[] {
            "Selecione...",
            "Quilogramas (kg)",
            "Gramas (g)",
            "Litros (l)",
            "Mililitros (ml)",
            "Unidades",
            "Caixas"});
            this.cbxUnidadeMedida.Location = new System.Drawing.Point(415, 347);
            this.cbxUnidadeMedida.Name = "cbxUnidadeMedida";
            this.cbxUnidadeMedida.Size = new System.Drawing.Size(324, 33);
            this.cbxUnidadeMedida.TabIndex = 29;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.ForeColor = System.Drawing.Color.DimGray;
            this.lblUnidade.Location = new System.Drawing.Point(421, 302);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(160, 21);
            this.lblUnidade.TabIndex = 28;
            this.lblUnidade.Text = "Unidade de Medida";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantidade.Location = new System.Drawing.Point(33, 302);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(100, 21);
            this.lblQuantidade.TabIndex = 27;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // cbxTipoDoacao
            // 
            this.cbxTipoDoacao.BackColor = System.Drawing.Color.White;
            this.cbxTipoDoacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDoacao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDoacao.FormattingEnabled = true;
            this.cbxTipoDoacao.Items.AddRange(new object[] {
            "Selecione...",
            "Alimentos Perecíveis"});
            this.cbxTipoDoacao.Location = new System.Drawing.Point(34, 119);
            this.cbxTipoDoacao.Name = "cbxTipoDoacao";
            this.cbxTipoDoacao.Size = new System.Drawing.Size(717, 29);
            this.cbxTipoDoacao.TabIndex = 24;
            // 
            // lblTipoDoacao
            // 
            this.lblTipoDoacao.AutoSize = true;
            this.lblTipoDoacao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoacao.ForeColor = System.Drawing.Color.DimGray;
            this.lblTipoDoacao.Location = new System.Drawing.Point(30, 84);
            this.lblTipoDoacao.Name = "lblTipoDoacao";
            this.lblTipoDoacao.Size = new System.Drawing.Size(133, 21);
            this.lblTipoDoacao.TabIndex = 23;
            this.lblTipoDoacao.Text = "Tipo de Doação ";
            // 
            // lblRegistroDoacao
            // 
            this.lblRegistroDoacao.AutoSize = true;
            this.lblRegistroDoacao.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDoacao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRegistroDoacao.Location = new System.Drawing.Point(265, 33);
            this.lblRegistroDoacao.Name = "lblRegistroDoacao";
            this.lblRegistroDoacao.Size = new System.Drawing.Size(231, 28);
            this.lblRegistroDoacao.TabIndex = 16;
            this.lblRegistroDoacao.Text = "Registrar nova doação";
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha.ForeColor = System.Drawing.Color.Black;
            this.lblLinha.Location = new System.Drawing.Point(20, 64);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(1215, 43);
            this.lblLinha.TabIndex = 17;
            this.lblLinha.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(20, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 43);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Receber alimentos";
            // 
            // frmReceberAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReceberAlimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReceberAlimentos";
            this.Load += new System.EventHandler(this.frmReceberAlimentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Label lblDistribuicao;
        private System.Windows.Forms.Button btnDistribuicao;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Label lblCadastraAlimentos;
        private System.Windows.Forms.Button btnCadastroALimentos;
        private System.Windows.Forms.Label lblReceberAlimentos;
        private System.Windows.Forms.Button btnReceberAlimentos;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cbxUnidadeMedida;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cbxTipoDoacao;
        private System.Windows.Forms.Label lblTipoDoacao;
        private System.Windows.Forms.Label lblDataDeReceber;
        private System.Windows.Forms.Label lblRegistroDoacao;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblUltimasDoacoes;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn doador;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MtxtDescricoes;
        private System.Windows.Forms.TextBox MtxtInformacoes;
        private System.Windows.Forms.TextBox MtxtQuantidade;
        private System.Windows.Forms.TextBox MtxtDataRecebimento;
        private System.Windows.Forms.TextBox MtxtDataValidade;
    }
}