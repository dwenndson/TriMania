namespace Dominio.Entidades
{
    public class Categoria :  EntidadeBase
    {
        public Categoria(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        protected Categoria() { }
        public int Codigo { get; protected set; }
        public string Descricao { get; protected set; }
    }
}
