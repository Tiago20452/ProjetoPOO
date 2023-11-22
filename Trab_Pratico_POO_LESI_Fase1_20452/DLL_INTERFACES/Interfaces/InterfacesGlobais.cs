namespace Interfaces
{
    public interface IPropriedade
    {
        int Codpropriedade { get; set; }
        string Nome { get; set; }
        string Tipo { get; set; }
        string Localizacao { get; set; }
        int Agregado { get; set; }
        double Preconoite { get; set; }
        bool Disponibilidade { get; set; }

    }
    public interface IPropriedades 
    {

    }

}
