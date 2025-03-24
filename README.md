# 📘 Lista de Exercícios em C#

Este repositório contém uma série de exercícios em **C#** para aprimorar a lógica de programação. Os exercícios estão divididos em diferentes categorias, como: **Entrada, Processamento e Saída de Dados**, **Estruturas de Decisão** e **Estruturas de Repetição.**

## 📌 Sumário

1. [Cálculos Matemáticos](#1️⃣-cálculos-matemáticos)
2. [Estruturas de Decisão](#2️⃣-estruturas-de-decisão)
3. [Estruturas de Repetição](#3️⃣-estruturas-de-repetição)

---

## 1️⃣ Cálculos Matemáticos

### 1. Cálculo do Volume de uma Caixa Retangular
- Solicita largura, altura e profundidade de uma caixa.
- Calcula o volume utilizando a fórmula: **Volume = largura * altura * profundidade**.

### 2. Cálculo do Volume de um Cilindro
- Solicita raio e altura do cilindro.
- Utiliza a fórmula: **Volume = π * raio^2 * altura**.

### 3. Cálculo de Consumo de Combustível
- Solicita quilometragem inicial e final, além da quantidade de combustível consumida.
- Calcula o consumo médio: **Consumo = (km final - km inicial) / litros consumidos**.

### 4. Conversão de Temperatura
- Converte um valor de temperatura de Celsius para Fahrenheit utilizando a fórmula: **F = (C * 9/5) + 32**.

### 5. Cálculo do Salário Total de um Vendedor
- Solicita salário base, total de vendas e percentual de comissão.
- Calcula o salário total considerando a comissão.

### 6. Média Harmônica das Notas de um Aluno
- Calcula a média harmônica de um conjunto de notas.

### 7. Média Ponderada de Duas Provas
- Solicita notas e pesos de duas provas.
- Aplica a fórmula: **Média Ponderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2)**.

### 8. Verifica se um Número é Primo
- Lê um número e verifica se ele é primo.

### 9. Cálculo da Área de um Terreno Retangular
- Solicita largura e comprimento de um terreno.
- Calcula a área utilizando: **Área = largura * comprimento**.

### 10. Cálculo do Faturamento de uma Padaria
- Solicita a quantidade de pães e broas vendidas.
- Calcula o total arrecadado e quanto deve ser guardado na poupança (10%).

### 11. Cálculo dos Dias de Vida
- Solicita nome e idade da pessoa.
- Calcula quantos dias a pessoa já viveu considerando 365 dias por ano.

### 12. Cálculo de Salário com Aumento e Imposto
- Aplica um aumento de 15% e desconta 8% de impostos no salário informado.

---

## 2️⃣ Estruturas de Decisão

### 13. Soma ou Multiplica Dois Valores
- Se **A** e **B** forem iguais, soma os dois.
- Caso contrário, multiplica.

### 14. Verifica se um Número é Par ou Ímpar
- Lê um número e verifica se é par ou ímpar.

### 15. IMC - Índice de Massa Corporal
- Solicita peso e altura.
- Calcula o IMC e classifica de acordo com a tabela da OMS.

### 16. Ordena Três Valores Inteiros em Ordem Decrescente
- Recebe três números diferentes e os exibe em ordem decrescente.

### 17. Soma de Dois Valores e Comparar com um Terceiro
- Lê três valores **A, B, C** e verifica se **A + B** é menor que **C**.

---

## 3️⃣ Estruturas de Repetição

### 18. Impressão de Números Ímpares de 100 a 200
- Gera e exibe todos os números ímpares entre 100 e 200.

### 19. Soma de Todos os Ímpares Múltiplos de Três (1 a 500)
- Soma todos os números ímpares múltiplos de 3 no intervalo de 1 a 500.

### 20. Tabuada de um Número
- Solicita um número de **1 a 10** e exibe sua tabuada de 0 a 10.

### 21. Cálculo do Fatorial de um Número
- Exibe a sequência do cálculo fatorial de um número informado.

### 22. Sequência de Fibonacci
- Lê um número **N** e imprime a sequência de Fibonacci até esse valor.

### 23. Jogo FizzBuzz
- Imprime números de 1 a 100.
- Substitui múltiplos de 3 por "Fizz", de 5 por "Buzz" e de ambos por "FizzBuzz".

---

## 🛠 Como utilizar:
🚀 Passo a Passo

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project ListaDeAtividades.ConsoleApp
```
6. Para executar o arquivo compilado, navegue até a pasta: ./ListaDeAtividades.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:
```
ListaDeAtividadesConsoleApp1.exe
```

## ✅ Requisitos
.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.