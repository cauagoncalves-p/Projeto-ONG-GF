namespace Projeto_Socorrista
{
    partial class frmCadastrarAlimentosV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarAlimentosV2));
            this.gpbCamposAlimento = new System.Windows.Forms.GroupBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipoDeItem = new System.Windows.Forms.Label();
            this.cbbTipoDoacao = new System.Windows.Forms.ComboBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.dataArrecadacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastradoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbCamposAlimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCamposAlimento
            // 
            this.gpbCamposAlimento.Controls.Add(this.lblCodBarras);
            this.gpbCamposAlimento.Controls.Add(this.textBox1);
            this.gpbCamposAlimento.Controls.Add(this.lblTipoDeItem);
            this.gpbCamposAlimento.Controls.Add(this.cbbTipoDoacao);
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
            this.gpbCamposAlimento.Location = new System.Drawing.Point(12, 118);
            this.gpbCamposAlimento.Name = "gpbCamposAlimento";
            this.gpbCamposAlimento.Size = new System.Drawing.Size(458, 481);
            this.gpbCamposAlimento.TabIndex = 0;
            this.gpbCamposAlimento.TabStop = false;
            this.gpbCamposAlimento.Text = "Registrar nova doação";
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.Location = new System.Drawing.Point(31, 92);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(146, 20);
            this.lblCodBarras.TabIndex = 51;
            this.lblCodBarras.Text = "Código de barras";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(35, 115);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 26);
            this.textBox1.TabIndex = 2;
            // 
            // lblTipoDeItem
            // 
            this.lblTipoDeItem.AutoSize = true;
            this.lblTipoDeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeItem.Location = new System.Drawing.Point(31, 35);
            this.lblTipoDeItem.Name = "lblTipoDeItem";
            this.lblTipoDeItem.Size = new System.Drawing.Size(107, 20);
            this.lblTipoDeItem.TabIndex = 49;
            this.lblTipoDeItem.Text = "Tipo de item";
            // 
            // cbbTipoDoacao
            // 
            this.cbbTipoDoacao.FormattingEnabled = true;
            this.cbbTipoDoacao.Items.AddRange(new object[] {
            "Selecione um item"});
            this.cbbTipoDoacao.Location = new System.Drawing.Point(35, 58);
            this.cbbTipoDoacao.Name = "cbbTipoDoacao";
            this.cbbTipoDoacao.Size = new System.Drawing.Size(386, 28);
            this.cbbTipoDoacao.TabIndex = 1;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(31, 317);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(322, 20);
            this.lblObservacoes.TabIndex = 47;
            this.lblObservacoes.Text = "Observações (limite de 300 caracteres)";
            // 
            // MtxtObservacoes
            // 
            this.MtxtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MtxtObservacoes.Location = new System.Drawing.Point(35, 340);
            this.MtxtObservacoes.MaxLength = 300;
            this.MtxtObservacoes.Multiline = true;
            this.MtxtObservacoes.Name = "MtxtObservacoes";
            this.MtxtObservacoes.Size = new System.Drawing.Size(390, 135);
            this.MtxtObservacoes.TabIndex = 9;
            // 
            // lblUnidadeDeMedida
            // 
            this.lblUnidadeDeMedida.AutoSize = true;
            this.lblUnidadeDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadeDeMedida.Location = new System.Drawing.Point(31, 257);
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
            this.cbbUnidadeMedida.Location = new System.Drawing.Point(35, 280);
            this.cbbUnidadeMedida.Name = "cbbUnidadeMedida";
            this.cbbUnidadeMedida.Size = new System.Drawing.Size(236, 28);
            this.cbbUnidadeMedida.TabIndex = 7;
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Location = new System.Drawing.Point(306, 280);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(119, 26);
            this.txtPeso.TabIndex = 8;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(302, 257);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(35, 222);
            this.txtQuantidade.MaxLength = 10;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(236, 26);
            this.txtQuantidade.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(31, 199);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(102, 20);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.Location = new System.Drawing.Point(302, 196);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(144, 20);
            this.lblDataValidade.TabIndex = 5;
            this.lblDataValidade.Text = "Data de validade";
            // 
            // dtpDataValidade
            // 
            this.dtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataValidade.Location = new System.Drawing.Point(306, 219);
            this.dtpDataValidade.Name = "dtpDataValidade";
            this.dtpDataValidade.Size = new System.Drawing.Size(119, 26);
            this.dtpDataValidade.TabIndex = 6;
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(302, 144);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(140, 20);
            this.lblDataEntrada.TabIndex = 3;
            this.lblDataEntrada.Text = "Data de entrada";
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(306, 167);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(119, 26);
            this.dtpDataEntrada.TabIndex = 4;
            // 
            // txtNomeDoItem
            // 
            this.txtNomeDoItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeDoItem.Location = new System.Drawing.Point(35, 167);
            this.txtNomeDoItem.MaxLength = 100;
            this.txtNomeDoItem.Name = "txtNomeDoItem";
            this.txtNomeDoItem.Size = new System.Drawing.Size(236, 26);
            this.txtNomeDoItem.TabIndex = 3;
            // 
            // lblNomeDoItem
            // 
            this.lblNomeDoItem.AutoSize = true;
            this.lblNomeDoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoItem.Location = new System.Drawing.Point(31, 144);
            this.lblNomeDoItem.Name = "lblNomeDoItem";
            this.lblNomeDoItem.Size = new System.Drawing.Size(121, 20);
            this.lblNomeDoItem.TabIndex = 0;
            this.lblNomeDoItem.Text = "Nome do Item";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(165, 605);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 43);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 605);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 43);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar item";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de doações";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(100, 100);
            this.pcbLogo.TabIndex = 2;
            this.pcbLogo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtualizarDados);
            this.groupBox2.Controls.Add(this.dgvRegistro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(476, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 481);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Últimos itens adicionados";
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarDados.Location = new System.Drawing.Point(6, 432);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(126, 43);
            this.btnAtualizarDados.TabIndex = 14;
            this.btnAtualizarDados.Text = "Atualizar";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
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
            this.dgvRegistro.Location = new System.Drawing.Point(6, 38);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.Size = new System.Drawing.Size(924, 388);
            this.dgvRegistro.TabIndex = 14;
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
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1286, 605);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 43);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadastrarAlimentosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 661);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.gpbCamposAlimento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarAlimentosV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarAlimentosV2";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmCadastrarAlimentosV2_Load);
            this.gpbCamposAlimento.ResumeLayout(false);
            this.gpbCamposAlimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCamposAlimento;
        private System.Windows.Forms.TextBox txtNomeDoItem;
        private System.Windows.Forms.Label lblNomeDoItem;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.DateTimePicker dtpDataValidade;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblUnidadeDeMedida;
        private System.Windows.Forms.ComboBox cbbUnidadeMedida;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox MtxtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblTipoDeItem;
        private System.Windows.Forms.ComboBox cbbTipoDoacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataArrecadacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastradoPor;
    }
}