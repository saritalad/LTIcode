import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'image'
})
export class ImagePipe implements PipeTransform {

  transform(value: string): string {
 if(value==='')
 return '/assets/images/defaultimage.jpg';
 else
    return value;
  }

  // transform(value:string,img :string)
  // {
  //   if(value=='')
  //   {
  //     return img;
      
  //   }
    
  //   else
  //     return value;
  // }
  
}
