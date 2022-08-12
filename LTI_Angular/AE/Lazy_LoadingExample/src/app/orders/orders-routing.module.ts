import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrderdetailsComponent } from './orderdetails/orderdetails.component';
import { OrdersComponent } from './orders.component';

const routes: Routes = [

  { path: '', redirectTo: 'orders', pathMatch: 'fullpath' },
  { path: 'orders', component: OrdersComponent,
children:[
  {path:'details',component:OrderdetailsComponent}
   ]

} ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OrdersRoutingModule { }
