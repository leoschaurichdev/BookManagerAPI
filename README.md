# BookManager

## Descrição
Este é um projeto WEB API para gerenciar o empréstimo de livros em uma biblioteca.

## Recursos Utilizados
- Visual Studio 2022
- Framework .Net 8.0 e linguagem C#
- ORM Entity Framework Core
- Implementação do padrão CQRS utilizando a lib MediatR
- Swagger
- SQL Server

## Funcionalidades
- [x] Criar banco de dados
- [ ] Deixar cover funcional
- [X] Controller Loan para visualizar todas os emprestimos em andamento
- [X] Validações
- [ ] Autenticação e Autorização com JWT
- [ ] Desenvolver interface do usuário

## Tecnologias Utilizadas
- C#
- .NET 8.0
- Entity Framework Core
- MediatR
- SQL Server

## Como Contribuir
1. Faça um fork do projeto
2. Crie uma branch (`git checkout -b feature/nova-funcionalidade`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/nova-funcionalidade`)
5. Abra um Pull Request

## Contato
Para mais informações, entre em contato pelo e-mail: leoschaurich12@gmail.com


# BOOK

-GET ALL
![Captura de tela 2025-02-08 074601](https://github.com/user-attachments/assets/04b30b29-34f3-463e-94ff-91deeaa2cfd8)
-POST
![Captura de tela 2025-02-08 074910](https://github.com/user-attachments/assets/6c9d99e1-6117-40e9-ae0d-b0425a5e3598)
-GET POR ID
![Captura de tela 2025-02-08 075441](https://github.com/user-attachments/assets/7265ee2a-d6b7-4277-aa67-fda09ff483ba)
-PUT
Antes da atualização (comportamento no banco de dados)
![Captura de tela 2025-02-08 075656](https://github.com/user-attachments/assets/f6ab30a9-8930-4bc4-94af-28502bf2a072)
Dados atualizados
![Captura de tela 2025-02-08 080145](https://github.com/user-attachments/assets/6a807153-fdb2-48b2-a560-a72a5b8e0d0c)
Após atualização (dados apresentados no banco de dados)
![Captura de tela 2025-02-08 080218](https://github.com/user-attachments/assets/373fcd7b-30b4-4d4d-8047-f8ce330d67a9)
-DELETE
![Captura de tela 2025-02-08 144043](https://github.com/user-attachments/assets/ce3e5a35-e77f-4fb1-97f4-13aaba2fc7e1)

# LOAN

-GET ALL (SÓ APRESENTA OS EMPRESTIMOS QUE ESTÃO ATIVOS)
![Captura de tela 2025-02-08 144359](https://github.com/user-attachments/assets/889a4b8e-2ea8-4958-9282-a459fd3a0aac)
-POST
Cadastro de um empréstimo
![Captura de tela 2025-02-08 145123](https://github.com/user-attachments/assets/9fe20a3a-8081-44f3-b2f5-1b488488fd6d)

Salvo no banco de dados (observar que o sistema já seta o dia de devolução que são em 7 dias)
![Captura de tela 2025-02-08 145204](https://github.com/user-attachments/assets/00f5c3d2-dd2c-4e9d-a682-1b4a6eed3d6e)

-FINISHLOAN (FAZ A ENTREGA DO EMPRESTIMO)
-LATELOAN (FAZ O STATUS DA SITUAÇÃO FICAR EM DELAY)

# USER

-GET (Traz os usuarios por Id)
![Captura de tela 2025-02-08 144808](https://github.com/user-attachments/assets/ebd2a139-76c7-4445-9fac-a990baffe02e)

-POST (Cadastro de usuarios)
![Captura de tela 2025-02-08 145036](https://github.com/user-attachments/assets/e87f76d8-3901-4231-8b8e-7ba92f730586)
