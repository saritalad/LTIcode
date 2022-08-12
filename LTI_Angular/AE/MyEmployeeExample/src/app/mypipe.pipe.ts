import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'mypipe'
})
export class MypipePipe implements PipeTransform {

  transform(value: string):string {
    if(value=="")
    { value='NOT ASSIGNED'
    }
    
    return value;
  }

}
