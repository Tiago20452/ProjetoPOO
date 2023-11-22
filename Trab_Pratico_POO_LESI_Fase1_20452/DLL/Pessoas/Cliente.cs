/*
 * Classe para descrever um Cliente
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 03/11/2023
 * POO
 */

using System;
namespace Pessoas
{
    public class Cliente
    {
        /// <summary>
        /// Classe cliente
        /// </summary>
        
        #region ATRIBUTOS
        
        // Atributos a dar a cada objeto

        private string nome;
        private int idade;
        private int numero_fiscal;
        private string email;

        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Constroi um Cliente com base nos atributos submetidos
        /// </summary>
        /// <param name="no"></param>
        /// <param name="id"></param>
        /// <param name="NIF"></param>
        /// <param name="em"></param>
        public Cliente(string no, int id, int NIF, string em)
        {
            nome = no;
            idade = id;
            numero_fiscal = NIF;
            email = em;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Métodos publicos para ler e escrevrer nas variaveis
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public int Numero_fiscal
        {
            get { return numero_fiscal; }
            set { numero_fiscal = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region OPERADORES
        #endregion

        #region OVERRIDES

        public override string ToString()
        {
            return String.Format("Cliente: {0}; Idade: {1}; NIF: {2}; Email: {3}", nome.ToUpper(), idade.ToString(), numero_fiscal.ToString(), email);
        }
        #endregion
    }
}
