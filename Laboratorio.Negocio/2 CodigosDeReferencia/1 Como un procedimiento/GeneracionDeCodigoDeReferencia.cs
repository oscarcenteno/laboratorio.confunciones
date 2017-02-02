using System;

namespace Negocio.CodigosDeReferencia.ComoUnProcedimiento
{
    public static class GeneracionDeCodigoDeReferencia
    {
        public static string GenereElRequerimientoComoTexto(DateTime laFecha, short elCliente, short elSistema, string elConsecutivo)
        {
            int elAño = laFecha.Year;
            string elAñoAjustado = elAño.ToString("D4");

            int elMes = laFecha.Month;
            string elMesAjustado = elMes.ToString("D2");

            int elDia = laFecha.Day;
            string elDiaAjustado = elDia.ToString("D2");

            string laFechaFormateada = elAñoAjustado + elMesAjustado + elDiaAjustado;
            string elClienteAjustado = elCliente.ToString("D3");
            string elSistemaAjustado = elSistema.ToString("D2");
            string elConsecutivoAjustado = elConsecutivo.PadLeft(12, '0');

            return laFechaFormateada + elClienteAjustado + elSistemaAjustado + elConsecutivoAjustado;
        }
    }
}