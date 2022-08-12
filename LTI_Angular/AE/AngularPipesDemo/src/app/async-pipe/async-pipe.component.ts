import { Component, OnInit } from '@angular/core';
import { delay, Observable, of } from 'rxjs';

@Component({
  selector: 'app-async-pipe',
  templateUrl: './async-pipe.component.html',
  styleUrls: ['./async-pipe.component.css']
})
export class AsyncPipeComponent implements OnInit {
 promise:Observable<string>;
 asyncPromise: Promise<string>;
  constructor() { }

  ngOnInit(): void {
         this.promise=this.makeObservable('this is coming from observable string');
          this.asyncPromise = this.makePromise('Async Promise');
        }
        makeObservable(value: string): Observable<string> {
          return of(value).pipe(delay(3000));
        }
    makePromise(value: string): Promise<string> {
      return new Promise((resolve, reject) => {
        setTimeout(() => resolve(value), 3000);
      })
    }
    


}
