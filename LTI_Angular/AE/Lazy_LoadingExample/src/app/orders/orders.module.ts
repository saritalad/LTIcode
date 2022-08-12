import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrdersRoutingModule } from './orders-routing.module';
import { OrdersComponent } from './orders.component';
import { OrderdetailsComponent } from './orderdetails/orderdetails.component';


@NgModule({
  declarations: [
    OrdersComponent,
    OrderdetailsComponent
  ],
  imports: [
    CommonModule,
    OrdersRoutingModule
  ]
})
export class OrdersModule { }
