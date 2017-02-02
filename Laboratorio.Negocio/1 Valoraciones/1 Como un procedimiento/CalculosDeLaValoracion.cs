using System;

namespace Negocio.Valoraciones.ComoUnProcedimiento
{
    public static class CalculosDeLaValoracion
    {
        public static decimal GenereElMontoDeLaValoracionEnColones(
                    decimal elMontoNominal,
                    decimal elTipoDeCambio,
                    decimal elPrecioLimpio,
                    decimal elPorcentajeDeCobertura,
                    Monedas elTipoDeMoneda)
        {
            decimal elMontoConvertido;
            if (elTipoDeMoneda == Monedas.Colon)
                elMontoConvertido = elMontoNominal * elTipoDeCambio;
            else
                elMontoConvertido = elMontoNominal;

            decimal elValorMercado = elMontoConvertido * (elPrecioLimpio / 100);
            decimal elMontoSinRedondear = elValorMercado * elPorcentajeDeCobertura;

            return Math.Round(elMontoSinRedondear, 4);
        }
    }
}