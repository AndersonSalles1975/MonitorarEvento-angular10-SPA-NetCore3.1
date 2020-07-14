import { Component, OnInit } from '@angular/core';
import { RelacaoEvento } from '../../../models/relacaoevento.model';
import { EventoService } from '../../../services/evento.service';
import { Chart } from 'chart.js';

@Component({
  selector: 'app-evento-consulta',
  templateUrl: './evento-consulta.component.html'
})
export class EventoConsultaComponent implements OnInit {

  listaDados: RelacaoEvento[];

  graficolinechart = []; // This will hold our chart info

  graficovaluedata = [];//[2577, 2598, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
  graficoerrovaluedata = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

  //labeldata = ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'];
  labeldata = []; //['', '', '', '', '', '', '', '', '', '', '', ''];

  constructor(
    private eventoService: EventoService
  ) { }

  ngOnInit() {
    window.dispatchEvent(new Event('resize'));
    document.body.className = 'hold-transition skin-blue sidebar-mini';
    this.listarDados();
    this.setAtualizaPagina(10);

  }


  listarDados() {
    this.eventoService.listar().subscribe((response) => {
      this.listaDados = response;
      this.carregaGrafico();
    },
      error => {
      });
  }

  setAtualizaPagina(i) {
    setTimeout(function () {
      location.reload();
    }, i * 1000);
  }

  carregaGrafico() {

    this.listaDados.forEach((item) => {
      this.graficovaluedata.push(item.totalEventos);
      this.labeldata.push(item.regiao);
    });

    this.graficolinechart = new Chart('lineChart', {
      type: 'line',
      data: {
        labels: this.labeldata,
        datasets: [
          {
            data: this.graficovaluedata,
            borderColor: "#3cba9f",
            fill: false
          },
          // {
          //   data: this.graficoerrovaluedata,
          //   borderColor: "#a21c58",
          //   fill: false
          // }
        ]
      },
      options: {
        legend: {
          display: false
        },
        scales: {
          xAxes: [{
            display: true
          }],
          yAxes: [{
            display: true
          }],
        },
        "hover": {
          "animationDuration": 0
        },
        "animation": {
          "duration": 1,
          "onComplete": function () {
            var chartInstance = this.chart,
              ctx = chartInstance.ctx;

            ctx.font = Chart.helpers.fontString(Chart.defaults.global.defaultFontSize, Chart.defaults.global.defaultFontStyle, Chart.defaults.global.defaultFontFamily);
            ctx.textAlign = 'center';
            ctx.textBaseline = 'bottom';

            this.data.datasets.forEach(function (dataset, i) {
              var meta = chartInstance.controller.getDatasetMeta(i);
              meta.data.forEach(function (bar, index) {
                var data = dataset.data[index];
                ctx.fillText(data, bar._model.x, bar._model.y - 5);
              });
            });
          }
        },
      }
    });
  }

}
