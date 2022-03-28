<p align="center">
    <a href="#cpf">
        <img alt="logo" src="Assets/logo.png">
    </a>
</p>

# Cpf

[![][build-img]][build]
[![][nuget-img]][nuget]

Validação e formatação das documentações brasileiras de CPF e CNPJ.

## Usage

```cs
using CpfLibrary;

Cpf.Check("29594421134");    // True
Cpf.Check("488.081.131-91"); // True
Cpf.Check("00000000000");    // False
Cpf.Check("lol");            // False

Cpf.Format("29594421134"); // "295.944.211-34"
Cpf.Format("lol");         // "lol"
```
