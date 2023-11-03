import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  onPostFacebookReviewButtonClick() {
    this.http.get(this.baseUrl + 'postfacebookreview', {}).subscribe(response => {
      console.log(response); // Handle the response from the server
    });
  }
}
