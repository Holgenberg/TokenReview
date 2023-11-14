import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { timeout } from 'rxjs/operators';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  onPostFacebookReviewButtonClick() {
    this.http.get(this.baseUrl + 'postfacebookreview', {})
      .subscribe({
        next: (response: any) => {
          const reviewMessage = response.message; // Assuming the property is named 'message'
          console.log('Review:', reviewMessage);
          // You can now use the 'reviewMessage' variable as needed
        },
        error: (error: any) => {
          console.error('Error:', error);
          // Handle any errors that occurred during the HTTP request
        }
      });
  }
}
