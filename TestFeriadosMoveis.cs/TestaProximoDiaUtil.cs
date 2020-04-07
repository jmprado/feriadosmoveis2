using System;
using Xunit;
using Magix.FeriadosMoveis;

namespace TestFeriadosMoveis.cs
{
    public class TestaProximoDiaUtil
    {
        [Fact]
        public void TestaSabado()
        {
            var dataTest = new DateTime(2020, 1, 25);
            var feriados = new Feriados(2020);

            var resultTest = new DateTime(2020, 1, 27);

            Assert.Equal(resultTest, feriados.ProximoDiaUtil(dataTest));
        }

        [Fact]
        public void TestaDomingo()
        {
            var dataTest = new DateTime(2020, 1, 26);
            var feriados = new Feriados(2020);

            var resultTest = new DateTime(2020, 1, 27);

            Assert.Equal(resultTest, feriados.ProximoDiaUtil(dataTest));
        }

        [Fact]
        public void TestaSabadoCarnaval()
        {
            var dataTest = new DateTime(2020, 2, 22);
            var feriados = new Feriados(2020);

            var resultTest = new DateTime(2020, 2, 26);

            Assert.Equal(resultTest, feriados.ProximoDiaUtil(dataTest));
        }

        [Fact]
        public void TestaProximoDia()
        {
            var dataTest = new DateTime(2020, 1, 20);
            var feriados = new Feriados(2020);

            var resultTest = new DateTime(2020, 1, 21);

            Assert.Equal(resultTest, feriados.ProximoDiaUtil(dataTest));
        }


    }
}
