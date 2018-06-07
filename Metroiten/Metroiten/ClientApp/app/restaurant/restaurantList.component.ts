import { Component, OnInit } from "@angular/core"
import { DataService } from "../shared/dataService";

@Component({
    selector: "restaurant-list",
    templateUrl: "restaurantList.component.html",
    styleUrls: []
})

export class RestaurantList implements OnInit {

    constructor(private data: DataService) {
    }

    public restaurants = [];

    ngOnInit(): void { this.data.loadProducts().subscribe(s => {
        if (s) {
            this.restaurants = this.data.restaurants;
        }
    }); }
}