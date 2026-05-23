🧮 Calculadora Inteligente com Histórico (VB.NET Windows Forms)
Status do Projeto: 🚀 Concluído & Estável

Este é um projeto de uma calculadora desktop desenvolvida em Visual Basic .NET (Windows Forms). O grande foco do desenvolvimento, além de realizar as operações aritméticas tradicionais, foi a implementação de mecanismos robustos de validação de dados e gestão de fluxos, garantindo que a aplicação seja altamente estável, intuitiva e imune a falhas por utilização incorreta (crash-proof).

🛠️ Arquitetura e Funcionamento
O projeto foi estruturado com foco na experiência do utilizador (UX) e na integridade da memória da aplicação. Os pontos principais da implementação dividem-se em quatro pilares:

1. Operações Básicas e Continuidade de Contas
Operações Nativas: Suporte completo para Soma (+), Subtração (-), Multiplicação (x) e Divisão (/).

Fluxo Inteligente de Display: Implementação de uma variável de controlo (limparDisplay do tipo Boolean).

Se o utilizador carregar em = e começar a digitar um número novo, o ecrã limpa-se automaticamente.

Se após o = o utilizador clicar num operador (ex: +), o código deteta o estado e continua a conta dinamicamente a partir do resultado atual.

2. Validações e Prevenção de Erros (Os "Seguranças" do Código)
Para evitar comportamentos inesperados ou quebras na aplicação, foram criadas camadas de validação por código:

Controlo de Vírgulas: Impede a inserção de duas vírgulas seguidas. Caso o ecrã esteja vazio e o utilizador prima a vírgula, o sistema injeta automaticamente 0,.

Proteção contra Divisão por Zero: Uma validação lógica interseta a operação antes do cálculo, exibindo uma MessageBox de aviso ao utilizador.

Limite de Caracteres Restrito: O ecrã foi configurado como ReadOnly (bloqueando inputs diretos do teclado). Via código, o limite foi fixado em 5 dígitos (ou 6, se incluir a vírgula), disparando um alerta visual caso o limite seja ultrapassado.

Bloqueio de Operadores Consecutivos: Bloqueia cliques acidentais em múltiplos operadores seguidos (ex: carregar em + e logo a seguir em -), protegendo as variáveis guardadas na memória.

3. Sistema de Histórico Dinâmico (Form2)
Uma das mecânicas mais refinadas do projeto foi a gestão de múltiplas janelas sem duplicação de memória:

Centralização de Dados: Para evitar a perda de dados ou erros ao tentar enviar inputs para uma janela fechada, todos os cálculos são armazenados numa lista global dentro do Form1.

Sincronização em Tempo Real: Ao clicar no botão com o ícone de relógio, o Form2 é instanciado. O código utiliza a coleção Application.OpenForms para verificar se a janela está aberta; se estiver, atualiza o histórico em tempo real a cada =.

Persistência Volátil: Se o utilizador fechar a janela do histórico no "X" e a reabrir mais tarde, os dados reaparecem intactos porque nunca deixaram o Form1.

4. Interface Visual e Menus Extras (UI/UX)
Visual Moderno: Desenho de interface com uma paleta de cores em Dark Mode e botões arredondados para um aspeto visual clean.

MenuStrip de Controlo: Barra de menu superior contendo:

Opção para fechar a aplicação (com acionamento de uma caixa de diálogo a pedir confirmação de saída).

Menu "Info" com os créditos do desenvolvedor.

💻 Tecnologias Utilizadas
Linguagem: Visual Basic .NET (VB.NET)

Tecnologia Desktop: Windows Forms (.NET Framework)

IDE: Visual Studio 2022

📂 Como Executar o Projeto
Clona este repositório para a tua máquina:

Bash
git clone https://github.com/leandro0109/Calculadora-VBForms.git
Abre o Visual Studio.

Importa e abre o ficheiro de solução (.sln).

Prime F5 (ou clica em Start/Iniciar) para compilar e executar o projeto.

Projeto desenvolvido com propósitos académicos e de consolidação de lógica de programação, tratamento de exceções e UI/UX em ambiente desktop.
