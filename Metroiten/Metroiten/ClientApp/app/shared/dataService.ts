import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import 'rxjs/add/operator/map';

@Injectable()
export class DataService {

    constructor(private http: HttpClient) {}

    public restaurants = [];

    loadProducts() {
        return this.http.get("/Restaurants/Get").map((data: any[]) => {
            this.restaurants = data;
            return true;
        });
    }
}