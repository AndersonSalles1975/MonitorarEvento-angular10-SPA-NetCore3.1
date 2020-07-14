## Problema baseado de um desafio de uma empresa

Imagine que você ficou responsável por construir um sistema que seja capaz de receber milhares de eventos por segundo de sensores espalhados pelo Brasil, nas regiões norte, nordeste, sudeste e sul. Seu cliente também deseja que na solução ele possa visualizar esses eventos de forma clara.

Um evento é defino por um JSON com o seguinte formato:

```json
{
   "timestamp": <Unix Timestamp ex: 1539112021301>,
   "tag": "<string separada por '.' ex: brasil.sudeste.sensor01 >",
   "valor" : "<string>"
}
```

Descrição:
 * O campo timestamp é quando o evento ocorreu em UNIX Timestamp.
 * Tag é o identificador do evento, sendo composto de pais.região.nome_sensor.
 * Valor é o dado coletado de um determinado sensor (podendo ser numérico ou string).

## Requisitos baseados de um desafio de uma empresa

* Sua solução deverá ser capaz de armazenar os eventos recebidos.

* Cada evento poderá ter o estado processado ou erro, caso o campo valor chegue vazio, o status do evento será erro caso contrário processado.

* Para visualização desses dados, sua solução deve possuir:
    * Uma tabela que mostre todos os eventos recebidos. Essa tabela deve ser atualizada automaticamente.
    * Um gráfico apenas para eventos com valor numérico.

* Para seu cliente, é muito importante que ele saiba o número de eventos que aconteceram por região e por sensor. Como no exemplo abaixo:
    * Região sudeste e sul ambas com dois sensores (sensor01 e sensor02):
        * brasil.sudeste - 1000
        * brasil.sudeste.sensor01 - 700
        * brasil.sudeste.sensor02 - 300
        * brasil.sul - 1500
        * brasil.sul.sensor01 - 1250
        * brasil.sul.sensor02 - 250
 
* Para seu cliente é vital a existência de uma documentação das assinaturas da API. 

## Minha solução encontrada e Tecnologias utilizadas

Como solução do problema e tendo como requisito de exibir os eventos, então desenvolvi um frontend que é um SPA (Single-Page Application) em Angular Cli versão 10, e o nome do projeto  é MonitorEvento-ui.

E para atender os demais requisitos, foi desenvolvido uma API chamada MonitorEvento-api utilizando o framework  Net Core versão 3.1.2, usando uma abordagem de modelo de software, que é o Desenvolvimento Guiado por Design (DDD). Utilizando 2 métodos, um para armazenar (HttpPost) os eventos recebidos  e o outro para carregar a tabela e o gráfico (HttpGet) através do micro framework ORM Dapper versão 2.0.35. 


## MonitorEvento-ui 

**Observação :**
* O arquivo `src/app/app.api.ts` está apontando para a porta 57528 da API.

## MonitorEvento-api 

**Observação :**
*  Caso dê problema ao executar o projeto por causa do IIS do Visual Studio 2019. A solução é mudar o número da porta, pode ser 5729 por exemplo. E se modificar não esquecer de alterar a porta do MonitorEvento-ui mencionado acima.

* Utilizei o Chart.js para carregar o gráfico.

* API está preparado para gravar os eventos, a tabela de eventos está vazia, só efetuar a carga dos eventos. Logo os gráfico será exibido e a tabela também.

### Documentação
*  Está disponível ao executar a API `http://localhost:57528/index.html`  pela ferramenta Swagger (Open API) que  está integrada .

### SCRIPT
* No arquio scrip.sql contém a criação da tabela para executar no seu banco de dados em SQL Server.