/*
 * Classe para descrever uma Propriedade
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 6/11/2023
 * POO
 */

using System;
using System.CodeDom;
using Dados;
using BO;

namespace BO
{
    public class Reserva
    {
        /// <summary>
        /// Classe Reserva
        /// </summary>

        #region ATRIBUTOS                               
        /// <summary>
        /// Atributos da classe
        /// </summary>

        private int codreserva;                 // id da reserva
        private DateTime datainicio;            // data de entrada na propriedade
        private double totalnoites;                // numero total de noites a frequentar

        private int nifCliente;                 // nif do cliente a associar à reserva
        private int codigoPropriedade;          // codigo da propriedade a associar à reserva

        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construror da reserva
        /// </summary>
        /// <param name="nifC"></param>
        /// <param name="codigoP"></param>
        /// <param name="codigor"></param>
        /// <param name="data"></param>
        /// <param name="total"></param>

        public Reserva(int nifC, int codigoP, int codigor, DateTime data, double total)
        {
            if (Clientes.ExisteCliente(nifC) && (Propriedades.ExistePropriedade(codigoP)))          // se existir o codigo do cliente
                                                                                                    // e existir o codigo da propriedade
                                                                                                    //cria a reserva
            {
                nifCliente = nifC;
                codigoPropriedade = codigoP;
                codreserva = codigor;
                datainicio = data;
                totalnoites = total;
            }
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// /// Métodos publicos para ler e escrevrer nas variaveis
        /// </summary>
        public int Codreserva
        {
            get { return codreserva; }
            set { codreserva = value; }
        }

        public DateTime Datainicio
        {
            get { return datainicio; }
            set { datainicio = value; }
        }
        public double TotalNoites
        {
            get { return totalnoites; }
            set { totalnoites = value; }
        }

        public int NifCliente
        {
            get { return nifCliente; }
            set { nifCliente = value; }
        }

        public int CodigoPropriedade
        {
            get { return codigoPropriedade; }
            set { codigoPropriedade = value; }
        }
        #endregion

        #region OUTROS METODOS

        public double CalculaPrecoReserva(Reserva r, Propriedade p)
        {
            return p.Preconoite * r.TotalNoites;
        }
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Este método retorna uma string formatada com as informações do objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("\n Reserva: {0};\n ClienteNIF: {1};\n CodigoPropriedade: {2};\n Data inicio: {3}; \n Total noites: {4};"
                  , codreserva.ToString(), NifCliente.ToString(), codigoPropriedade.ToString(), datainicio.ToString(), totalnoites.ToString());
        }
        #endregion
    }
}
