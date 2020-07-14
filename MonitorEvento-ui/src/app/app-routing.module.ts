import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EventoConsultaComponent } from './pages/evento/evento-consulta/evento-consulta.component';


const routes: Routes = [
  { path: '', redirectTo: 'evento-consulta', pathMatch: 'full' },
  { path: 'evento-consulta', component: EventoConsultaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],

})
export class AppRoutingModule { }
