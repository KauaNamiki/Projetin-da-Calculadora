# 🧮 Console Calculator em C#

Projeto de uma calculadora desenvolvida em **C#** para console, criada com o objetivo de praticar lógica de programação, manipulação de fluxo de controle, tratamento de entradas do usuário e boas práticas de estruturação de código.

---

## 🚀 Tecnologias Utilizadas

* **Linguagem:** C# (.NET)
* **Ambiente:** Console Application (CLI)

---

## ⚙️ Funcionalidades

O programa executa um loop contínuo (menu interativo) onde o usuário pode escolher entre as seguintes operações:

1. **Soma** ($num1 + num2$)
2. **Subtração** ($num1 - num2$)
3. **Multiplicação** ($num1 * num2$)
4. **Divisão** ($num1 / num2$ com tratamento para divisão por zero)
0. **Sair** (Encerra a aplicação)

---

## 🛠️ Arquitetura e Decisões de Código

O código foi modularizado em métodos estáticos (`static`) para garantir legibilidade, separação de responsabilidades e reusabilidade:

* **`Main()`**: Controla o fluxo principal da aplicação utilizando um laço `while (running)` para manter o menu ativo até que o usuário decida sair.
* **`PrintMenu()`**: Responsável por exibir a interface de opções no console com personalização de cores (`ConsoleColor`).
* **`IsInputValid()`**: Faz a validação defensiva da entrada utilizando `int.TryParse` para evitar exceções caso o usuário digite caracteres inválidos.
* **`PrintOperation()`**: Utiliza a expressão avançada **`switch`** do C# para executar a operação matemática correspondente e gerenciar regras de negócio, como a prevenção de divisão por zero.

---

## 📦 Como Executar o Projeto

Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/) instalado em sua máquina.

1. Clone o repositório:
   ```bash
   git clone [https://github.com/KauaNamiki/Projetin-da-Calculadora.git](https://github.com/KauaNamiki/Projetin-da-Calculadora.git)
