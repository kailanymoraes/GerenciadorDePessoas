namespace PrjGerenciadorDePessoas
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
            lstPessoas = new ListBox();
            btnGerarDoc = new Button();
            btnExcluirTudo = new Button();
            panel1 = new Panel();
            lblMensagem = new Label();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnDet = new Button();
            btnSalvar = new Button();
            btnCriar = new Button();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            lblIdade = new Label();
            lblNome = new Label();
            cmbFormatoRelatorio = new ComboBox();
            lblEscolha = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(553, 109);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(361, 259);
            lstPessoas.TabIndex = 7;
            lstPessoas.SelectedIndexChanged += lstPessoas_SelectedIndexChanged;
            // 
            // btnGerarDoc
            // 
            btnGerarDoc.BackColor = SystemColors.ActiveBorder;
            btnGerarDoc.Cursor = Cursors.Hand;
            btnGerarDoc.FlatAppearance.BorderColor = Color.DimGray;
            btnGerarDoc.FlatAppearance.BorderSize = 2;
            btnGerarDoc.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarDoc.ForeColor = SystemColors.ControlText;
            btnGerarDoc.Location = new Point(553, 409);
            btnGerarDoc.Name = "btnGerarDoc";
            btnGerarDoc.Size = new Size(186, 43);
            btnGerarDoc.TabIndex = 12;
            btnGerarDoc.Text = "&Gerar Documento";
            btnGerarDoc.UseVisualStyleBackColor = false;
            btnGerarDoc.Click += btnGerarDoc_Click;
            // 
            // btnExcluirTudo
            // 
            btnExcluirTudo.BackColor = Color.FromArgb(192, 0, 0);
            btnExcluirTudo.Cursor = Cursors.Hand;
            btnExcluirTudo.Enabled = false;
            btnExcluirTudo.FlatAppearance.BorderColor = Color.DimGray;
            btnExcluirTudo.FlatAppearance.BorderSize = 2;
            btnExcluirTudo.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluirTudo.ForeColor = SystemColors.ButtonHighlight;
            btnExcluirTudo.Location = new Point(745, 409);
            btnExcluirTudo.Name = "btnExcluirTudo";
            btnExcluirTudo.Size = new Size(169, 43);
            btnExcluirTudo.TabIndex = 13;
            btnExcluirTudo.Text = "&Excluir tudo";
            btnExcluirTudo.UseVisualStyleBackColor = false;
            btnExcluirTudo.Click += btnExcluirTudo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(lblMensagem);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnDet);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnCriar);
            panel1.Controls.Add(txtIdade);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblIdade);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(64, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 343);
            panel1.TabIndex = 14;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(23, 300);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(17, 15);
            lblMensagem.TabIndex = 21;
            lblMensagem.Text = "\"\"";
            lblMensagem.Click += lblMensagem_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(192, 0, 0);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderColor = Color.DimGray;
            btnLimpar.FlatAppearance.BorderSize = 2;
            btnLimpar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ForeColor = SystemColors.HighlightText;
            btnLimpar.Location = new Point(178, 212);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(251, 47);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = " &Limpar ";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(192, 0, 0);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.Enabled = false;
            btnExcluir.FlatAppearance.BorderColor = Color.DimGray;
            btnExcluir.FlatAppearance.BorderSize = 2;
            btnExcluir.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = SystemColors.ButtonHighlight;
            btnExcluir.Location = new Point(19, 212);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(153, 47);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnDet
            // 
            btnDet.BackColor = SystemColors.ActiveBorder;
            btnDet.Cursor = Cursors.Hand;
            btnDet.FlatAppearance.BorderColor = Color.DimGray;
            btnDet.FlatAppearance.BorderSize = 2;
            btnDet.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDet.ForeColor = SystemColors.ControlText;
            btnDet.Location = new Point(158, 162);
            btnDet.Name = "btnDet";
            btnDet.Size = new Size(130, 43);
            btnDet.TabIndex = 18;
            btnDet.Text = "&Ver Detalhes";
            btnDet.UseVisualStyleBackColor = false;
            btnDet.Click += btnDet_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveBorder;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Enabled = false;
            btnSalvar.FlatAppearance.BorderColor = Color.DimGray;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = SystemColors.InfoText;
            btnSalvar.Location = new Point(294, 162);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 43);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "&Salvar Pessoa";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = SystemColors.ActiveBorder;
            btnCriar.Cursor = Cursors.Hand;
            btnCriar.FlatAppearance.BorderColor = Color.DimGray;
            btnCriar.FlatAppearance.BorderSize = 2;
            btnCriar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCriar.ForeColor = SystemColors.InfoText;
            btnCriar.Location = new Point(17, 162);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(135, 43);
            btnCriar.TabIndex = 16;
            btnCriar.Text = "&Criar Pessoa";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // txtIdade
            // 
            txtIdade.BackColor = SystemColors.Control;
            txtIdade.BorderStyle = BorderStyle.FixedSingle;
            txtIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.ForeColor = SystemColors.WindowFrame;
            txtIdade.Location = new Point(103, 86);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(69, 33);
            txtIdade.TabIndex = 15;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Control;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.WindowFrame;
            txtNome.Location = new Point(103, 36);
            txtNome.Margin = new Padding(0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(326, 33);
            txtNome.TabIndex = 14;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.BackColor = SystemColors.Control;
            lblIdade.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.InfoText;
            lblIdade.Location = new Point(19, 96);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(58, 21);
            lblIdade.TabIndex = 13;
            lblIdade.Text = "Idade:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.Control;
            lblNome.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.InfoText;
            lblNome.Location = new Point(19, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 21);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // cmbFormatoRelatorio
            // 
            cmbFormatoRelatorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormatoRelatorio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFormatoRelatorio.FormattingEnabled = true;
            cmbFormatoRelatorio.Items.AddRange(new object[] { "Json", "Documento de texto" });
            cmbFormatoRelatorio.Location = new Point(710, 374);
            cmbFormatoRelatorio.Name = "cmbFormatoRelatorio";
            cmbFormatoRelatorio.Size = new Size(204, 29);
            cmbFormatoRelatorio.TabIndex = 15;
            cmbFormatoRelatorio.Tag = "";
            // 
            // lblEscolha
            // 
            lblEscolha.AutoSize = true;
            lblEscolha.Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEscolha.ForeColor = Color.Navy;
            lblEscolha.Location = new Point(553, 376);
            lblEscolha.Name = "lblEscolha";
            lblEscolha.Size = new Size(151, 23);
            lblEscolha.TabIndex = 16;
            lblEscolha.Text = "Formato do relatorio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(414, 39);
            label1.Name = "label1";
            label1.Size = new Size(252, 35);
            label1.TabIndex = 17;
            label1.Text = "Gerenciador de Pessoas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 534);
            Controls.Add(label1);
            Controls.Add(lblEscolha);
            Controls.Add(cmbFormatoRelatorio);
            Controls.Add(panel1);
            Controls.Add(btnExcluirTudo);
            Controls.Add(btnGerarDoc);
            Controls.Add(lstPessoas);
            Name = "Form1";
            Text = "Gerenciador de Pessoa";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstPessoas;
        private Button btnGerarDoc;
        private Button btnExcluirTudo;
        private Panel panel1;
        private Label lblMensagem;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnDet;
        private Button btnSalvar;
        private Button btnCriar;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label lblIdade;
        private Label lblNome;
        private ComboBox cmbFormatoRelatorio;
        private Label lblEscolha;
        private Label label1;
    }
}