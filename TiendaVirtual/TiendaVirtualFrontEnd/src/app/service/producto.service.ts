import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  private url = "https://localhost:7196/api/Categoria/";
  constructor(
    private http: HttpClient
  ) { }


  get() {
    return this.http.get(this.url);
  }

  post() {
    return this.http.get(this.url);
  }

  put() {
    return this.http.get(this.url);
  }

  delete() {
    return this.http.get(this.url);
  }

}
