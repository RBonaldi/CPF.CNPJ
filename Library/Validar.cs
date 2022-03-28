namespace CpfCnpjLibrary
{
    using System.Linq;
    using System.Text.RegularExpressions;

    public static partial class Cpf
    {
		private static string RemoverCaracteresEspeciais(string numero)
		{
			return Regex.Replace(numero, "[^0-9a-zA-Z]+", "");
		}

		private static string ZeroEsquerda(string numero, int qtdValorCompleto)
		{
			numero = numero.PadLeft(qtdValorCompleto, '0');

			return numero;
		}

		private static bool ValidarNumerico(string numero)
		{
			if (numero.All(char.IsDigit))
				return true;

			return false;
		}

		private static bool NumerosIguais(string numero)
		{
			char comparar = numero.ToString()[0];
			foreach (var n in numero.ToString())
			{
				if (comparar != n)
					return false;
			}
			return true;
		}
	}
}
