namespace CpfCnpjLibrary
{
    using System.Linq;

    public static partial class Cnpj
    {
        public static string FormatarComPontuacao(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            string v = RemoverCaracteresEspeciais(s);
            if (!ValidarNumerico(v))
                return s;

            s = RemoverCaracteresEspeciais(s);
            s = ZeroEsquerda(s, 14);
            return s == null || s.Length != 11 || s.Any(c => !char.IsDigit(c)) ? s :
                new string(new[] { s[0], s[1], '.', s[2], s[3], s[4], '.', s[5], s[6], s[7], '/', s[8], s[9], s[10], s[11], '-', s[12], s[13] });
        }

        public static string FormatarSemPontuacao(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            string v = RemoverCaracteresEspeciais(s);
            if (!ValidarNumerico(v))
                return s;

            s = RemoverCaracteresEspeciais(s);
            return ZeroEsquerda(s, 14);
        }
    }
}
