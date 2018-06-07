import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from "@angular/common/http"


import { AppComponent } from './app.component';
import { RestaurantList } from './restaurant/restaurantList.component';
import { DataService } from "./shared/dataService";
import { News } from "./news/news.component";
import { Home } from "./home/home.component";
import { Nav } from "./navigation/nav.component";

import { RouterModule } from "@angular/router";

let routes = [
    { path: "", component: Home },
    { path: "news", component: News }
];

@NgModule({
  declarations: [
      AppComponent,
      RestaurantList,
      Home,
      News,
      Nav
  ],
  imports: [
      BrowserModule,
      HttpClientModule,
      RouterModule.forRoot(routes,
          {
              useHash: true,
              enableTracing: false
          })
  ],
    providers: [
            DataService
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
