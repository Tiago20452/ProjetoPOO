/*
 * Classe para descrever um Cliente
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 03/11/2023
 * POO
 */

using System;
using BO;
using Interfaces;

namespace Dados
{
    public class Clientes //: IClientes                   // Métodos idênticos à classe Propriedades...
    {
        #region ATRIBUTOS

        const int MAXCLIENTES = 100;
        static Cliente[] listaclientes;
        static int totClientes;

        #endregion

        #region CONSTRUTORES
        /// <summary>
        /// Construtor da Classe Cliente
        /// </summary>

        static Clientes()
        {
            totClientes = 0;
            listaclientes = new Cliente[MAXCLIENTES];
        }
        #endregion

        #region PROPRIEDADES


        /// <summary>
        /// Devolve o conjunto de clientes existentes
        /// </summary>
        public static Cliente[] Listaclientes
        {
            get { return (Cliente[])listaclientes.Clone(); }
        }

        public static int TotalClientes
        {
            get { return totClientes; }
        }

        #endregion

        #region OUTROS METODOS

        //private void ShowClientes()
        //{
        //    for (int i = 0; i < listaclientes.Length; i++)
        //    {
        //        Console.WriteLine("Cliente: {0}", listaclientes[i].Numero_fiscal);
        //    }
        //}
        public static void ShowClientes(Cliente[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == null) continue;
                Console.WriteLine("Clientes: {0}", lista[i].Numero_fiscal);
            }
        }

        public static bool ExisteCliente(int NIF)
        {
            foreach (Cliente c in listaclientes)
            {
                if (c != null && c.Numero_fiscal == NIF)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool InsereCliente(Cliente c)
        {
            if (!ExisteCliente(c.Numero_fiscal))
            {
                listaclientes[totClientes] = c;
                totClientes++;
                return true;
            }
            else
                return false;
        }
        #endregion
    }
}
