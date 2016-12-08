using System.Collections.Generic;

//Usando as leis desse site:
//http://www.escoladebicicleta.com.br/dicasCTB.html

namespace CiclistaConsciente.Core
{
    public class Leis
    {
        int artigo;
        int capitulo;
        string imagem;
        string dica;
        string texto;
        public List<Leis> mostrarLeis()
        {
            List<Leis> todasLeis = new List<Leis>();
            todasLeis.Add(new Leis{ capitulo = 2, artigo = 21, texto = "Compete aos órgãos e entidades executivos rodoviários da União, dos Estados, do Distrito Federal e dos Municípios, no âmbito de sua circunscrição: II - planejar, projetar, regulamentar e operar o trânsito de veículos, de pedestres e de animais, e promover o desenvolvimento da circulação e da segurança de ciclistas; " });

            todasLeis.Add(new Leis { capitulo = 2, artigo = 24, texto = "Compete aos órgãos e entidades executivos de trânsito dos Municípios, no âmbito de sua circunscrição: II - planejar, projetar, regulamentar e operar o trânsito de veículos, de pedestres e de animais, e promover o desenvolvimento da circulação e da segurança de ciclistas; " });

            todasLeis.Add(new Leis { capitulo = 3, artigo = 29, texto = "O trânsito de veículos nas vias terrestres abertas à circulação obedecerá às seguintes normas: (...) § 2º Respeitadas as normas de circulação e conduta estabelecidas neste artigo, em ordem decrescente, os veículos de maior porte serão sempre responsáveis pela segurança dos menores, os motorizados pelos não motorizados e, juntos, pela incolumidade dos pedestres." });

            return todasLeis;
        }
    }
}