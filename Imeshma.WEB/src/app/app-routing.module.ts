import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainpageComponent } from './mainpage/mainpage.component';
import { ShopComponent } from './shop/shop.component';
const routes: Routes = [
    {
        path: '',
        component: MainpageComponent
    },
    {
        path: 'shop',
        component: ShopComponent
    }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
