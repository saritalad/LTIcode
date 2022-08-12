import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  
  { path: 'orders', loadChildren: () => import('./orders/orders.module').then(m => m.OrdersModule) },
  
  { path: 'products', loadChildren: () => import('./products/products.module').then(m => m.ProductsModule) },
  
  { path: 'Tasks', loadChildren: () => import('./tasks/tasks.module').then(m => m.TasksModule) },
  
  { path: 'ToDos', loadChildren: () => import('./to-dos/to-dos.module').then(m => m.ToDosModule) }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
