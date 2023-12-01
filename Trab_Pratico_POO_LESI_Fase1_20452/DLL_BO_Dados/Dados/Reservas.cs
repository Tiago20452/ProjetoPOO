/*
 * Classe para descrever uma Propriedade
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 6/11/2023
 * POO
 */

using System;
using BO;
using Interfaces;

namespace Dados

{
    public class Reservas     // Métodos idênticos à classe Propriedades...
    {
        #region ATRIBUTOS

        const int MAXRESERVAS = 100;
        static Reserva[] listareservas;
        static int totReservas;

        #endregion

        #region CONSTRUTORES

        static Reservas()
        {
            totReservas = 0;
            listareservas = new Reserva[MAXRESERVAS];
        }
        #endregion

        #region PROPRIEDADES

        public static Reserva[] ListaReservas
        {
            get { return (Reserva[])listareservas.Clone(); }
        }

        public static int TotalReservas
        {
            get { return totReservas; }
        }

        #endregion

        #region OUTROS METODOS


        public static void ShowReservas(Reserva[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == null) continue;
                Console.WriteLine("Reserva: {0}", lista[i].Codreserva);
            }
        }


        public static bool ExisteReserva(int cod)
        {
            foreach (Reserva r in listareservas)
            {
                if (r != null && r.Codreserva == cod)
                {
                    return true; // Código já existe
                }
            }
            return false; // Código não existe
        }

        public static bool InserirReserva(Reserva r)
        {
            // Verifica se o código já existe
            if (!ExisteReserva(r.Codreserva))
            {
                listareservas[totReservas] = r;
                totReservas++;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}

