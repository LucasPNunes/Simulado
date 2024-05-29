using System;
using System.Collections.Generic;
namespace Simulado
{
    public class TipoTelefone
    {
        public int id { get; set; }
        public string nome { get; set; }

        public TipoTelefone(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public override string ToString()
        {
            return nome.ToString();
        }
    }
}
