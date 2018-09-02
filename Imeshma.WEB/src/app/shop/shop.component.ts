import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {


  constructor(private router: Router, private route: ActivatedRoute) {
    
  }

  ngOnInit() {
    //this.router.navigate(['test'], { relativeTo: this.route })
  }

  //doSearch(term: string) {
  //  this.loading = true;
  //  this.itunes.search(term).then(_ => (this.loading = false));
  //}

  //onSearch(term: string) {
  //  this.router.navigate(["search", { term: term }]);
  //}
 
}
