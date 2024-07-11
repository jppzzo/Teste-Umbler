#Teste 2 Umbler

Passo 1 - Baixar o Repositório
Clone o repositório para o seu ambiente local: git clone https://github.com/jppzzo/Teste-Umbler.git

Passo 2 - Verificar Versão do .NET
No terminal, verifique a versão do .NET instalada: dotnet --version

Passo 3 - Se nāo reconhecer o comando, realizar a instalaçāo SDK .NET https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-8.0.302-macos-arm64-installer

Passo 4 - Abrir o Projeto no Visual Studio Code

Passo 5 - Compilar e Executar o Projeto com os seguintes comandos:
dotnet build //comando utilizado para compilaçāo da aplicação 
dotnet run //comando para rodar o projeto compilado

--------------------------------------------------------------------
Passo 2 - WEB
Ao iniciar o projeto no localhost, siga os passos abaixo para criar e gerenciar transações.

Criar Transação
 - Adicione o nome do titular.
 - Adicione 11 números do cartão de crédito.
 - Adicione 3 números para o CVV.
 - Insira o valor da transação.
Capturar Transação
 - Copie o "paymentId" da transação criada.
 - Adicione o "paymentId" junto com o valor correto.
Cancelar Transação
 - Adicione apenas o "paymentId" da transação.
