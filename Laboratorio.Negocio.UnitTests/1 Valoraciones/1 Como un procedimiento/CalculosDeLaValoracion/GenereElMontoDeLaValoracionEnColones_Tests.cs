using Negocio.Valoraciones.ComoUnProcedimiento;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Negocio.UnitTests.Valoraciones_Tests.ComoUnProcedimiento_Tests
{
    [TestClass]
    public class GenereElMontoDeLaValoracionEnColones_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elMontoNominal;
        private decimal elPorcentajeDeCobertura;
        private decimal elPrecioLimpio;
        private decimal elTipoDeCambio;
        private Monedas elTipoDeMoneda;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void GenereElMontoDeLaValoracionEnColones_NoEsColon_UsaElMontoConvertido()
        {
            decimal elResultadoEsperado = 9049.9860M;

            decimal elMontoNominal = 10000M;
            decimal elPrecioLimpio = 100.5554M;
            decimal elPorcentajeDeCobertura = 0.9M;
            Monedas elTipoDeMoneda = Monedas.UDEs;
            decimal elResultadoObtenido = CalculosDeLaValoracion.GenereElMontoDeLaValoracionEnColones(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElMontoDeLaValoracionEnColones_EsColon_UsaElMontoNominal()
        {
            elResultadoEsperado = 6868534.9510M;

            elTipoDeCambio = 758.19M;
            elMontoNominal = 10000M;
            elPrecioLimpio = 100.6569M;
            elPorcentajeDeCobertura = 0.9M;
            elTipoDeMoneda = Monedas.Colon;
            elResultadoObtenido = CalculosDeLaValoracion.GenereElMontoDeLaValoracionEnColones(elMontoNominal, elTipoDeCambio, elPrecioLimpio, elPorcentajeDeCobertura, elTipoDeMoneda);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}