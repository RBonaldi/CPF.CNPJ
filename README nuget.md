Validação e formatação das documentações brasileiras de CPF e CNPJ.

# Cpf

```cs
using CpfCnpjLibrary;

Cpf.Validar("08597471077");     // True
Cpf.Validar("8597471077");      // True (0 à esquerda)
Cpf.Validar("716.603.990-68");  // True
Cpf.Validar("00000000000");     // False
Cpf.Validar("xpto");            // False

Cpf.FormatarComPontuacao("08597471077");    // "085.974.710-77"
Cpf.FormatarComPontuacao("085.974.710-77"); // "085.974.710-77"
Cpf.FormatarComPontuacao("xpto");           // "xpto"

Cpf.FormatarSemPontuacao("085.974.710-77"); // "08597471077"
Cpf.FormatarSemPontuacao("08597471077");    // "08597471077"
Cpf.FormatarSemPontuacao("xpto");           // "xpto"

```

# Cnpj
```cs

using CpfCnpjLibrary;

Cnpj.Validar("00358823000193");      // True
Cnpj.Validar("358823000193");        // True (0 à esquerda)
Cnpj.Validar("00.358.823/0001-93");  // True
Cnpj.Validar("00000000000000");      // False
Cnpj.Validar("xpto");                // False

Cnpj.FormatarComPontuacao("00358823000193");     // "00.358.823/0001-93"
Cnpj.FormatarComPontuacao("00.358.823/0001-93"); // "00.358.823/0001-93"
Cnpj.FormatarComPontuacao("xpto");               // "xpto"

Cnpj.FormatarSemPontuacao("00.358.823/0001-93"); // "00358823000193"
Cnpj.FormatarSemPontuacao("358823000193");       // "00358823000193"
Cnpj.FormatarSemPontuacao("xpto");               // "xpto"

```
