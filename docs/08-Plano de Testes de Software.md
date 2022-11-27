# Plano de Testes de Software


O plano de testes consiste num conjunto de ações que visa verificar se cada funcionalidade criada para o programa funciona tal como foi planejada. Cada uma dessas ações estabelece critérios para determinar se a funcionalidade a ser testada está ou não dentro do planejado.  

Os requisitos necessários para a realização dos testes de software são: 

* A publicação do aplicativo; 

* Navegador da Internet - Chrome, Firefox ou Edge para acessar o aplicativo; 

* Conectividade de Internet para o acesso às plataformas. 

Os testes funcionais a serem realizados são os seguintes:


## 01-Verificação no banco de dados das informações cadastradas pelo usuário

|Caso de Teste|CT- 01 - Verificação no banco de dados das informações cadastradas pelo usuário|
|------------|---------------------------------------------|
|**Requisitos Associados**| RF-01, RF-02, RF-03; RNF-01, RNF-06. |
|**Objetivo do teste**|Verificar se os dados preenchidos pelo usuário são gravados no banco de dados. |
|**Passos**|1- Acessar o Navegador| 
|2| Informar o endereço do site.|  
|3|Clicar em “Entrar” para acessar a tela de login.| 
|4| Informar o e-mail e a senha na tela de login. |
|5|Clicar em "Entrar" ;| 
|6|Confirmar se as informações foram gravadas no banco de dados.|
|**Critérios de Êxito**|1- Preencher informações solicitadas| 
|2| E-mail conter formato padrão (xxxx@xxxx.com.br) |
|3| Qualquer tipo de string |
|4| Seguido por um caractere @ (obrigatório em e-mails) |
|5| Seguido por um domínio/provedor (hotmail/gmail) |
|6| Seguido por um ponto obrigatório (.) |
|7| Texto validando o e-mail (com/com.br) |

## 02-Validação do e-mail

|Caso de Teste|CT- 02 - Validação do e-mail|
|------------|---------------------------------------------|
|**Requisitos Associados**| RF-01, RF-02, RF-03; RNF-01, RNF-06. |
|**Objetivo do teste**|Verificar a validade do e-mail cadastrado. |
|**Passos**|1- Acessar o Navegador| 
|2| Informar o endereço do site.|  
|3|Clicar em esqueci minha senha. | 
|4| Inserir e-mail cadastrado. |
|5|Confirmar e-mail e enviar instruções para e-mail cadastrado.| 
|**Critérios de Êxito**|1- Possui cadastro no site.| 
|2| E-mail conter formato padrão (xxxx@xxxx.com.br).  |
|3| Qualquer tipo de string |
|4| Seguido por um caractere @ (obrigatório em e-mails) |
|5| Seguido por um domínio/provedor (hotmail/gmail) |
|6| Seguido por um ponto obrigatório (.) |
|7| Texto validando o e-mail (com/com.br) |
 
 ## 03-Validação da senha redefinida

|Caso de Teste|CT- 03 - Validação da senha redefinida |
|------------|---------------------------------------------|
|**Requisitos Associados**| RF-01, RF-02, RF-03; RNF-01, RNF-06. |
|**Objetivo do teste**|Verificar a validade de uma senha redefinida.  |
|**Passos**|1- Acessar o Navegador| 
|2| Informar o endereço do site.|  
|3|Clicar em "esqueci minha senha". | 
|4| Inserir e-mail cadastrado. |
|5|Digitar a nova senha.| 
|6| Voltar à página de Login|
|7| Digitar email e senha.|
|**Critérios de Êxito**|1- Possui cadastro no site.| 
|2| E-mail conter formato padrão (xxxx@xxxx.com.br).|
|3| Qualquer tipo de string |
|4| Seguido por um caractere @ (obrigatório em e-mails) |
|5| Seguido por um domínio/provedor (hotmail/gmail) |
|6| Seguido por um ponto obrigatório (.) |
|7| Texto validando a redefinição de senha.|


## 04-Verificação no banco de dados das preferências cadastradas pelo usuário 

|Caso de Teste|CT- 04 - Verificação no banco de dados das preferências cadastradas pelo usuário  |
|------------|---------------------------------------------|
|**Requisitos Associados**| RF-01, RF-02, RF-03; RNF-01, RNF-06. |
|**Objetivo do teste**|Verificar a validade de uma senha redefinida.  |
|**Passos**|1- Acessar o Navegador| 
|2| Informar o endereço do site.|  
|3|Clicar realizar cadastro e clicar em "cadastrar". | 
|4| Acessar a página de "finalizaçao de cadastro" terminar o cadastro e clicar em "cadastrar" |
|5| Na página “Checkbox”, marcar algumas checkbox (exercícios preferidos) para criar um perfil de atividades preferidas| 
|6| Clicar no botão “Finalizar”.|
|7| Verificar no banco de dados se as informações foram recebidas.|
|**Critérios de Êxito**|1- Possui cadastro no site.| 
|2| E-mail conter formato padrão (xxxx@xxxx.com.br).|
|3| Qualquer tipo de string |
|4| Seguido por um caractere @ (obrigatório em e-mails) |
|5| Seguido por um domínio/provedor (hotmail/gmail) |
|6| Seguido por um ponto obrigatório (.) |
|7|A apresentação da página “Sugestões”, com perfis compatíveis apresentar usuários compatíveis|

## 05-Verificação da tela Sugestões


|Caso de Teste|CT- 05 - Verificação da tela Sugestões  |
|------------|---------------------------------------------|
|**Requisitos Associados**| RF-01, RF-02, RF-03, RF-04 RF-04 RF-06 RF-07 RF-09; RNF-01, RNF-02, RNF-03, RNF-06. |
|**Objetivo do teste**|Verificar se o programa está produzindo sugestões de usuários compatíveis com base no perfil cadastrado por um usuário.|
|**Passos**|1- Acessar o Navegador| 
|2| Informar o endereço do site.|  
|3|Clicar em "entrar". | 
|4| Inserir e-mail cadastrado e senha. |
|5| Na página “Checkbox”, marcar algumas checkbox para criar um perfil de atividades | 
|6|  Clicar no botão “Finalizar”.|
|7| Verificar se, ao clicar, a página “Sugestões” abre, apresentando perfis compatíveis.|
|**Critérios de Êxito**|1- Possui cadastro no site.| 
|2| E-mail conter formato padrão (xxxx@xxxx.com.br).|
|3| Qualquer tipo de string |
|4| Seguido por um caractere @ (obrigatório em e-mails) |
|5| Seguido por um domínio/provedor (hotmail/gmail) |
|6| Seguido por um ponto obrigatório (.) |
|7| A apresentação da página “Sugestões”, com perfis compatíveis apresentar usuários compatíveis.|

## 06-Verificação da tela Perfil do usuário Isabel Soares

|Caso de Teste|CT- 06 - CT- 06 - Verificação da tela Perfil do usuário Isabel Soares|
|------------|---------------------------------------------|
|**Requisitos Associados**|  RF-01, RF-02, RF-03, RF-04 RF-04 RF-06 RF-07 RF-09; RNF-01, RNF-02, RNF-03, RNF-04, RNF-06. |
|**Objetivo do teste**|Verificar se a tela “Perfil” funciona, apresentando as informações do usuário.|
|**Passos**|1- Acessar o Navegador| 
|2| Informar o endereço do site.|  
|3|Clicar em “Entrar” para acessar a tela de login. | 
|4|Informar o e-mail e a senha na tela de login.  |
|5|Clicar em "Entrar" .| 
|6| Verificar se a tela “Sugestões de Perfis” aparece.|
|7| Acha o perfil de Isabel Soares e clicar em "ver Perfil".|
|8| Verificar se a tela “Perfil” aparece.|
|9| Ver o perfil de Isabel Soares e " Favoritar"|
|**Critérios de Êxito**|1- Possui cadastro no site.| 
|2| E-mail conter formato padrão (xxxx@xxxx.com.br).|
|3| Qualquer tipo de string |
|4| Seguido por um caractere @ (obrigatório em e-mails) |
|5| Seguido por um domínio/provedor (hotmail/gmail) |
|6| Seguido por um ponto obrigatório (.) |
|7| A apresentação da página “Perfil”, com o perfil do usuário.|

## 07-Testar a responsividade e navegabilidade em diferentes tamanhos de telas


|Caso de Teste|CT- 07 -Testar a responsividade e navegabilidade em diferentes tamanhos de telas|
|------------|---------------------------------------------|
|**Requisitos Associados**| RF-01, RF-02, RF-03; RNF-01, RNF-02, RNF-03, RNF-04, RNF-05, RNF-06.  |
|**Objetivo do teste**|Testar se o Aplicativo MyFriendFit é um Software responsivo, sendo possível navegar  e visualizar claramente todos os itens da página.  |
|**Passos**|1- Acessar o Navegador| 
|2|  Acessar a HomePage (index.html)|  
|3|Acessar o Login | 
|4| Acessar a Sugestão de Usuários |
|5|Acessar o Perfil de Isabel Soares| 
|6| Acessar novamente da Home Page|
|7| Acessar a página Cadastro|
|8| Acessar a página de continuidade do cadastro (adicionar foto, data de nascimento , etc)|
|9| Acessar a página de Checkbox de Exercícios Físicos e finalizar o cadastro|
|10| Visualizar os perfis recomendados|
|**Critérios de Êxito**|Verificar a legilibilidade de todos os itens da páginas em diferentes tamanhos de tela.| 







