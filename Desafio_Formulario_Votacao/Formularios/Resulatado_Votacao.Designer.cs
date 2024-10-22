namespace Desafio_Formulario_Votacao.Formularios
{
    partial class Resulatado_Votacao
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
            lbl_ResulatdoFinalVotacao = new Label();
            lbl_Total_Votos = new Label();
            lbl_Validos = new Label();
            lbl_Brancos = new Label();
            lbl_Nulos = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // lbl_ResulatdoFinalVotacao
            // 
            lbl_ResulatdoFinalVotacao.AutoSize = true;
            lbl_ResulatdoFinalVotacao.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ResulatdoFinalVotacao.Location = new Point(9, 20);
            lbl_ResulatdoFinalVotacao.Name = "lbl_ResulatdoFinalVotacao";
            lbl_ResulatdoFinalVotacao.Size = new Size(386, 40);
            lbl_ResulatdoFinalVotacao.TabIndex = 2;
            lbl_ResulatdoFinalVotacao.Text = "Resulatdo Final da Votação";
            // 
            // lbl_Total_Votos
            // 
            lbl_Total_Votos.AutoSize = true;
            lbl_Total_Votos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Total_Votos.Location = new Point(58, 126);
            lbl_Total_Votos.Name = "lbl_Total_Votos";
            lbl_Total_Votos.Size = new Size(130, 21);
            lbl_Total_Votos.TabIndex = 26;
            lbl_Total_Votos.Text = "Total de Votos  :\r\n";
            // 
            // lbl_Validos
            // 
            lbl_Validos.AutoSize = true;
            lbl_Validos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Validos.Location = new Point(58, 166);
            lbl_Validos.Name = "lbl_Validos";
            lbl_Validos.Size = new Size(74, 21);
            lbl_Validos.TabIndex = 27;
            lbl_Validos.Text = "Válidos :\r\n";
            // 
            // lbl_Brancos
            // 
            lbl_Brancos.AutoSize = true;
            lbl_Brancos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Brancos.Location = new Point(54, 205);
            lbl_Brancos.Name = "lbl_Brancos";
            lbl_Brancos.Size = new Size(78, 21);
            lbl_Brancos.TabIndex = 28;
            lbl_Brancos.Text = " Brancos:\r\n";
            // 
            // lbl_Nulos
            // 
            lbl_Nulos.AutoSize = true;
            lbl_Nulos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nulos.Location = new Point(58, 237);
            lbl_Nulos.Name = "lbl_Nulos";
            lbl_Nulos.Size = new Size(63, 21);
            lbl_Nulos.TabIndex = 29;
            lbl_Nulos.Text = "Nulos :\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(60, 23);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 31;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 23);
            textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(280, 239);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 23);
            textBox4.TabIndex = 33;
            // 
            // Resulatado_Votacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 299);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(lbl_Nulos);
            Controls.Add(lbl_Brancos);
            Controls.Add(lbl_Validos);
            Controls.Add(lbl_Total_Votos);
            Controls.Add(lbl_ResulatdoFinalVotacao);
            Name = "Resulatado_Votacao";
            Text = "Resulatado da Votação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ResulatdoFinalVotacao;
        private Label lbl_Total_Votos;
        private Label lbl_Validos;
        private Label lbl_Brancos;
        private Label lbl_Nulos;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}