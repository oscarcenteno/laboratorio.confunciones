using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.CodigosDeReferencia.ConFunciones;

namespace Negocio.UnitTests.CodigosDeReferencia_Tests.ConFunciones_Tests
{
    [TestClass()]
    public class GenereElRequerimientoComoTexto_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DateTime laFecha;
        private short elCliente;
        private short elSistema;
        private string elConsecutivo;

        [TestInitialize()]
        public void Inicialice()
        {
            laFecha = new DateTime(2000, 11, 11);
            elCliente = 333;
            elSistema = 22;
            elConsecutivo = "888888888888";
        }


        [TestMethod()]
        public void GenereElRequerimientoComoTexto_ClienteTieneMenosDigitos_PrecedeConCero()
        {
            elResultadoEsperado = "2000111103322888888888888";

            elCliente = 33;
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElRequerimientoComoTexto(laFecha, elCliente, elSistema, elConsecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_SistemaTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "2000111133302888888888888";

            elSistema = 2;
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElRequerimientoComoTexto(laFecha, elCliente, elSistema, elConsecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_MesTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "2000011133322888888888888";

            laFecha = new DateTime(2000, 1, 11);
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElRequerimientoComoTexto(laFecha, elCliente, elSistema, elConsecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_DiaTieneUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "2000110133322888888888888";

            laFecha = new DateTime(2000, 11, 1);
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElRequerimientoComoTexto(laFecha, elCliente, elSistema, elConsecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElRequerimientoComoTexto_ConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elResultadoEsperado = "2000111133322000000000004";

            elConsecutivo = "4";
            elResultadoObtenido = GeneracionDeCodigoDeReferencia.GenereElRequerimientoComoTexto(laFecha, elCliente, elSistema, elConsecutivo);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}