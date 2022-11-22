import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChildComponent } from './child/child.component';
import { Child1Component } from './child1/child1.component';
import { GrandchildComponent } from './grandchild/grandchild.component';
import { Grandchild2Component } from './grandchild2/grandchild2.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path:"home",component:HomeComponent,
      children:[{path:"child0",component:ChildComponent},
          {path:"child1",component:Child1Component,
          children:[{path:"grandchild1",component:GrandchildComponent},
                     {path:"grandchild2",component:Grandchild2Component}
                    ]
           
        }

]},

{path:"**",redirectTo:"home"}

];
 
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
