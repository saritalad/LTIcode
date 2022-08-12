import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  public getProducts() {
 
    let products:Product[];

    products=[
        new Product(1,'Memory Card',500),
        new Product(2,'Pen Drive',750),
        new Product(3,'Power Bank',100)
    ]

    return products;               
}


public getProduct(id:number) {
    let products:Product[]=this.getProducts();
    return products.find(p => p.productID==id);
}

}

export class Product{

  constructor(productID:number,    name: string ,   price:number) {
    this.productID=productID;
    this.name=name;
    this.price=price;
}

productID:number ;
name: string ;
price:number;
}