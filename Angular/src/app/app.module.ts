import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './game/home/home.component';
import { TargetTextComponent } from './game/home/components/target-text/target-text.component';
import { UserTextComponent } from './game/home/components/user-text/user-text.component';
import { SvgComponent } from './easter-egg/svg/svg.component';
import { GaugeComponent } from './game/home/components/gauge/gauge.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TargetTextComponent,
    UserTextComponent,
    SvgComponent,
    GaugeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
