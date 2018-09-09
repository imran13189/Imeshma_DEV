import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http'; 
import { AppComponent } from './app.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { HeaderComponent } from './header/header.component';
import { FooterareaComponent } from './footerarea/footerarea.component';
import { MainpageComponent } from './mainpage/mainpage.component';
import { ShopComponent } from './shop/shop.component';
import { ProductgridComponent } from './productgrid/productgrid.component';
import { ProductdetailsComponent } from './productdetails/productdetails.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    HeaderComponent,
    FooterareaComponent,
    MainpageComponent,
    ShopComponent,
    ProductgridComponent,
    ProductdetailsComponent,
    LoginComponent
  ],
    imports: [
      RouterModule,
    BrowserModule,
      AppRoutingModule,
      HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
