import { Component } from '@angular/core';
import { GameComponent } from './game/game.component';



@Component({ 
  selector: 'app', 
  templateUrl: './app.component.html',
  standalone: true ,
  imports: [GameComponent]
})
export class AppComponent {
  title = 'typong';
}
