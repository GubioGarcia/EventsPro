import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { error } from 'console';
import { response } from 'express';

@Component({
  selector: 'app-events',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './events.component.html',
  styleUrl: './events.component.scss'
})
export class EventsComponent {

  public events: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEvents();
  }

  public getEvents(): void {
    this.http.get('https://localhost:5001/api/Events').subscribe(
      response => this.events = response,
      error => console.log(error)
    );
  }
}
