import { API_URL } from "../app.api";
import { Observable, throwError } from "rxjs";
import { HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
import { catchError, map } from "rxjs/operators";
import { Injectable } from "@angular/core";

@Injectable()
export class Util {
    constructor(
        private http: HttpClient
    ) { }

    private headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    private params = new HttpParams();
    online: boolean;
    baseUrl: string = `${API_URL}`;

    options = {
        headers: this.headers
    };

    checkInternet() {
        this.online = (window.navigator.onLine);
    }

    get(funcao: string, parametro1: string = ''): Observable<any> {
        this.checkInternet();
        if (this.online) {
            return this.http.get(this.baseUrl + funcao + `${parametro1}`)
                .pipe(
                    map(response => response),
                    catchError(ex =>
                        throwError(ex)
                    )
                )
        }
        else
            throwError(new Error('Ocorreu um erro. Favor verificar sua conexão'))
    }

}

