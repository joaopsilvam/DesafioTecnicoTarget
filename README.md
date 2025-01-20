# **Desafio Técnico - Soluções em C#**

Este projeto contém a implementação de soluções para um conjunto de questões técnicas em C#, organizadas em arquivos separados com estrutura clara e modular.

## **Descrição do Projeto**
O objetivo deste projeto é resolver problemas técnicos variados, utilizando boas práticas de programação em C#. Cada questão foi implementada como um módulo separado, permitindo fácil manutenção e reutilização.

---

## **Questões Resolvidas**

### **1. Soma de Números**
- **Descrição**: Calcula a soma dos números de 1 a N utilizando um loop.
- **Arquivo**: `Questão 1 - Soma.cs`

---

### **2. Verificação na Sequência de Fibonacci**
- **Descrição**: Verifica se um número informado pertence à sequência de Fibonacci.
- **Arquivo**: `Questão 2 - Fibonacci.cs`

---

### **3. Análise de Faturamento Mensal**
- **Descrição**: Processa um arquivo JSON com o faturamento diário de uma distribuidora e retorna:
  - O menor valor de faturamento.
  - O maior valor de faturamento.
  - O número de dias com faturamento acima da média.
- **Arquivo**: `Questão 3 - Faturamento.cs`
- **Dados**: Localizados no arquivo `assets/dados.json`.

---

### **4. Percentual de Faturamento por Estado**
- **Descrição**: Calcula o percentual de participação de cada estado no faturamento total de uma distribuidora.
- **Arquivo**: `Questão 4 - Faturamento Estado.cs`

---

### **5. Inversão de String**
- **Descrição**: Inverte os caracteres de uma string sem usar funções prontas como `Reverse`.
- **Arquivo**: `Questão 5 - Inverter String.cs`

---

## **Como Executar**

### **Requisitos**
- **.NET SDK 8.0** ou superior.
- Biblioteca **Newtonsoft.Json** (usada para manipular arquivos JSON).
  - Instale com:
    ```bash
    dotnet add package Newtonsoft.Json
    ```

### **Passos**
1. Clone o repositório:
   ```bash
   git clone <URL_DO_REPOSITORIO>
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd <DIRETORIO_DO_PROJETO>
   ```
3. Compile e execute o programa:
   ```bash
   dotnet run
   ```
4. Escolha a questão que deseja executar no menu exibido.

---

## **Estrutura do Projeto**
```plaintext
Projeto/
├── assets/
│   └── dados.json         # Dados para a questão 3
├── Program.cs             # Ponto de entrada do projeto
├── Questao1.cs            # Código para a questão 1
├── Questao2.cs            # Código para a questão 2
├── Questao3.cs            # Código para a questão 3
├── Questao4.cs            # Código para a questão 4
└── Questao5.cs            # Código para a questão 5
```

---

## **Contribuição**
Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias e sugestões.

---

## **Licença**
Este projeto está disponível para uso público, com foco educacional e de aprendizado. 😊