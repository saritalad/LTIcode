import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';

@Component({
  selector: 'app-e-info',
  templateUrl: './e-info.component.html',
  styleUrls: ['./e-info.component.css'],
  providers: [DataService]
})
export class EInfoComponent implements OnInit {
 public infoReceived1: string[]=[];

 public infoReceived2: string[]=[];

 public infoReceived3: string[]=[];
 public dservice: any;

  getInfoFromService1(){

    this.infoReceived1 = this.dservice.getInfo1()

  }

  getInfoFromService2(){

    this.infoReceived2 = this.dservice.getInfo2()

  }

  getInfoFromService3(){

    this.infoReceived3 = this.dservice.getInfo3()

  }
  constructor(private Dservice: DataService) {
    this.dservice=Dservice;
   }

  ngOnInit(): void {
  }

}
