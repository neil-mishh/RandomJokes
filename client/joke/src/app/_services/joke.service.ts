import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class JokeService {
  private baseURL: string = 'http://localhost:5177/Joke/'

  constructor(private http: HttpClient) { }


  getJoke(): Observable<any>{
    return this.http.get(this.baseURL + 'random_joke');
  }

}
