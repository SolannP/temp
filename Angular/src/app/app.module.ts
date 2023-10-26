import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './game/home/home.component';
import { TargetTextComponent } from './game/home/components/target-text/target-text.component';
import { UserTextComponent } from './game/home/components/user-text/user-text.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    TargetTextComponent,
    UserTextComponent
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
