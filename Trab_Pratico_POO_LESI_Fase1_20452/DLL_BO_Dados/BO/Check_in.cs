using System;
using BO;
using Dados;

namespace BO
{
    public class Check_in
    {
        /// <summary>
        /// Classe Check in
        /// </summary>

        #region ATRIBUTOS                               
        /// <summary>
        /// Atributos da classe
        /// </summary>

        private int codcheckin;                  // codfigo Check_in
        private int codigoReserva;               // codigo da reserva a adicionar 
        private DateTime dataentrada;            // data de entrada na propriedade

        #endregion

        #region CONSTRUTORES

        public Check_in(int codCIN, int codigoR, DateTime data)
        {
            if (Reservas.ExisteReserva(codigoR))
            {
                codcheckin = codCIN;
                codigoReserva = codigoR;
                dataentrada = data;
            }
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// /// Métodos publicos para ler e escrevrer nas variaveis
        /// </summary>
        public int Codcheckin
        {
            get { return codcheckin; }
            set { codcheckin = value; }
        }

        public DateTime Dataentrada
        {
            get { return dataentrada; }
            set { dataentrada = value; }
        }
        public int CodigoReserva
        {
            get { return codigoReserva; }
            set { codigoReserva = value; }
        }

        #endregion

        #region OVERRIDES
        /// <summary>
        /// Este método retorna uma string formatada com as informações do objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("\n Check_in número: {0};\n Código da reserva: {1};\n Data de entrada: {2};\n",
                codcheckin.ToString(), codigoReserva.ToString(), dataentrada.ToString());

        }
        #endregion
    }
}
