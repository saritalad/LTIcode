import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ImageZoomComponent } from './image-zoom/image-zoom.component';

const routes: Routes = [
{path:'zoom',component:ImageZoomComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
