namespace SisPadoca
{
    partial class FrmFornecedores
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
            LblCNPJ = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            BtnNovo = new Button();
            BtnFechar = new Button();
            BtnLimpar = new Button();
            BtnExcluir = new Button();
            BtnEditar = new Button();
            MtxTelefone = new MaskedTextBox();
            MtxCNPJ = new MaskedTextBox();
            LblTelefone = new Label();
            PbxLogo = new PictureBox();
            LblLogo = new Label();
            LblEndereco = new Label();
            TxtEndereco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PbxLogo).BeginInit();
            SuspendLayout();
            // 
            // LblCNPJ
            // 
            LblCNPJ.AutoSize = true;
            LblCNPJ.Location = new Point(41, 22);
            LblCNPJ.Margin = new Padding(2, 0, 2, 0);
            LblCNPJ.Name = "LblCNPJ";
            LblCNPJ.Size = new Size(34, 15);
            LblCNPJ.TabIndex = 0;
            LblCNPJ.Text = "CNPJ";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(84, 47);
            TxtEmail.Margin = new Padding(2, 2, 2, 2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(106, 23);
            TxtEmail.TabIndex = 3;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(41, 47);
            LblEmail.Margin = new Padding(2, 0, 2, 0);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 2;
            LblEmail.Text = "Email";
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(41, 203);
            BtnNovo.Margin = new Padding(2, 2, 2, 2);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(78, 49);
            BtnNovo.TabIndex = 4;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(405, 203);
            BtnFechar.Margin = new Padding(2, 2, 2, 2);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(64, 49);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "Fechar";
            BtnFechar.TextAlign = ContentAlignment.MiddleLeft;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(313, 203);
            BtnLimpar.Margin = new Padding(2, 2, 2, 2);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(78, 49);
            BtnLimpar.TabIndex = 6;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(222, 203);
            BtnExcluir.Margin = new Padding(2, 2, 2, 2);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(78, 49);
            BtnExcluir.TabIndex = 7;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(133, 203);
            BtnEditar.Margin = new Padding(2, 2, 2, 2);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(78, 49);
            BtnEditar.TabIndex = 8;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // MtxTelefone
            // 
            MtxTelefone.Location = new Point(85, 76);
            MtxTelefone.Margin = new Padding(2, 2, 2, 2);
            MtxTelefone.Mask = "(00)00000-0000";
            MtxTelefone.Name = "MtxTelefone";
            MtxTelefone.Size = new Size(106, 23);
            MtxTelefone.TabIndex = 9;
            // 
            // MtxCNPJ
            // 
            MtxCNPJ.Location = new Point(84, 20);
            MtxCNPJ.Margin = new Padding(2, 2, 2, 2);
            MtxCNPJ.Mask = "00.000.000/0000-00";
            MtxCNPJ.Name = "MtxCNPJ";
            MtxCNPJ.Size = new Size(106, 23);
            MtxCNPJ.TabIndex = 10;
            // 
            // LblTelefone
            // 
            LblTelefone.AutoSize = true;
            LblTelefone.Location = new Point(24, 77);
            LblTelefone.Margin = new Padding(2, 0, 2, 0);
            LblTelefone.Name = "LblTelefone";
            LblTelefone.Size = new Size(51, 15);
            LblTelefone.TabIndex = 11;
            LblTelefone.Text = "Telefone";
            // 
            // PbxLogo
            // 
            PbxLogo.Image = Properties.Resources.images;
            PbxLogo.Location = new Point(260, 20);
            PbxLogo.Margin = new Padding(2, 2, 2, 2);
            PbxLogo.Name = "PbxLogo";
            PbxLogo.Size = new Size(194, 177);
            PbxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            PbxLogo.TabIndex = 12;
            PbxLogo.TabStop = false;
            // 
            // LblLogo
            // 
            LblLogo.AutoSize = true;
            LblLogo.Location = new Point(222, 14);
            LblLogo.Margin = new Padding(2, 0, 2, 0);
            LblLogo.Name = "LblLogo";
            LblLogo.Size = new Size(34, 15);
            LblLogo.TabIndex = 13;
            LblLogo.Text = "Logo";
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Location = new Point(17, 111);
            LblEndereco.Margin = new Padding(2, 0, 2, 0);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(56, 15);
            LblEndereco.TabIndex = 14;
            LblEndereco.Text = "Endereço";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(85, 111);
            TxtEndereco.Margin = new Padding(2, 2, 2, 2);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(106, 23);
            TxtEndereco.TabIndex = 15;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(TxtEndereco);
            Controls.Add(LblEndereco);
            Controls.Add(LblLogo);
            Controls.Add(PbxLogo);
            Controls.Add(LblTelefone);
            Controls.Add(MtxCNPJ);
            Controls.Add(MtxTelefone);
            Controls.Add(BtnEditar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnFechar);
            Controls.Add(BtnNovo);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Controls.Add(LblCNPJ);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmFornecedores";
            Text = "FrmFornecedores";
            ((System.ComponentModel.ISupportInitialize)PbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblCNPJ;
        private TextBox TxtEmail;
        private Label LblEmail;
        private Button BtnNovo;
        private Button BtnFechar;
        private Button BtnLimpar;
        private Button BtnExcluir;
        private Button BtnEditar;
        private MaskedTextBox MtxTelefone;
        private MaskedTextBox MtxCNPJ;
        private Label LblTelefone;
        private PictureBox PbxLogo;
        private Label LblLogo;
        private Label LblEndereco;
        private TextBox TxtEndereco;
    }
}