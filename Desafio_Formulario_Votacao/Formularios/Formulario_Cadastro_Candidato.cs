using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Formulario_Votacao.Formularios
{
    public partial class Formulario_Cadastro_Candidato : Form
    {
        public Formulario_Cadastro_Candidato()
        {
            InitializeComponent();
        }

        //Carregar a foto do usuario.

        private void Formulario_Cadastro_Candidato_Load(object sender, EventArgs e)
        {

        }

        private void pBox_Foto_Click(object sender, EventArgs e)
        {


        }

        private void btn_Adic_Foto_Candidatos_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Nome_Candidato_Click(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarCandidato_Click(object sender, EventArgs e)
        {
            Image foto = pBox_Foto.Image;
            string nome = txt_Nome_Candidato.Text;
            string cargo = tB_Cargo.Text;
            string partido = tB_partido.Text;
            int numCandidato = int.Parse(tB_Num_Candidato.Text);

        }

        private void txt_Nome_Candidato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
