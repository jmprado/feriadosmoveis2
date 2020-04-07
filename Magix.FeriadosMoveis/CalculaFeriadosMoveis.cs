using System;
using System.Collections.Generic;
using System.Text;

namespace Magix.FeriadosMoveis
{
    internal class CalculaFeriadosMoveis
    {
        #region  Private Fields
        private DateTime _domingoPascoa;
        private DateTime _domingoCarnaval;
        private DateTime _segundaCarnaval;
        private DateTime _tercaCarnaval;
        private DateTime _sextaPaixao;
        private DateTime _corpusChristi;
        #endregion

        #region Properties
        public DateTime DiaPascoa { get { return _domingoPascoa; } }
        public DateTime DomingoCarnaval { get { return _domingoCarnaval; } }
        public DateTime SegundaCarnaval { get { return _segundaCarnaval; } }
        public DateTime TercaCarnaval { get { return _tercaCarnaval; } }
        public DateTime SextaPaixao { get { return _sextaPaixao; } }
        public DateTime CorpusChristi { get { return _corpusChristi; } }
        #endregion

        public CalculaFeriadosMoveis(int Ano)
        {
            _domingoPascoa = CalculaDomingoPascoa(Ano);
            _domingoCarnaval = CalculaDomingoCarnaval(_domingoPascoa);
            _segundaCarnaval = CalculaSegundaCarnaval(_domingoPascoa);
            _tercaCarnaval = CalculaTercaCarnaval(_domingoPascoa);
            _sextaPaixao = CalculaSextaPaixao(_domingoPascoa);
            _corpusChristi = CalculaCorpusChristi(_domingoPascoa);
        }

        /// <summary>
        ///  FUNÇÃO PARA CALCULAR A DATA DO DOMINGO DE PASCOA
        ///  DADO UM ANO QUALQUER
        /// </summary>
        /// <param name="AnoCalcular"></param>
        /// <returns></returns>
        private DateTime CalculaDomingoPascoa(int AnoCalcular)
        {
            int x = 24;
            int y = 5;

            int a = AnoCalcular % 19;
            int b = AnoCalcular % 4;
            int c = AnoCalcular % 7;

            int d = (19 * a + x) % 30;
            int e = (2 * b + 4 * c + 6 * d + y) % 7;

            int dia = 0;
            int mes = 0;

            if (d + e > 9)
            {
                dia = (d + e - 9);
                mes = 4;
            }
            else
            {
                dia = (d + e + 22);
                mes = 3;
            }

            return DateTime.Parse(string.Format("{0},{1},{2}", AnoCalcular.ToString(), mes.ToString(), dia.ToString()));
        }


        private DateTime CalculaDomingoCarnaval(DateTime DataPascoa)
        {
            return DataPascoa.AddDays(-49);
        }

        private DateTime CalculaSegundaCarnaval(DateTime DataPascoa)
        {
            return DataPascoa.AddDays(-48);
        }

        private DateTime CalculaTercaCarnaval(DateTime DataPascoa)
        {
            return DataPascoa.AddDays(-47);
        }

        private DateTime CalculaSextaPaixao(DateTime DataPascoa)
        {
            return DataPascoa.AddDays(-2);
        }

        private DateTime CalculaCorpusChristi(DateTime DataPascoa)
        {
            return DataPascoa.AddDays(+60);
        }
    }
}

