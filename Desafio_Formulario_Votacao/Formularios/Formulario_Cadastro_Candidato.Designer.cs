namespace Desafio_Formulario_Votacao.Formularios
{
    partial class Formulario_Cadastro_Candidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Cadastro_Candidato));
            lbl_Cadastro_Candidatos = new Label();
            pBox_Foto = new PictureBox();
            btn_Adic_Foto_Candidatos = new Button();
            lbl_Nome_Candidato = new Label();
            txt_Nome_Candidato = new TextBox();
            lbl_Num_Candidato = new Label();
            tB_Num_Candidato = new TextBox();
            lbl_Cargo = new Label();
            tB_Cargo = new TextBox();
            lbl_Partido = new Label();
            tB_partido = new TextBox();
            btn_CadastrarCandidato = new Button();
            ((System.ComponentModel.ISupportInitialize)pBox_Foto).BeginInit();
            SuspendLayout();
            // 
            // lbl_Cadastro_Candidatos
            // 
            lbl_Cadastro_Candidatos.AutoSize = true;
            lbl_Cadastro_Candidatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cadastro_Candidatos.Location = new Point(53, 28);
            lbl_Cadastro_Candidatos.Name = "lbl_Cadastro_Candidatos";
            lbl_Cadastro_Candidatos.Size = new Size(251, 30);
            lbl_Cadastro_Candidatos.TabIndex = 1;
            lbl_Cadastro_Candidatos.Text = "Cadastro  de Candidatos\r\n";
            // 
            // pBox_Foto
            // 
            pBox_Foto.Image = (Image)resources.GetObject("pBox_Foto.Image");
            pBox_Foto.Location = new Point(128, 61);
            pBox_Foto.Name = "pBox_Foto";
            pBox_Foto.Size = new Size(100, 133);
            pBox_Foto.SizeMode = PictureBoxSizeMode.Zoom;
            pBox_Foto.TabIndex = 6;
            pBox_Foto.TabStop = false;
            pBox_Foto.Click += pBox_Foto_Click;
            // 
            // btn_Adic_Foto_Candidatos
            // 
            btn_Adic_Foto_Candidatos.Location = new Point(128, 209);
            btn_Adic_Foto_Candidatos.Name = "btn_Adic_Foto_Candidatos";
            btn_Adic_Foto_Candidatos.Size = new Size(100, 38);
            btn_Adic_Foto_Candidatos.TabIndex = 20;
            btn_Adic_Foto_Candidatos.Text = "Adicionar\r\n    Foto";
            btn_Adic_Foto_Candidatos.UseVisualStyleBackColor = true;
            btn_Adic_Foto_Candidatos.Click += btn_Adic_Foto_Candidatos_Click;
            // 
            // lbl_Nome_Candidato
            // 
            lbl_Nome_Candidato.AutoSize = true;
            lbl_Nome_Candidato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nome_Candidato.Location = new Point(115, 262);
            lbl_Nome_Candidato.Name = "lbl_Nome_Candidato";
            lbl_Nome_Candidato.Size = new Size(168, 21);
            lbl_Nome_Candidato.TabIndex = 21;
            lbl_Nome_Candidato.Text = "Nome do Candidato ";
            lbl_Nome_Candidato.Click += lbl_Nome_Candidato_Click;
            // 
            // txt_Nome_Candidato
            // 
            txt_Nome_Candidato.Location = new Point(17, 286);
            txt_Nome_Candidato.Name = "txt_Nome_Candidato";
            txt_Nome_Candidato.Size = new Size(318, 23);
            txt_Nome_Candidato.TabIndex = 22;
            txt_Nome_Candidato.TextChanged += txt_Nome_Candidato_TextChanged;
            // 
            // lbl_Num_Candidato
            // 
            lbl_Num_Candidato.AutoSize = true;
            lbl_Num_Candidato.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Num_Candidato.Location = new Point(17, 417);
            lbl_Num_Candidato.Name = "lbl_Num_Candidato";
            lbl_Num_Candidato.Size = new Size(97, 42);
            lbl_Num_Candidato.TabIndex = 23;
            lbl_Num_Candidato.Text = "Número do\r\nCandidato :\r\n";
            // 
            // tB_Num_Candidato
            // 
            tB_Num_Candidato.Location = new Point(133, 436);
            tB_Num_Candidato.Name = "tB_Num_Candidato";
            tB_Num_Candidato.Size = new Size(95, 23);
            tB_Num_Candidato.TabIndex = 24;
            // 
            // lbl_Cargo
            // 
            lbl_Cargo.AutoSize = true;
            lbl_Cargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cargo.Location = new Point(17, 327);
            lbl_Cargo.Name = "lbl_Cargo";
            lbl_Cargo.Size = new Size(63, 21);
            lbl_Cargo.TabIndex = 25;
            lbl_Cargo.Text = "Cargo :\r\n";
            // 
            // tB_Cargo
            // 
            tB_Cargo.Location = new Point(86, 327);
            tB_Cargo.Name = "tB_Cargo";
            tB_Cargo.Size = new Size(243, 23);
            tB_Cargo.TabIndex = 26;
            // 
            // lbl_Partido
            // 
            lbl_Partido.AutoSize = true;
            lbl_Partido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Partido.Location = new Point(17, 373);
            lbl_Partido.Name = "lbl_Partido";
            lbl_Partido.Size = new Size(74, 21);
            lbl_Partido.TabIndex = 27;
            lbl_Partido.Text = "Partido :\r\n";
            // 
            // tB_partido
            // 
            tB_partido.Location = new Point(97, 375);
            tB_partido.Name = "tB_partido";
            tB_partido.Size = new Size(95, 23);
            tB_partido.TabIndex = 28;
            // 
            // btn_CadastrarCandidato
            // 
            btn_CadastrarCandidato.Location = new Point(135, 491);
            btn_CadastrarCandidato.Name = "btn_CadastrarCandidato";
            btn_CadastrarCandidato.Size = new Size(93, 38);
            btn_CadastrarCandidato.TabIndex = 29;
            btn_CadastrarCandidato.Text = "Cadastrar Candidato";
            btn_CadastrarCandidato.UseVisualStyleBackColor = true;
            btn_CadastrarCandidato.Click += btn_CadastrarCandidato_Click;
            // 
            // Formulario_Cadastro_Candidato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 577);
            Controls.Add(btn_CadastrarCandidato);
            Controls.Add(tB_partido);
            Controls.Add(lbl_Partido);
            Controls.Add(tB_Cargo);
            Controls.Add(lbl_Cargo);
            Controls.Add(tB_Num_Candidato);
            Controls.Add(lbl_Num_Candidato);
            Controls.Add(txt_Nome_Candidato);
            Controls.Add(lbl_Nome_Candidato);
            Controls.Add(btn_Adic_Foto_Candidatos);
            Controls.Add(pBox_Foto);
            Controls.Add(lbl_Cadastro_Candidatos);
            Name = "Formulario_Cadastro_Candidato";
            Text = "Formulário Cadastro de Candidatos";
            Load += Formulario_Cadastro_Candidato_Load;
            ((System.ComponentModel.ISupportInitialize)pBox_Foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Cadastro_Candidatos;
        private PictureBox pBox_Foto;
        private Button btn_Adic_Foto_Candidatos;
        private Label lbl_Nome_Candidato;
        private TextBox txt_Nome_Candidato;
        private Label lbl_Num_Candidato;
        private TextBox tB_Num_Candidato;
        private Label lbl_Cargo;
        private TextBox tB_Cargo;
        private Label lbl_Partido;
        private TextBox tB_partido;
        private Button btn_CadastrarCandidato;
    }
}