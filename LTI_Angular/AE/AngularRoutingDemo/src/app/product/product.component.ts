import { Component, OnInit } from '@angular/core';
import { Product, ProductService } from '../product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products:Product[]=[];
   
  constructor(private productService:ProductService){
  }

  ngOnInit() {
    this.products=this.productService.getProducts();
  }

}
