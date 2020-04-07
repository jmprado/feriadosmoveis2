using System;
using System.Collections.Generic;
using System.Text;

namespace Magix.FeriadosMoveis
{
    public class Feriado
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public Feriado(DateTime DataFeriado, string Descricao)
        {
            this.Data = DataFeriado;
            this.Descricao = Descricao;
        }
    }
}