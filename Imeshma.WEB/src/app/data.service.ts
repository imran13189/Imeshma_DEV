import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DataService {
    //baseUrl = environment.baseUrl;
    constructor(private http: HttpClient) {
        
    }
    getProductDetails() {
        let url = environment.baseUrl + 'Product/GetProductDetails';
        return this.http.get(url);
    }
}
