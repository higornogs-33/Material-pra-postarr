using System;
using System.Windows.Forms;
using System.Text;

namespace SisPadoca
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private Label LblNome;
        private Label LblCPF;
        private TextBox TxtNome;
        private MaskedTextBox MtbCPF;
        private MaskedTextBox MtbCelular;
        private Label LblCelular;
        private MaskedTextBox MtbCEP;
        private Label LblCEP;
        private Label LblEndereco;
        private Label LblObservacoes;
        private DateTimePicker DtpDataNascimento;
        private Label LblEnderecoo;
        private Label LblDataNascimento;
        private ComboBox CmbCargaHoraria;
        private Label LblCargaHoraria;
        private ComboBox CmbSetor;
        private Label LblSetor;
        private ComboBox CmbTurno;
        private Label LblTurno;
        private Label LblEmail;
        private TextBox TxtEmail;
        private TextBox TxtObservacoes;
        private Button BtnNovo;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnFechar;
        private Button BtnCancelar;
        private TextBox TxtEndereco;

        private void InitializeComponent()
        {
            LblNome = new Label();
            LblCPF = new Label();
            TxtNome = new TextBox();
            TxtEndereco = new TextBox();
            MtbCPF = new MaskedTextBox();
            MtbCelular = new MaskedTextBox();
            LblCelular = new Label();
            MtbCEP = new MaskedTextBox();
            LblCEP = new Label();
            LblEndereco = new Label();
            LblObservacoes = new Label();
            DtpDataNascimento = new DateTimePicker();
            LblEnderecoo = new Label();
            LblDataNascimento = new Label();
            CmbCargaHoraria = new ComboBox();
            LblCargaHoraria = new Label();
            CmbSetor = new ComboBox();
            LblSetor = new Label();
            CmbTurno = new ComboBox();
            LblTurno = new Label();
            LblEmail = new Label();
            TxtEmail = new TextBox();
            TxtObservacoes = new TextBox();
            BtnNovo = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnFechar = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(189, 49);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 0;
            LblNome.Text = "Nome";
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Location = new Point(48, 49);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(28, 15);
            LblCPF.TabIndex = 1;
            LblCPF.Text = "CPF";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(173, 74);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(168, 23);
            TxtNome.TabIndex = 2;
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(35, 156);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(100, 23);
            TxtEndereco.TabIndex = 3;
            // 
            // MtbCPF
            // 
            MtbCPF.Location = new Point(35, 74);
            MtbCPF.Mask = "###,###,###-##";
            MtbCPF.Name = "MtbCPF";
            MtbCPF.Size = new Size(100, 23);
            MtbCPF.TabIndex = 4;
            // 
            // MtbCelular
            // 
            MtbCelular.Location = new Point(375, 74);
            MtbCelular.Mask = "(99) 00000-0000";
            MtbCelular.Name = "MtbCelular";
            MtbCelular.Size = new Size(86, 23);
            MtbCelular.TabIndex = 5;
            // 
            // LblCelular
            // 
            LblCelular.AutoSize = true;
            LblCelular.Location = new Point(398, 49);
            LblCelular.Name = "LblCelular";
            LblCelular.Size = new Size(44, 15);
            LblCelular.TabIndex = 6;
            LblCelular.Text = "Celular";
            // 
            // MtbCEP
            // 
            MtbCEP.Location = new Point(173, 156);
            MtbCEP.Mask = "00,000-99";
            MtbCEP.Name = "MtbCEP";
            MtbCEP.Size = new Size(86, 23);
            MtbCEP.TabIndex = 7;
            // 
            // LblCEP
            // 
            LblCEP.AutoSize = true;
            LblCEP.Location = new Point(173, 123);
            LblCEP.Name = "LblCEP";
            LblCEP.Size = new Size(28, 15);
            LblCEP.TabIndex = 8;
            LblCEP.Text = "CEP";
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Location = new Point(48, 123);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(0, 15);
            LblEndereco.TabIndex = 9;
            // 
            // LblObservacoes
            // 
            LblObservacoes.AutoSize = true;
            LblObservacoes.Location = new Point(352, 201);
            LblObservacoes.Name = "LblObservacoes";
            LblObservacoes.Size = new Size(74, 15);
            LblObservacoes.TabIndex = 11;
            LblObservacoes.Text = "Observações";
            // 
            // DtpDataNascimento
            // 
            DtpDataNascimento.Format = DateTimePickerFormat.Short;
            DtpDataNascimento.Location = new Point(625, 74);
            DtpDataNascimento.Name = "DtpDataNascimento";
            DtpDataNascimento.Size = new Size(114, 23);
            DtpDataNascimento.TabIndex = 12;
            DtpDataNascimento.Value = new DateTime(2026, 10, 2, 10, 11, 0, 0);
            DtpDataNascimento.ValueChanged += DtpDataNascimento_ValueChanged;
            // 
            // LblEnderecoo
            // 
            LblEnderecoo.AutoSize = true;
            LblEnderecoo.Location = new Point(48, 123);
            LblEnderecoo.Name = "LblEnderecoo";
            LblEnderecoo.Size = new Size(56, 15);
            LblEnderecoo.TabIndex = 13;
            LblEnderecoo.Text = "Endereço";
            LblEnderecoo.Click += LblEnderecio_Click;
            // 
            // LblDataNascimento
            // 
            LblDataNascimento.AutoSize = true;
            LblDataNascimento.Location = new Point(625, 49);
            LblDataNascimento.Name = "LblDataNascimento";
            LblDataNascimento.Size = new Size(114, 15);
            LblDataNascimento.TabIndex = 14;
            LblDataNascimento.Text = "Data de Nascimento";
            // 
            // CmbCargaHoraria
            // 
            CmbCargaHoraria.FormattingEnabled = true;
            CmbCargaHoraria.Items.AddRange(new object[] { "4 horas", "6 horas ", "8 horas", "Meio Período", "Integral" });
            CmbCargaHoraria.Location = new Point(635, 156);
            CmbCargaHoraria.Name = "CmbCargaHoraria";
            CmbCargaHoraria.Size = new Size(121, 23);
            CmbCargaHoraria.TabIndex = 15;
            // 
            // LblCargaHoraria
            // 
            LblCargaHoraria.AutoSize = true;
            LblCargaHoraria.Location = new Point(649, 133);
            LblCargaHoraria.Name = "LblCargaHoraria";
            LblCargaHoraria.Size = new Size(80, 15);
            LblCargaHoraria.TabIndex = 16;
            LblCargaHoraria.Text = "Carga Horária";
            // 
            // CmbSetor
            // 
            CmbSetor.FormattingEnabled = true;
            CmbSetor.Items.AddRange(new object[] { "Produção", "Atendimento", "Caixa", "Administração" });
            CmbSetor.Location = new Point(292, 156);
            CmbSetor.Name = "CmbSetor";
            CmbSetor.Size = new Size(121, 23);
            CmbSetor.TabIndex = 17;
            // 
            // LblSetor
            // 
            LblSetor.AutoSize = true;
            LblSetor.Location = new Point(307, 133);
            LblSetor.Name = "LblSetor";
            LblSetor.Size = new Size(34, 15);
            LblSetor.TabIndex = 18;
            LblSetor.Text = "Setor";
            // 
            // CmbTurno
            // 
            CmbTurno.FormattingEnabled = true;
            CmbTurno.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite" });
            CmbTurno.Location = new Point(460, 156);
            CmbTurno.Name = "CmbTurno";
            CmbTurno.Size = new Size(121, 23);
            CmbTurno.TabIndex = 19;
            // 
            // LblTurno
            // 
            LblTurno.AutoSize = true;
            LblTurno.Location = new Point(512, 133);
            LblTurno.Name = "LblTurno";
            LblTurno.Size = new Size(38, 15);
            LblTurno.TabIndex = 20;
            LblTurno.Text = "Turno";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(512, 49);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 21;
            LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(494, 74);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 22;
            // 
            // TxtObservacoes
            // 
            TxtObservacoes.Location = new Point(219, 230);
            TxtObservacoes.Name = "TxtObservacoes";
            TxtObservacoes.Size = new Size(362, 23);
            TxtObservacoes.TabIndex = 23;
            // 
            // BtnNovo
            // 
            BtnNovo.Font = new Font("Tahoma", 12F);
            BtnNovo.Location = new Point(86, 273);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(100, 50);
            BtnNovo.TabIndex = 73;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Tahoma", 12F);
            BtnEditar.Location = new Point(192, 273);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(100, 50);
            BtnEditar.TabIndex = 74;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Font = new Font("Tahoma", 12F);
            BtnExcluir.Location = new Point(298, 273);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(100, 50);
            BtnExcluir.TabIndex = 75;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new Font("Tahoma", 12F);
            BtnFechar.Location = new Point(690, 273);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(100, 50);
            BtnFechar.TabIndex = 77;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Tahoma", 12F);
            BtnCancelar.Location = new Point(584, 273);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(100, 50);
            BtnCancelar.TabIndex = 78;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmFuncionarios
            // 
            ClientSize = new Size(850, 335);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnFechar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnNovo);
            Controls.Add(TxtObservacoes);
            Controls.Add(TxtEmail);
            Controls.Add(LblEmail);
            Controls.Add(LblTurno);
            Controls.Add(CmbTurno);
            Controls.Add(LblSetor);
            Controls.Add(CmbSetor);
            Controls.Add(LblCargaHoraria);
            Controls.Add(CmbCargaHoraria);
            Controls.Add(LblDataNascimento);
            Controls.Add(LblEnderecoo);
            Controls.Add(DtpDataNascimento);
            Controls.Add(LblObservacoes);
            Controls.Add(LblEndereco);
            Controls.Add(LblCEP);
            Controls.Add(MtbCEP);
            Controls.Add(LblCelular);
            Controls.Add(MtbCelular);
            Controls.Add(MtbCPF);
            Controls.Add(TxtEndereco);
            Controls.Add(TxtNome);
            Controls.Add(LblCPF);
            Controls.Add(LblNome);
            Name = "FrmFuncionarios";
            ResumeLayout(false);
            PerformLayout();

        }

        private void DtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblEnderecio_Click(object sender, EventArgs e)
        {

        }

        private void TxtObservacoes_TextChanged(object sender, EventArgs e)
        { }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

        }
    }
    namespace SisPadoca
    {

        public partial class FrmFuncionarios : Form
        {
            public FrmFuncionarios()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {

            }
        }
        }
    }


































