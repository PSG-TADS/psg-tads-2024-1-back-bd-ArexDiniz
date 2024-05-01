# Relatório Sistema de Locadora de Veículos

## Participantes
- Alex Gonçalves Diniz
# Introdução

O sistema de gerenciamento proposto será utilizado pela equipe da LoCar em suas operações diárias. Ele proporcionará uma visão abrangente do negócio, permitindo uma melhor tomada de decisões e uma gestão mais eficiente dos recursos disponíveis.

## Problema

A LoCar enfrenta dificuldades na gestão de seu negócio devido à falta de um sistema informatizado eficiente. As operações manuais resultam em erros na contagem de veículos disponíveis, atrasos na identificação de reservas e dificuldades na análise de desempenho do negócio.

## Objetivos

Desenvolver um sistema de gerenciamento para a LoCar que permita automatizar e otimizar suas operações. O sistema deve ser capaz de gerenciar o cadastro de veículos disponíveis para locação, clientes, reservas e registros de locações. Além disso, deve fornecer funcionalidades para o controle de estoque, disponibilidade de veículos, preços e demais informações relevantes.
## Justificativa

A implementação de um sistema de gerenciamento para a LoCar se faz necessária devido a uma série de desafios e limitações enfrentadas pela empresa em suas operações manuais.

Otimização de processos: Atualmente, a LoCar opera de forma manual, o que resulta em ineficiências na gestão de estoque, no atendimento aos clientes e no registro de locações. Um sistema informatizado permitirá automatizar esses processos, aumentando a eficiência e reduzindo possíveis erros humanos.<br>
Controle de estoque e disponibilidade: O sistema de gerenciamento possibilitará à LoCar ter um controle mais preciso sobre seu estoque de veículos e sua disponibilidade para locação. Isso permitirá uma melhor gestão dos recursos da empresa e uma maior capacidade de atender à demanda dos clientes.<br>
## Público-Alvo

A aplicação será utilizada por diferentes perfis de usuários, cada um com suas próprias necessidades e níveis de experiência em tecnologia. Abaixo estão os principais grupos de usuários identificados:

Administradores da LoCar:<br>
Este grupo é composto por funcionários responsáveis pela gestão e administração da locadora de veículos.
Utilizarão o sistema para gerenciar o estoque de veículos<br>
Atendentes
Utilizarão o sistema para registrar novas locações, consultar a disponibilidade de veículos, emitir recibos e gerenciar reservas.
# Especificações do Projeto

## Tecnologias Utilizadas
- IDE: Visual Studio Community-
- C#
- ASPNET Core
- Entity Framework
- Swagger
- Ambiente SQL: SQL Server Manager Studio
- Repositório: Github

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Atendente  | Cadastrar uma reserva       | Ficar registrado no sistema e não esquecer             |
|Administrador       | Cadastrar novo veiculo              | Permitir que possam reserva-lo |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID      | Descrição do Requisito                                     | Prioridade |
|---------|-------------------------------------------------------------|------------|
| RF-001  | O sistema deve permitir o cadastro de clientes              | ALTA       |
| RF-002  | O sistema deve permitir visualizar, atualizar e excluir informações de clientes existentes | ALTA |
| RF-003  | O sistema deve permitir o cadastro de veículos              | ALTA       |
| RF-004  | O sistema deve permitir visualizar, atualizar e excluir informações de veículos existentes | ALTA |
| RF-005  | O sistema deve permitir a criação de locações               | ALTA       |
| RF-006  | O sistema deve permitir visualizar e atualizar informações de locações existentes | ALTA |
| RF-007  | O sistema deve permitir a pesquisa de todas as locações e locações por ID | ALTA|



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve garantir a segurança dos dados dos clientes e da empresa, utilizando medidas como criptografia, controle de acesso e backups regulares. | MÉDIA | 
|RNF-002|O sistema deve ser otimizado para carregamento rápido, garantindo tempos de resposta mínimos mesmo em condições de conexão de internet de baixa velocidade. |  ALTA | 
|RNF-003|O sistema deve ser robusto e tolerante a falhas, sendo capaz de recuperar-se automaticamente de eventuais falhas de hardware, software ou rede sem interromper o serviço. |  ALTA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02|O sistema deve estar em conformidade com todas as leis, regulamentações e normas aplicáveis. |
|03|Todas as informações sensíveis armazenadas pelo sistema devem ser protegidas por medidas de segurança. |


# Projeto da Solução

## Arquitetura da solução

![image](https://github.com/PSG-TADS/psg-tads-2024-1-back-bd-ArexDiniz/assets/116689119/c5525be3-2022-4176-8be8-70b3ce4eeb73)

### Veiculo:
| Campo           | Descrição                                                                           |
|-----------------|-------------------------------------------------------------------------------------|
| IDVeiculo  | Chave primária que identifica cada veículo.                              |
| Modelo          | Modelo do veículo.                                                                  |
| Marca           | Marca do veículo.                                                                   |
| Ano             | Ano de fabricação do veículo.                                                       |
| ValorDiaria     | Preço diário de locação do veículo.                                                 |
| Disponivel      | Indica se o veículo está disponível.            |


### Reserva:
| Campo           | Descrição                                                                           |
|-----------------|-------------------------------------------------------------------------------------|
| IDReserva  | Chave primária que identifica cada locação.                               |
| IDCliente        | Chave estrangeira que faz referência ao cliente    |
| IDVeiculo      | Chave estrangeira que faz referência ao veículo    |
| DataInicio      | Data de início da locação.                                                          |
| DataFim         | Data de término da locação.                                                         |


### Cliente:
| Campo           | Descrição                                                                           |
|-----------------|-------------------------------------------------------------------------------------|
| IDCliente      | Chave primária que identifica unicamente cada cliente.                                |
| Nome            | Nome do cliente.                                                                    |
| Telefone        | Número de telefone do cliente.                                                      |
| Email           | Endereço de e-mail do cliente.                                                      |

## Conclusão
Em resumo, a documentação produzida representa um recurso valioso para todos os envolvidos no projeto, fornecendo uma base sólida para o desenvolvimento de um sistema de gerenciamento de locadora de veículos que atenda às necessidades e expectativas dos clientes e usuários finais. Com uma abordagem estruturada e orientada para resultados, estamos confiantes de que o projeto será um sucesso e contribuirá positivamente para o crescimento e a inovação da LoCar.
