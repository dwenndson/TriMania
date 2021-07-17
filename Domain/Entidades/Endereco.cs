using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class EnderecoEntity
    {
        public EnderecoEntity(string rua, string bairro, string numero, string cidade, string estado)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
        }

        public string Rua { get; protected set; }
        public string Bairro { get; protected set; }
        public string Numero { get; protected set; }
        public string Cidade { get; protected set; }
        public string Estado { get; protected set; }
    }
}
