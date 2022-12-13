import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CategoriaRequest } from '../models/categoria-request';
import { CategoriaResponse } from '../models/categoria-response';

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  private url = "https://localhost:7023/api/Categoria/";



  constructor(
    private http: HttpClient
  ) { }


  getAll(): Observable<CategoriaResponse[]> {
    return this.http.get<CategoriaResponse[]>(this.url);
  }

  getById(id: number): Observable<CategoriaResponse> {
    /*
      var x = "hola";
      var y = "mundo";
      var z = x." ".y;
      c# 
      x + y;
      string.concat(x," ",y);
      javascript ==> x + " " + y;  ==> typescript
      var z = `${x} ${y}, la vida es perfecta ${mi_variable}`;
    */
    // let new_url =  this.url + id.toString();
    // new_url = `${this.url}${id}`;
    return this.http.get<CategoriaResponse>(`${this.url}${id}`);
  }

  create(request: CategoriaRequest): Observable<CategoriaResponse> {
    return this.http.post<CategoriaResponse>(this.url, request);
  }

  update(request: CategoriaRequest): Observable<CategoriaResponse> {
    return this.http.put<CategoriaResponse>(this.url, request);
  }

  delete(id: number): Observable<number> {
    return this.http.delete<number>(`${this.url}${id}`);
  }

}