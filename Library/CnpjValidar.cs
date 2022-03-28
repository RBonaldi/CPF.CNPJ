using System.Linq;
using System.Text.RegularExpressions;

namespace CpfCnpjLibrary
{
    public static partial class Cnpj
	{
		public static bool Validar(string cnpj)
		{
			if (string.IsNullOrWhiteSpace(cnpj))
				return false;

			cnpj = RemoverCaracteresEspeciais(cnpj);

			if (!ValidarNumerico(cnpj))
				return false;

			cnpj = ZeroEsquerda(cnpj, 14);

			if (NumerosIguais(cnpj))
				return false;

			int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			int soma;
			int resto;
			string digito;
			string tempCnpj;
			cnpj = cnpj.Trim();
			if (cnpj.Length != 14)
				return false;
			tempCnpj = cnpj.Substring(0, 12);
			soma = 0;
			for (int i = 0; i < 12; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
				soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
			resto = (soma % 11);
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cnpj.EndsWith(digito);
		}

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
