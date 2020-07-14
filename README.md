## Solução encontrada e Tecnologias utilizadas

Como solução do problema e tendo como requisito de exibir os eventos com valor numérico, então desenvolvi um frontend que é uma SPA (Bônus 3) em Angular Cli versão 10, e o nome do projeto  é MonitorEvento-ui.

E para atender os demais requisitos, foi desenvolvido uma API chamada MonitorEvento-api utilizando o framework  Net Core versão 3.1.2, usando uma abordagem de modelo de software, que é o Desenvolvimento Guiado por Design (DDD). Utilizando 2 métodos, um para armazenar (HttpPost) os eventos recebidos  e o outro para carregar automaticamente a tabela e o gráfico (HttpGet) através do micro framework ORM Dapper versão 2.0.35. 


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

### O que gostaria de implementar caso tivesse mais tempo.
* Faltou implementar a controle de concorrência, pois foquei demais para implementar o SIGNAL R, mas a implementação não é tão trivial assim para efetuar o carregamento automático da tabela e do gráfico, que resolvi substituindo por uma simples função de javascript.
* Gostaria  também ter gravado num campo Data convertendo o campo timestamp para gráficos que precisassem para sinalizar a ocorrência dos eventos nas datas armazenadas.  
* Sobre  o bônus 6,  a máscara de tag dos sensores, resolveria na gravação em uma tabela dividindo pelos pontos o que separam `{pais}.{regiao}.{estado}.{sensor}`, facilitando para exibição de novas relações de gráficos e tabelas.