namespace Desafio_Formulario_Votacao
{
    partial class Form_De_Eleitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_De_Eleitores));
            lbl_Cadastro_Eleitores = new Label();
            lbl_Nome_Eleitor = new Label();
            lbl_num_titulo = new Label();
            lbl_D_Nasc = new Label();
            lbl_Cpf_Eleitor = new Label();
            pictureBox1 = new PictureBox();
            txtNomeEleitor = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            mTBox_Cpf = new MaskedTextBox();
            mTBox_Num_Titulo = new MaskedTextBox();
            lbl_Zona = new Label();
            lbl_Seccao = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lbl_Uf = new Label();
            textBox4 = new TextBox();
            lbl_Filiacao = new Label();
            textBox5 = new TextBox();
            btn_Adic_Foto = new Button();
            btn_CadastrarEleitor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Cadastro_Eleitores
            // 
            lbl_Cadastro_Eleitores.AutoSize = true;
            lbl_Cadastro_Eleitores.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cadastro_Eleitores.Location = new Point(116, 18);
            lbl_Cadastro_Eleitores.Name = "lbl_Cadastro_Eleitores";
            lbl_Cadastro_Eleitores.Size = new Size(218, 30);
            lbl_Cadastro_Eleitores.TabIndex = 0;
            lbl_Cadastro_Eleitores.Text = "Cadastro de Eleitores";
            // 
            // lbl_Nome_Eleitor
            // 
            lbl_Nome_Eleitor.AutoSize = true;
            lbl_Nome_Eleitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nome_Eleitor.Location = new Point(153, 255);
            lbl_Nome_Eleitor.Name = "lbl_Nome_Eleitor";
            lbl_Nome_Eleitor.Size = new Size(139, 21);
            lbl_Nome_Eleitor.TabIndex = 1;
            lbl_Nome_Eleitor.Text = "Nome do Eleitor ";
            // 
            // lbl_num_titulo
            // 
            lbl_num_titulo.AutoSize = true;
            lbl_num_titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_num_titulo.Location = new Point(12, 418);
            lbl_num_titulo.Name = "lbl_num_titulo";
            lbl_num_titulo.Size = new Size(137, 21);
            lbl_num_titulo.TabIndex = 2;
            lbl_num_titulo.Text = "Título do Eleitor ";
            // 
            // lbl_D_Nasc
            // 
            lbl_D_Nasc.AutoSize = true;
            lbl_D_Nasc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_D_Nasc.Location = new Point(12, 351);
            lbl_D_Nasc.Name = "lbl_D_Nasc";
            lbl_D_Nasc.Size = new Size(169, 21);
            lbl_D_Nasc.TabIndex = 3;
            lbl_D_Nasc.Text = "Data de Nascimento ";
            // 
            // lbl_Cpf_Eleitor
            // 
            lbl_Cpf_Eleitor.AutoSize = true;
            lbl_Cpf_Eleitor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cpf_Eleitor.Location = new Point(291, 351);
            lbl_Cpf_Eleitor.Name = "lbl_Cpf_Eleitor";
            lbl_Cpf_Eleitor.Size = new Size(42, 21);
            lbl_Cpf_Eleitor.TabIndex = 4;
            lbl_Cpf_Eleitor.Text = "CPF ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(173, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtNomeEleitor
            // 
            txtNomeEleitor.Location = new Point(12, 297);
            txtNomeEleitor.Name = "txtNomeEleitor";
            txtNomeEleitor.Size = new Size(431, 23);
            txtNomeEleitor.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(178, 349);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // mTBox_Cpf
            // 
            mTBox_Cpf.Location = new Point(343, 349);
            mTBox_Cpf.Mask = "000,000,000-00";
            mTBox_Cpf.Name = "mTBox_Cpf";
            mTBox_Cpf.Size = new Size(100, 23);
            mTBox_Cpf.TabIndex = 9;
            // 
            // mTBox_Num_Titulo
            // 
            mTBox_Num_Titulo.Location = new Point(143, 416);
            mTBox_Num_Titulo.Mask = "0000,0000,0000";
            mTBox_Num_Titulo.Name = "mTBox_Num_Titulo";
            mTBox_Num_Titulo.Size = new Size(93, 23);
            mTBox_Num_Titulo.TabIndex = 10;
            // 
            // lbl_Zona
            // 
            lbl_Zona.AutoSize = true;
            lbl_Zona.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Zona.Location = new Point(243, 418);
            lbl_Zona.Name = "lbl_Zona";
            lbl_Zona.Size = new Size(49, 21);
            lbl_Zona.TabIndex = 11;
            lbl_Zona.Text = "Zona";
            // 
            // lbl_Seccao
            // 
            lbl_Seccao.AutoSize = true;
            lbl_Seccao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Seccao.Location = new Point(343, 418);
            lbl_Seccao.Name = "lbl_Seccao";
            lbl_Seccao.Size = new Size(55, 21);
            lbl_Seccao.TabIndex = 12;
            lbl_Seccao.Text = "Seção";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 416);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(394, 416);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 23);
            textBox3.TabIndex = 14;
            // 
            // lbl_Uf
            // 
            lbl_Uf.AutoSize = true;
            lbl_Uf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Uf.Location = new Point(12, 496);
            lbl_Uf.Name = "lbl_Uf";
            lbl_Uf.Size = new Size(123, 21);
            lbl_Uf.TabIndex = 15;
            lbl_Uf.Text = "Município /UF ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 494);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(49, 23);
            textBox4.TabIndex = 16;
            // 
            // lbl_Filiacao
            // 
            lbl_Filiacao.AutoSize = true;
            lbl_Filiacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Filiacao.Location = new Point(187, 496);
            lbl_Filiacao.Name = "lbl_Filiacao";
            lbl_Filiacao.Size = new Size(69, 21);
            lbl_Filiacao.TabIndex = 17;
            lbl_Filiacao.Text = "Filiação";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(268, 494);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 23);
            textBox5.TabIndex = 18;
            // 
            // btn_Adic_Foto
            // 
            btn_Adic_Foto.Location = new Point(178, 199);
            btn_Adic_Foto.Name = "btn_Adic_Foto";
            btn_Adic_Foto.Size = new Size(93, 38);
            btn_Adic_Foto.TabIndex = 19;
            btn_Adic_Foto.Text = "Adicionar\r\n    Foto";
            btn_Adic_Foto.UseVisualStyleBackColor = true;
            // 
            // btn_CadastrarEleitor
            // 
            btn_CadastrarEleitor.Location = new Point(178, 527);
            btn_CadastrarEleitor.Name = "btn_CadastrarEleitor";
            btn_CadastrarEleitor.Size = new Size(93, 38);
            btn_CadastrarEleitor.TabIndex = 20;
            btn_CadastrarEleitor.Text = "Cadastrar Eleitor";
            btn_CadastrarEleitor.UseVisualStyleBackColor = true;
            // 
            // Form_De_Eleitores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 577);
            Controls.Add(btn_CadastrarEleitor);
            Controls.Add(btn_Adic_Foto);
            Controls.Add(textBox5);
            Controls.Add(lbl_Filiacao);
            Controls.Add(textBox4);
            Controls.Add(lbl_Uf);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lbl_Seccao);
            Controls.Add(lbl_Zona);
            Controls.Add(mTBox_Num_Titulo);
            Controls.Add(mTBox_Cpf);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNomeEleitor);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Cpf_Eleitor);
            Controls.Add(lbl_D_Nasc);
            Controls.Add(lbl_num_titulo);
            Controls.Add(lbl_Nome_Eleitor);
            Controls.Add(lbl_Cadastro_Eleitores);
            Name = "Form_De_Eleitores";
            Text = "Formulário de Eleitores";
            Load += Form_De_Eleitores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Cadastro_Eleitores;
        private Label lbl_Nome_Eleitor;
        private Label lbl_num_titulo;
        private Label lbl_D_Nasc;
        private Label lbl_Cpf_Eleitor;
        private PictureBox pictureBox1;
        private TextBox txtNomeEleitor;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox mTBox_Cpf;
        private MaskedTextBox mTBox_Num_Titulo;
        private Label lbl_Zona;
        private Label lbl_Seccao;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbl_Uf;
        private TextBox textBox4;
        private Label lbl_Filiacao;
        private TextBox textBox5;
        private Button btn_Adic_Foto;
        private Button btn_CadastrarEleitor;
    }
}