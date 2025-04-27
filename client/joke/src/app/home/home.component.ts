import { Component, OnInit } from '@angular/core';
import { JokeService } from '../_services/joke.service';
import { Joke } from '../_interfaces/joke';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  public joke: Joke | undefined;
  public showPunchline: boolean = false;

  constructor(private jokeService: JokeService) {}


  ngOnInit(): void {
    this.jokeService.getJoke().subscribe({
      next: value => this.joke = value,
      error: err => console.log(err),
      complete: () => console.log('complete')
    });
  }

  showAnswer(){
    this.showPunchline = true;
  }

  newJoke(){
    this.showPunchline = false;
    this.jokeService.getJoke().subscribe({
      next: value => this.joke = value,
      error: err => console.log(err),
      complete: () => console.log('Got a new joke!')
    });
  }


  
}
