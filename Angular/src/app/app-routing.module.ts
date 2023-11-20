import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './game/home/home.component';
import { SvgComponent } from './easter-egg/svg/svg.component';

const routes: Routes = [
  { title:'German Gonzales',path:'game', component:HomeComponent },
  { title: 'Easter Egg ༼ つ ◕_◕ ༽つ', path:'easter-egg-svg', component: SvgComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
