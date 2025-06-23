
# 🍽️ Cantina 10.0

Sistema de vendas e controle de estoque para cantinas escolares, desenvolvido como projeto final do Primeiro Semestre do curso técnico de Desenvolvimento de Sistemas no SENAI.

## 📌 Objetivo

O sistema foi criado para facilitar o atendimento e a organização de uma cantina. Ele permite registrar pedidos, controlar estoque, organizar o preparo dos alimentos e gerenciar os acessos dos funcionários de forma separada.

## ⚙️ Funcionalidades

- Tela de vendas com carrinho de compras
- Cálculo automático do total e do troco
- Várias formas de pagamento: dinheiro, Pix, cartão, vale
- Envio de pedidos para a cozinha ou balcão, conforme o produto
- Tela da cozinha com pedidos em preparo
- Tela de chamada exibindo pedidos prontos e nome do cliente
- Controle de estoque com entrada e saída de produtos
- Login com perfis diferentes e acesso restrito
- Registro de data, hora, forma de pagamento e nome do cliente
- Geração de extrato simples ao final da compra

## 🔐 Logins de Teste

Use os seguintes logins para acessar o sistema com diferentes funções:

| Perfil       |  Usuário     | Senha        |
|--------------|--------------|--------------|
| Administrador|  `admin`     | `admin`      |
| Balcão       |  `balcao`    | `balcao`     |
| Cozinha      |  `cozinha`   | `cozinha`    |
| Chamada      |  `chamada`   | `chamada`    |

## 🛠️ Tecnologias

- **Linguagem:** C#
- **Plataforma:** Windows Forms (.NET Framework)
- **Dados salvos em arquivos:** serialização JSON

## ▶️ Como usar

1. Clone o repositório:
```bash
git clone https://github.com/lopreti/projeto-cantina.git
```

2. Abra o projeto no **Visual Studio**  
3. Compile a solução (`Ctrl + Shift + B`)  
4. Execute o sistema (`F5`)  
5. Faça login com um dos perfis acima

## 👤 Autora

Isabella Gonçalves Lopreti  
Escola SENAI "Nadir Dias de Figueiredo" – 2025
Instrutor: Lucas Gonzalez

##
> Algumas seções deste projeto foram desenvolvidas com apoio do Claude.Ai e Gemini para salvar dados localmente e revisar o código final.
