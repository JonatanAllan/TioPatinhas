using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TioPatinhasRecursos.Utilidades
{
    public static class FormatadorValores
    {
        public static double ConverterDuasCasasDecimais(double? valor)
        {
            var valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", Convert.ToDouble(valor));
            return Convert.ToDouble(valorFormatado);
        }

        public static string RemoverQuebraLinha(string valor)
        {
            return Regex.Replace(valor.Trim(), @"\r\n?|\r|\n|\t|\0", "");
        }

        /// <summary>
        /// Normaliza nomes para url e nomes de arquivos
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ConverterParaUrl(this string s)
        {
            s = string.Join(string.Empty, s.Normalize(NormalizationForm.FormD).Where(c =>
                         CharUnicodeInfo.GetUnicodeCategory(c) !=
                         UnicodeCategory.NonSpacingMark)).ToLower().Trim();
            s = Regex.Replace(s, "[^a-zA-Z0-9_]+", "-");
            return s;
        }

        /// <summary>
        /// Mascarar CpfCnpj
        /// </summary>
        /// <param name="cpfCnpj"></param>
        /// <returns></returns>
        public static string MascararCpfCnpj(string cpfCnpj)
        {
            var result = cpfCnpj ?? string.Empty;
            switch (result.Length)
            {
                case 14:
                    result = $@"{long.Parse(result):00\.000\.000\/0000\-00}";
                    break;
                case 11:
                    result = $@"{long.Parse(result):000\.000\.000\-00}";
                    break;
            }

            return result;
        }

        /// <summary>
        /// Mascarar Numero de Teleforne
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string MascararTelefone(string numero)
        {
            var resultado = numero ?? string.Empty;
            switch (resultado.Length)
            {
                case 11:
                    resultado = $@"{long.Parse(resultado):\(00\) 00000\-0000}";
                    break;
                case 10:
                    resultado = $@"{long.Parse(resultado):\(00\) 0000\-0000}";
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Obterm o mês por extenso
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public static string ObterMesExtenso(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Janeiro";
                case 2:
                    return "Fevereiro";
                case 3:
                    return "Março";
                case 4:
                    return "Abril";
                case 5:
                    return "Maio";
                case 6:
                    return "Junho";
                case 7:
                    return "Julho";
                case 8:
                    return "Agosto";
                case 9:
                    return "Setembro";
                case 10:
                    return "Outubro";
                case 11:
                    return "Novembro";
                case 12:
                    return "Dezembro";
                default:
                    return "";
            }
        }

        /// <summary>
        /// Obtem o dia da semana por extenso
        /// </summary>
        /// <param name="diaSemana"></param>
        /// <returns></returns>
        public static string ObterDiaSemanaExtenso(DayOfWeek diaSemana)
        {
            switch (diaSemana)
            {
                case DayOfWeek.Sunday:
                    return "Domingo";
                case DayOfWeek.Monday:
                    return "Segunda-Feira";
                case DayOfWeek.Tuesday:
                    return "Terça-Feira";
                case DayOfWeek.Wednesday:
                    return "Quarta-Feira";
                case DayOfWeek.Thursday:
                    return "Quinta-Feira";
                case DayOfWeek.Friday:
                    return "Sexta-Feira";
                case DayOfWeek.Saturday:
                    return "Sábado";
                default:
                    return "";
            }
        }
    }
}