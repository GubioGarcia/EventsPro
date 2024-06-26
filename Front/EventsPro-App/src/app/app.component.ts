import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EventsComponent } from "./events/events.component";
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './nav/nav.component';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss',
    imports: [RouterOutlet, HttpClientModule, EventsComponent, NavComponent]
})
export class AppComponent {
  title = 'EventsPro-App';
}
