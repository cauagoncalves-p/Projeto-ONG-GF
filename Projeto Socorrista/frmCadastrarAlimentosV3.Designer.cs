namespace Projeto_Socorrista
{
    partial class frmControleDeAlimentosV3
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
            this.tbctrlPaginas = new System.Windows.Forms.TabControl();
            this.tbpgCadastrarAlimentos = new System.Windows.Forms.TabPage();
            this.tbpgEstoque = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.dataArrecadacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastradoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbCamposAlimento = new System.Windows.Forms.GroupBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.MtxtObservacoes = new System.Windows.Forms.TextBox();
            this.lblUnidadeDeMedida = new System.Windows.Forms.Label();
            this.cbbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.dtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtNomeDoItem = new System.Windows.Forms.TextBox();
            this.lblNomeDoItem = new System.Windows.Forms.Label();
            this.tbctrlPaginas.SuspendLayout();
            this.tbpgCadastrarAlimentos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.gpbCamposAlimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctrlPaginas
            // 
            this.tbctrlPaginas.Controls.Add(this.tbpgCadastrarAlimentos);
            this.tbctrlPaginas.Controls.Add(this.tbpgEstoque);
            this.tbctrlPaginas.Controls.Add(this.tabPage3);
            this.tbctrlPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctrlPaginas.Location = new System.Drawing.Point(12, 97);
            this.tbctrlPaginas.Name = "tbctrlPaginas";
            this.tbctrlPaginas.SelectedIndex = 0;
            this.tbctrlPaginas.Size = new System.Drawing.Size(1400, 552);
            this.tbctrlPaginas.TabIndex = 0;
            // 
            // tbpgCadastrarAlimentos
            // 
            this.tbpgCadastrarAlimentos.Controls.Add(this.btnAtualizarDados);
            this.tbpgCadastrarAlimentos.Controls.Add(this.btnSair);
            this.tbpgCadastrarAlimentos.Controls.Add(this.groupBox2);
            this.tbpgCadastrarAlimentos.Controls.Add(this.btnCadastrar);
            this.tbpgCadastrarAlimentos.Controls.Add(this.btnCancelar);
            this.tbpgCadastrarAlimentos.Controls.Add(this.gpbCamposAlimento);
            this.tbpgCadastrarAlimentos.Location = new System.Drawing.Point(4, 29);
            this.tbpgCadastrarAlimentos.Name = "tbpgCadastrarAlimentos";
            this.tbpgCadastrarAlimentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgCadastrarAlimentos.Size = new System.Drawing.Size(1392, 519);
            this.tbpgCadastrarAlimentos.TabIndex = 0;
            this.tbpgCadastrarAlimentos.Text = "Cadastro de doações";
            this.tbpgCadastrarAlimentos.UseVisualStyleBackColor = true;
            // 
            // tbpgEstoque
            // 
            this.tbpgEstoque.Location = new System.Drawing.Point(4, 29);
            this.tbpgEstoque.Name = "tbpgEstoque";
            this.tbpgEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgEstoque.Size = new System.Drawing.Size(1392, 604);
            this.tbpgEstoque.TabIndex = 1;
            this.tbpgEstoque.Text = "Estoque";
            this.tbpgEstoque.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1392, 604);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.Location = new System.Drawing.Point(170, 459);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(134, 43);
            this.btnAtualizarDados.TabIndex = 26;
            this.btnAtualizarDados.Text = "Atualizar";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1234, 459);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 43);
            this.btnSair.TabIndex = 27;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dgvRegistro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(480, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 447);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Últimos itens registrados";
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataArrecadacao,
            this.nomeProduto,
            this.quantidadeProduto,
            this.dataValidade,
            this.cadastradoPor});
            this.dgvRegistro.Location = new System.Drawing.Point(6, 26);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.Size = new System.Drawing.Size(894, 415);
            this.dgvRegistro.TabIndex = 15;
            // 
            // dataArrecadacao
            // 
            this.dataArrecadacao.HeaderText = "0";
            this.dataArrecadacao.Name = "dataArrecadacao";
            this.dataArrecadacao.ReadOnly = true;
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "1";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.HeaderText = "2";
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.ReadOnly = true;
            // 
            // dataValidade
            // 
            this.dataValidade.HeaderText = "3";
            this.dataValidade.Name = "dataValidade";
            this.dataValidade.ReadOnly = true;
            // 
            // cadastradoPor
            // 
            this.cadastradoPor.HeaderText = "4";
            this.cadastradoPor.Name = "cadastradoPor";
            this.cadastradoPor.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(6, 459);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 43);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Registrar item";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(340, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 43);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gpbCamposAlimento
            // 
            this.gpbCamposAlimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbCamposAlimento.Controls.Add(this.lblCodBarras);
            this.gpbCamposAlimento.Controls.Add(this.textBox1);
            this.gpbCamposAlimento.Controls.Add(this.lblObservacoes);
            this.gpbCamposAlimento.Controls.Add(this.MtxtObservacoes);
            this.gpbCamposAlimento.Controls.Add(this.lblUnidadeDeMedida);
            this.gpbCamposAlimento.Controls.Add(this.cbbUnidadeMedida);
            this.gpbCamposAlimento.Controls.Add(this.txtPeso);
            this.gpbCamposAlimento.Controls.Add(this.lblPeso);
            this.gpbCamposAlimento.Controls.Add(this.txtQuantidade);
            this.gpbCamposAlimento.Controls.Add(this.lblQuantidade);
            this.gpbCamposAlimento.Controls.Add(this.lblDataValidade);
            this.gpbCamposAlimento.Controls.Add(this.dtpDataValidade);
            this.gpbCamposAlimento.Controls.Add(this.lblDataEntrada);
            this.gpbCamposAlimento.Controls.Add(this.dtpDataEntrada);
            this.gpbCamposAlimento.Controls.Add(this.txtNomeDoItem);
            this.gpbCamposAlimento.Controls.Add(this.lblNomeDoItem);
            this.gpbCamposAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCamposAlimento.Location = new System.Drawing.Point(6, 6);
            this.gpbCamposAlimento.Name = "gpbCamposAlimento";
            this.gpbCamposAlimento.Size = new System.Drawing.Size(468, 447);
            this.gpbCamposAlimento.TabIndex = 23;
            this.gpbCamposAlimento.TabStop = false;
            this.gpbCamposAlimento.Text = "Registro de produtos";
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.Location = new System.Drawing.Point(29, 29);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(146, 20);
            this.lblCodBarras.TabIndex = 51;
            this.lblCodBarras.Text = "Código de barras";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(33, 52);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(29, 259);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(322, 20);
            this.lblObservacoes.TabIndex = 47;
            this.lblObservacoes.Text = "Observações (limite de 300 caracteres)";
            // 
            // MtxtObservacoes
            // 
            this.MtxtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtxtObservacoes.Location = new System.Drawing.Point(33, 282);
            this.MtxtObservacoes.MaxLength = 300;
            this.MtxtObservacoes.Multiline = true;
            this.MtxtObservacoes.Name = "MtxtObservacoes";
            this.MtxtObservacoes.Size = new System.Drawing.Size(390, 159);
            this.MtxtObservacoes.TabIndex = 9;
            // 
            // lblUnidadeDeMedida
            // 
            this.lblUnidadeDeMedida.AutoSize = true;
            this.lblUnidadeDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeDeMedida.Location = new System.Drawing.Point(29, 194);
            this.lblUnidadeDeMedida.Name = "lblUnidadeDeMedida";
            this.lblUnidadeDeMedida.Size = new System.Drawing.Size(164, 20);
            this.lblUnidadeDeMedida.TabIndex = 11;
            this.lblUnidadeDeMedida.Text = "Unidade de Medida";
            // 
            // cbbUnidadeMedida
            // 
            this.cbbUnidadeMedida.FormattingEnabled = true;
            this.cbbUnidadeMedida.Items.AddRange(new object[] {
            "Quilogramas (Kg)",
            "Gramas (g)",
            "Litros (L)",
            "Mililitros (ml)",
            "Unidades (und)",
            "Caixas (cx)"});
            this.cbbUnidadeMedida.Location = new System.Drawing.Point(33, 217);
            this.cbbUnidadeMedida.Name = "cbbUnidadeMedida";
            this.cbbUnidadeMedida.Size = new System.Drawing.Size(236, 28);
            this.cbbUnidadeMedida.TabIndex = 7;
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Location = new System.Drawing.Point(304, 217);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(119, 26);
            this.txtPeso.TabIndex = 8;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(300, 194);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(33, 159);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(236, 26);
            this.txtQuantidade.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(29, 136);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(102, 20);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.Location = new System.Drawing.Point(300, 133);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(144, 20);
            this.lblDataValidade.TabIndex = 5;
            this.lblDataValidade.Text = "Data de validade";
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataValidade.Location = new System.Drawing.Point(304, 156);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(119, 26);
            this.dtpDataValidade.TabIndex = 6;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(300, 81);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(140, 20);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data de entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(304, 104);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(119, 26);
            this.dtpDataEntrada.TabIndex = 4;
            // 
            // txtNomeDoItem
            // 
            this.txtNomeDoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeDoItem.Location = new System.Drawing.Point(33, 104);
            this.txtNomeDoItem.MaxLength = 100;
            this.txtNomeDoItem.Name = "txtNomeDoItem";
            this.txtNomeDoItem.Size = new System.Drawing.Size(236, 26);
            this.txtNomeDoItem.TabIndex = 3;
            // 
            // lblNomeDoItem
            // 
            this.lblNomeDoItem.AutoSize = true;
            this.lblNomeDoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoItem.Location = new System.Drawing.Point(29, 81);
            this.lblNomeDoItem.Name = "lblNomeDoItem";
            this.lblNomeDoItem.Size = new System.Drawing.Size(121, 20);
            this.lblNomeDoItem.TabIndex = 0;
            this.lblNomeDoItem.Text = "Nome do Item";
            // 
            // frmControleDeAlimentosV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 661);
            this.Controls.Add(this.tbctrlPaginas);
            this.Name = "frmControleDeAlimentosV3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmControleDeAlimentosV3_Load);
            this.tbctrlPaginas.ResumeLayout(false);
            this.tbpgCadastrarAlimentos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.gpbCamposAlimento.ResumeLayout(false);
            this.gpbCamposAlimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlPaginas;
        private System.Windows.Forms.TabPage tbpgCadastrarAlimentos;
        private System.Windows.Forms.TabPage tbpgEstoque;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataArrecadacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastradoPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbCamposAlimento;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox MtxtObservacoes;
        private System.Windows.Forms.Label lblUnidadeDeMedida;
        private System.Windows.Forms.ComboBox cbbUnidadeMedida;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.TextBox txtNomeDoItem;
        private System.Windows.Forms.Label lblNomeDoItem;
    }
}