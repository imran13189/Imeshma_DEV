import { Component, OnInit } from '@angular/core';
//declare var jquery: any;
declare var $: any;
@Component({
  selector: 'app-productdetails',
  templateUrl: './productdetails.component.html',
  styleUrls: ['./productdetails.component.scss']
})
export class ProductdetailsComponent implements OnInit {

  constructor() { }

    ngOnInit() {
       $(document).ready(function () {

           $('.product_thumbnail_slides').owlCarousel({
                items: 1,
                margin: 0,
                loop: true,
                nav: true,
                navText: ["<img src='assets/img/core-img/long-arrow-left.svg' alt=''>", "<img src='assets/img/core-img/long-arrow-right.svg' alt=''>"],
                dots: false,
                autoplay: true,
                autoplayTimeout: 5000,
                smartSpeed: 1000
            });
          

        });
  }

}
