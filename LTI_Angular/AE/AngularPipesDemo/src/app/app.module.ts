import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CurrencyComponent } from './currency/currency.component';
import { DateformatComponent } from './dateformat/dateformat.component';
import { TextFormatComponent } from './text-format/text-format.component';
import { NumberFormatComponent } from './number-format/number-format.component';
import { JsonComponent } from './json/json.component';
import { AsyncPipeComponent } from './async-pipe/async-pipe.component';
import { SliceComponent } from './slice/slice.component';
import { CustomPipeComponent } from './custom-pipe/custom-pipe.component';
import { DemoPipe } from './demo.pipe';

@NgModule({
  declarations: [
    AppComponent,
    CurrencyComponent,
    DateformatComponent,
    TextFormatComponent,
    NumberFormatComponent,
    JsonComponent,
    AsyncPipeComponent,
    SliceComponent,
    CustomPipeComponent,DemoPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
