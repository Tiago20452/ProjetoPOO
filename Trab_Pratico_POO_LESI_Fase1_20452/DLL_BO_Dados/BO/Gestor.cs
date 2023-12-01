/*
 * Classe para descrever um Cliente
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 03/11/2023
 * POO
 */

using System;

namespace BO
{
    public class Gestor
    {
        /// <summary>
        /// Classe Funcionario
        /// </summary>
        #region ATRIBUTOS

        private string nome;
        private int identificacao;

        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Constroi um Funcionario com base nos atributos submetidos
        /// </summary>
        /// <param name="no"></param>
        /// <param name="id"></param>
        /// <param name="NIF"></param>
        /// <param name="em"></param>
        public Gestor(string no, int id)
        {
            nome = no;
            identificacao = id;
        }
        #endregion

        #region PROPRIEDADES

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Identificacao
        {
            get { return identificacao; }
            set { identificacao = value; }
        }
        #endregion

        #region OVERRIDES

        public override string ToString()
        {
            return String.Format("Gestor: {0}; Identificacao: {1}", nome.ToUpper(), identificacao.ToString());
        }
        #endregion
    }
}
