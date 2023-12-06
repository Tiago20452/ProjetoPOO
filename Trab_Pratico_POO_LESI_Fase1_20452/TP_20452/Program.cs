/*
 * Consola para fazer testes de funcionamento
 * Tiago Afonso
 * a20452@alunos.ipca.pt
 * 15/11/2023
 * POO
 */

using System;
using Dados;
using BO;
using RegrasNegocio;
using Interfaces;

namespace TP_20452

{
    public class Program
    {
        static void Main(string[] args)
        {

            //Gestor f = new Gestor("João", 123456789);
            //Console.WriteLine(f.ToString());

            DateTime datac1 = new DateTime(2000, 12, 25);
            Cliente c1 = new Cliente("Tiago", datac1, 256001642, "tiafonso95@hotmail.com");
            Clientes.InsereCliente(c1);
            int idade = c1.CalculaIdade();
            Console.WriteLine("Idade do cliente: {0} ",idade);
            //Console.WriteLine("Inserido! Total de Clientes: {0}", Clientes.TotalClientes);
            Console.WriteLine(c1.ToString());

            Clientes.ShowClientes(Clientes.Listaclientes);

            Console.ReadLine();

            Propriedade p1 = new Propriedade(345, "Quinta da capela", "Casa rural", "Gerês", 3, 123.99, Propriedade.EstadoDisponibilidade.Indisponivel);
            Propriedades.InserirPropriedade(p1);
            //Console.WriteLine("Inserido! Total Propriedades {0}", Propriedades.TotalPropriedades);
            Console.WriteLine(p1.ToString());

            Propriedades.ShowPropriedades(Propriedades.ListaPropriedades);
            Console.ReadLine();

            DateTime reserva1 = new DateTime(2023, 11, 15);
            Reserva r1 = new Reserva(256001642, 345, 123, reserva1, 10);
            Console.WriteLine(r1.ToString());
            Console.ReadLine();

            Reservas.InserirReserva(r1);
            Reservas.ShowReservas(Reservas.ListaReservas);
            Console.ReadLine();

            Check_in cn1 = new Check_in(1,123, DateTime.Now);
            Console.WriteLine(cn1.ToString());
            Console.ReadLine();

            Check_ins.InserirCheckin(cn1);
            Check_ins.ShowCheckins(Check_ins.ListaCheckins);
            Console.ReadLine();

        }
    }

}
