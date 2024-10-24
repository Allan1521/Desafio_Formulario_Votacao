using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Formulario_Votacao.Formularios
{
    public class Candidato //Criei a classe objeto
                           //Juntamente c/suas variáveis
    {
        public Image Foto { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Partido { get; set; }
        public int NumCandidato { get; set; }

        public Candidato( Image foto, string nome, string cargo, string partido, int numCandidato)
            //Criado o método construtor, passando tipo e parâmetro
            { 
                Foto = foto;
                Nome = nome;    
                Cargo = cargo;
                Partido = partido;
                NumCandidato = numCandidato;

            }

    }

    
}
