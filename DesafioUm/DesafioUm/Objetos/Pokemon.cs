namespace DesafioUm.Objetos
{
    public enum PokemonType
    {
         Bug,
         Dark,
         Dragon,
         Electric,
         Fairy,
         Fighting,
         Fire,
         Flying,
         Ghost,
         Grass,
         Ground,
         Ice,
         Normal,
         Poison,
         Psychic,
         Rock,
         Steel,
         Water
    }

    public class Pokemon
    {
        // (PK, int) Id, (FK, int) PessoaId, (int) NumeroPokedex, (string) Nome, (enum*) Tipo, (string) Geracao, (bool) Shiny
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public int NumeroPokedex { get; set; }
        public string Nome {  get; set; }
        public PokemonType Tipo { get; set; }
        public string Geracao { get; set; }
        public bool Shiny { get; set; }

        public Pessoa Pessoa { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome}, Número Pokedex: {NumeroPokedex}, Tipo: {Tipo}, Geração: {Geracao}, Shiny: {Shiny}, PessoaId: {PessoaId}";
        }
    }
}
