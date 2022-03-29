<p align="center">
    <a href="#cpf">
        <img alt="logo" src="Assets/logo.png">
    </a>
</p>
<br>

Validação e formatação das documentações brasileiras de CPF e CNPJ.

# Cpf
## Usage

```cs
using CpfCnpjLibrary;

Cpf.Validar("08597471077");    // True
Cpf.Validar("8597471077");     // True (0 à esquerda)
Cpf.Validar("716.603.990-68"); // True
Cpf.Validar("00000000000");    // False
Cpf.Validar("xpto");            // False

Cpf.FormatarComPontuacao("08597471077"); // "085.974.710-77"
Cpf.FormatarComPontuacao("085.974.710-77"); // "085.974.710-77"
Cpf.FormatarComPontuacao("xpto");         // "xpto"

Cpf.FormatarSemPontuacao("085.974.710-77"); // "08597471077"
Cpf.FormatarSemPontuacao("08597471077"); // "08597471077"
Cpf.FormatarSemPontuacao("xpto");         // "xpto"
```
