/*
 * Classe para descrever um array de Propriedades
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 10/11/2023
 * POO
 */

using System;
using BO;
using Interfaces;

namespace Dados
{
    public class Propriedades //: IPropriedades
    {
        /// <summary>
        /// Classe Propriedades(Array)
        /// </summary>
        #region ATRIBUTOS

        const int MAXPROPRIEDADES = 100;                //constante inteira de nr máximo de propriedades
        static Propriedade[] listapropriedades;         // array/variável estática que toda a classe irá utilizar 
        static int totPropriedades;                     // variavel pertencente à classe

        #endregion

        #region CONSTRUTORES

        /// <summary>
        /// Construtor do array
        /// </summary>
        static Propriedades()
        {
            totPropriedades = 0;                                                //define a variavel para valor 0
            listapropriedades = new Propriedade[MAXPROPRIEDADES];               // Cria um array de objetos que permite armazenar até 100 propriedades
        }
        #endregion
        
        #region PROPRIEDADES

        /// Método que devolve uma cópia clonada do array 
        public static Propriedade[] ListaPropriedades
        {
            get { return (Propriedade[])listapropriedades.Clone(); }
        }

        public static int TotalPropriedades
        {
            get { return totPropriedades; }
        }

        #endregion

        #region OUTROS METODOS

        // Metodo que exibe os codigos das propriedades presentes no array
        public static void ShowPropriedades(Propriedade[] lista)
        {
            for (int i = 0; i < lista.Length; i++)                                  //inicia um loop sobre todos os elementos do array
            {
                if (lista[i] == null) continue;                                     //verifica se o elemento do array é nulo, caso seja avança para o próximo
                Console.WriteLine("Propriedade: {0}", lista[i].Codpropriedade);     // imprime na consola os codigos de propriedades existentes
            }
        }

        // Método que verifica a existência de uma Propriedade
        public static bool ExistePropriedade(int cod)
        {
            foreach (Propriedade p in listapropriedades)        // procura um objeto no array (lista propriedades)
            {
                if (p != null && p.Codpropriedade == cod)       // caso o codigo fornecido esteja na lista então devolve "true"
                {
                    return true;                                // Código já existe
                }
            }
            return false;                                       // Código não existe
        }

        // Método para registar uma propriedade no array
        public static bool InserirPropriedade(Propriedade p)
        {
            
            if (!ExistePropriedade(p.Codpropriedade))            // Verifica se o código já existe
            {
                listapropriedades[totPropriedades] = p;         // adiciona o objeto p no array 
                totPropriedades++;                              // incrementa o contador de propriedades
                return true;                                   // Código já existe, a propriedade não foi adicionada
            }
            else                                                // Caso exista o código
            {
                return false;
            }
        }


        public static bool Verificadisponibilidade(Propriedade p)       //não está implementado
        {
            if (p.Estadodisp == Propriedade.EstadoDisponibilidade.Disponivel)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
