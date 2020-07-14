import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Injector } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventoConsultaComponent } from './pages/evento/evento-consulta/evento-consulta.component';
import { LayoutModule } from './layout/layout.module';
import { EventoService } from './services/evento.service';
import { Util } from './services/util';
import { HttpClientModule } from '@angular/common/http';

export let InjectorInstance: Injector;

@NgModule({
  declarations: [
    AppComponent, EventoConsultaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    LayoutModule,
    HttpClientModule
  ],
  providers: [EventoService, Util],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(private injector: Injector) {
    InjectorInstance = this.injector;
  }
}
