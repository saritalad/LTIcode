import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TasksComponent } from '../tasks/tasks.component';
import { ProductsComponent } from './products.component';
import { ProductviewComponent } from './productview/productview.component';

const routes: Routes = [{ path: '', redirectTo: 'products', pathMatch: 'fullpath' },

{path:'products',component:ProductsComponent,
children:[
  {path:'view',component:ProductviewComponent},
  {path:'Tasks',component:TasksComponent}
]

},

];



@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductsRoutingModule { }
