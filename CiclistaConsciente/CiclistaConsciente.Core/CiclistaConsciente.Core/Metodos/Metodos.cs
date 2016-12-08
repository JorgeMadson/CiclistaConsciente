using System;

//Exemplo do site https://mvvmcross.com/docs/the-core-project
//    namespace TipCalc.Core.Services
//{
//    public interface ICalculation
//    {
//        double TipAmount(double subTotal, int generosity);
//    }
//}


namespace CiclistaConsciente.Core.Metodos
{
    public interface Icalculos
    {
        /////Quiz
        //Temporizador
        TimeSpan tempoRestante(DateTime tempoInicio, DateTime tempoFim);
         
        //preciso de um algoritmo para pontuação
        double Pontuacao();



        /////Sendo consciente
        //Mostrando leis para o ciclista

        /////Dicas de percurso
        //Mostrar o mapa
        //Dependendo do estado clicado mostrar principais praças e ruas para pedalar

        /////Opções
        //desabilitar som, desabilitar vibração, mudar tempoParaPerguntas, mudar qntPerguntas

    }
}
