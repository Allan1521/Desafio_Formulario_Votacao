namespace Desafio_Formulario_Votacao.Formularios
{
    partial class Formulario_Votacao
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
            pictureBox1 = new PictureBox();
            lbl_SeuVoto = new Label();
            lblPresidente = new Label();
            lbl_numPresidente = new Label();
            tBox_Leg1 = new TextBox();
            tBox_Leg2 = new TextBox();
            lbl_Nome = new Label();
            textBox1 = new TextBox();
            lblPartido = new Label();
            textBox2 = new TextBox();
            lbl_Aperte = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(358, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_SeuVoto
            // 
            lbl_SeuVoto.AutoSize = true;
            lbl_SeuVoto.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SeuVoto.Location = new Point(82, 34);
            lbl_SeuVoto.Name = "lbl_SeuVoto";
            lbl_SeuVoto.Size = new Size(238, 40);
            lbl_SeuVoto.TabIndex = 1;
            lbl_SeuVoto.Text = "SEU VOTO PARA";
            // 
            // lblPresidente
            // 
            lblPresidente.AutoSize = true;
            lblPresidente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPresidente.Location = new Point(117, 93);
            lblPresidente.Name = "lblPresidente";
            lblPresidente.Size = new Size(156, 32);
            lblPresidente.TabIndex = 2;
            lblPresidente.Text = "PRESIDENTE";
            // 
            // lbl_numPresidente
            // 
            lbl_numPresidente.AutoSize = true;
            lbl_numPresidente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_numPresidente.Location = new Point(22, 171);
            lbl_numPresidente.Name = "lbl_numPresidente";
            lbl_numPresidente.Size = new Size(122, 32);
            lbl_numPresidente.TabIndex = 3;
            lbl_numPresidente.Text = "Número :";
            // 
            // tBox_Leg1
            // 
            tBox_Leg1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Leg1.Location = new Point(167, 146);
            tBox_Leg1.Name = "tBox_Leg1";
            tBox_Leg1.Size = new Size(41, 57);
            tBox_Leg1.TabIndex = 5;
            // 
            // tBox_Leg2
            // 
            tBox_Leg2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tBox_Leg2.Location = new Point(214, 146);
            tBox_Leg2.Name = "tBox_Leg2";
            tBox_Leg2.Size = new Size(41, 57);
            tBox_Leg2.TabIndex = 6;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nome.Location = new Point(22, 230);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(97, 32);
            lbl_Nome.TabIndex = 7;
            lbl_Nome.Text = "Nome :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 23);
            textBox1.TabIndex = 8;
            // 
            // lblPartido
            // 
            lblPartido.AutoSize = true;
            lblPartido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartido.Location = new Point(22, 293);
            lblPartido.Name = "lblPartido";
            lblPartido.Size = new Size(112, 32);
            lblPartido.TabIndex = 9;
            lblPartido.Text = "Partido :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 302);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(60, 23);
            textBox2.TabIndex = 10;
            // 
            // lbl_Aperte
            // 
            lbl_Aperte.AutoSize = true;
            lbl_Aperte.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Aperte.Location = new Point(22, 350);
            lbl_Aperte.Name = "lbl_Aperte";
            lbl_Aperte.Size = new Size(128, 25);
            lbl_Aperte.TabIndex = 11;
            lbl_Aperte.Text = "Aperte a tecla";
            // 
            // Formulario_Votacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(lbl_Aperte);
            Controls.Add(textBox2);
            Controls.Add(lblPartido);
            Controls.Add(textBox1);
            Controls.Add(lbl_Nome);
            Controls.Add(tBox_Leg2);
            Controls.Add(tBox_Leg1);
            Controls.Add(lbl_numPresidente);
            Controls.Add(lblPresidente);
            Controls.Add(lbl_SeuVoto);
            Controls.Add(pictureBox1);
            Name = "Formulario_Votacao";
            Text = "Formulário de Votação";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_SeuVoto;
        private Label lblPresidente;
        private Label lbl_numPresidente;
        private TextBox tBox_Leg1;
        private TextBox tBox_Leg2;
        private Label lbl_Nome;
        private TextBox textBox1;
        private Label lblPartido;
        private TextBox textBox2;
        private Label lbl_Aperte;
    }
}