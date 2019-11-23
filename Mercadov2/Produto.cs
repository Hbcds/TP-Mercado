using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadov2
{
    class Produto
    {
        private string nome;
        private double preco;
        private double codBarras;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public double CodBarras { get => codBarras; set => codBarras = value; }

    }
}
