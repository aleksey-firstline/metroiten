"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var dataService_1 = require("../shared/dataService");
var RestaurantList = /** @class */ (function () {
    function RestaurantList(data) {
        this.data = data;
        this.restaurants = [];
    }
    RestaurantList.prototype.ngOnInit = function () {
        var _this = this;
        this.data.loadProducts().subscribe(function (s) {
            if (s) {
                _this.restaurants = _this.data.restaurants;
            }
        });
    };
    RestaurantList = __decorate([
        core_1.Component({
            selector: "restaurant-list",
            templateUrl: "restaurantList.component.html",
            styleUrls: []
        }),
        __metadata("design:paramtypes", [dataService_1.DataService])
    ], RestaurantList);
    return RestaurantList;
}());
exports.RestaurantList = RestaurantList;
//# sourceMappingURL=restaurantList.component.js.map