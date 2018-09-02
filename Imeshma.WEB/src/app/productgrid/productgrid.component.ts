import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataService }  from '../data.service';

import { Observable } from 'rxjs';

@Component({
  selector: 'app-productgrid',
  templateUrl: './productgrid.component.html',
  styleUrls: ['./productgrid.component.scss']
})
export class ProductgridComponent implements OnInit {
    products;
    constructor(private data: DataService, private router: Router, private route: ActivatedRoute) {
      this.route.params.subscribe(params => {
        console.log(params);
        if (params["category"]) {
          this.data.getProductDetails(params["category"]).subscribe(
            data => this.products = data
            ,
            error => console.log(error)
          );
        }
      });
    }

    ngOnInit() {
        //debugger;
        //this.data.getProductDetails().subscribe(
        //    data => this.products = data
        //    ,
        //    error => console.log(error)
        //)

       
    }

  
    //getproductdetailpage() {
    //    //this.router.navigate(["../../productdetails"], { relativeTo: this.route });
    //    window.open("productdetails");
    //}
}
