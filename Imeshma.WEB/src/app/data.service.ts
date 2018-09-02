import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { environment } from '../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
    //baseUrl = environment.baseUrl;
    constructor(private http: HttpClient) {
        
  }
  getProductDetails(category: string) {
    debugger;
        let url = environment.baseUrl + '/api/Product/GetProductDetails';
        return this.http.get(url);
    }
}
