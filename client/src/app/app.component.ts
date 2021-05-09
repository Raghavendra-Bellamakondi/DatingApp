import { Component } from '@angular/core';
import {HttpClient} from '@angular/common/http'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  users:any;
  /**
   *
   */
  constructor(private _http: HttpClient) {
   
    
  }
  ngOnInit(): void {
    this._http.get('https://localhost:5001/api/Users').subscribe(x=>
   { this.users=x;
    console.log(x);
  }
    );
    
  }
}
