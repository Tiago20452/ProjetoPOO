using System;

namespace Gestaoturistica
{
    public class Check_ins
    {
        #region ATRIBUTOS

        const int MAXCHECKINS = 100;
        static Check_in[] listacheckins;
        static int totCheckins;

        #endregion

        #region CONSTRUTORES

        static Check_ins()
        {
            totCheckins = 0;
            listacheckins = new Check_in[MAXCHECKINS];
        }
        #endregion

        #region PROPRIEDADES

        public static Check_in[] ListaCheckins
        {
            get { return (Check_in[])listacheckins.Clone(); }
        }

        public static int TotalCheckins
        {
            get { return totCheckins; }
        }

        #endregion

        #region OUTROS METODOS


        public static void ShowCheckins(Check_in[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == null) continue;
                Console.WriteLine("Check_in: {0}", lista[i].Codcheckin);
            }
        }


        public static bool ExisteCheckin(int cod)
        {
            foreach (Check_in cni in listacheckins)
            {
                if (cni != null && cni.Codcheckin == cod)
                {
                    return true; // Código já existe
                }
            }
            return false; // Código não existe
        }

        public static bool InserirCheckin(Check_in cni)
        {
            // Verifica se o código já existe
            if (!ExisteCheckin(cni.Codcheckin))
            {
                listacheckins[totCheckins] = cni;
                totCheckins++;
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
