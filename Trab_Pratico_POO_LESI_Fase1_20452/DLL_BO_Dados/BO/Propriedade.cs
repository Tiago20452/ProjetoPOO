/*
 * Classe para descrever uma Propriedade
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 10/11/2023
 * POO
 */


using System;

namespace BO
{
    public class Propriedade
    {
        /// <summary>
        /// Classe Propriedade
        /// </summary>
        #region ATRIBUTOS

        private int codpropriedade; // propriedade id
        private string nome;
        private string tipo; // casa de campo, hotel rural, bangalô...
        private string localizacao;
        private int agregado; //numero maximo de pessoas na estadia
        private double preconoite;
        private bool disponibilidade;

        #endregion

        #region CONSTRUTORES

        /// <summary>
        /// Construtor uma nova propriedade
        /// </summary>
        /// <param name="no"></param>
        /// <param name="tp"></param>
        /// <param name="loc"></param>
        /// <param name="agre"></param>
        /// <param name="pn"></param>
        /// <param name="disp"></param>
        public Propriedade(int cod, string no, string tp, string loc, int agre, double pn, bool disp)
        {
            codpropriedade = cod;
            nome = no;
            tipo = tp;
            localizacao = loc;
            agregado = agre;
            preconoite = pn;
            disponibilidade = disp;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Métodos publicos para ler e escrevrer nas variaveis
        /// </summary>
        public int Codpropriedade
        {
            get { return codpropriedade; }              // obtém o valor 
            set { codpropriedade = value; }             // define o valor
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        public int Agregado
        {
            get { return agregado; }
            set { agregado = value; }
        }

        public double Preconoite
        {
            get { return preconoite; }
            set { preconoite = value; }
        }

        public bool Disponibilidade
        {
            get { return disponibilidade; }
            set { disponibilidade = value; }
        }
        #endregion

        #region OVERRIDES

        // Este método retorna uma string formatada com as informações do objeto.
        public override string ToString()
        {
            return String.Format("\n Código: {0}\n Nome: {1}\n Tipo: {2}\n Localização {3}\n Agregado: {4} pessoas\n Preço por noite: {5} euros\n Disponibilidade: {6}\n"
                , codpropriedade.ToString(), nome.ToUpper(), tipo.ToUpper(), localizacao.ToUpper(), agregado.ToString(), preconoite.ToString(), disponibilidade);
        }
        #endregion
    }
}
