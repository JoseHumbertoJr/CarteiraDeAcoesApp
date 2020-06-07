using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraAcoes.Model
{
    public class CarteiraDeAcao
    {
        public string Nome { get;}
        public string Quantidade { get; }
        public string Preco { get; }
        public DateTime Data { get; set; }

        public CarteiraDeAcao(string nome, string qtd, string preco)
        {
            this.Data = DateTime.Now;
            this.Nome = nome;
            this.Quantidade = qtd;
            this.Preco = preco;
        }
        public string NewProperty
        {

            get
            {
                return string.Format(Nome+ "                               "
                    + Quantidade+ "                               "
                    + Preco);
            }
        }
    }
}
