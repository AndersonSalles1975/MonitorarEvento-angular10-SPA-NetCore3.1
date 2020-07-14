import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Util } from './util';
import { RelacaoEvento } from '../models/relacaoevento.model';

@Injectable({
    providedIn: 'root'
})
export class EventoService {
    constructor(private util: Util) { }

    listar(): Observable<RelacaoEvento[]> {
        return this.util.get('/Evento/relacaoEvento');
    }

}
