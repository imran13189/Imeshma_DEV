import { NgModule } from '@angular/core';
import { Routes, RouterModule, UrlSegment } from '@angular/router';
import { MainpageComponent } from './mainpage/mainpage.component';
import { ShopComponent } from './shop/shop.component';
import { ProductgridComponent } from './productgrid/productgrid.component';

export function productCategory(url: UrlSegment[]) {
  return url.length === 1 && url[0].path.startsWith('mens-') ? ({ consumed: url }) : null;
}

const routes: Routes = [
    {
        path: '',
        component: MainpageComponent
    },
  {
      matcher: productCategory,
    component: ShopComponent,
    children:[

      { path: '*', component: ProductgridComponent }

    ]
    }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
