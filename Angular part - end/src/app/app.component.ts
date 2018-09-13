import { Component } from '@angular/core';
import { OpenIdConnectService } from './shared/services/open-id-connect.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  constructor(private openIdConnectService: OpenIdConnectService){

  }

  ngOnInit() {
    var path = window.location.pathname;
    if(path != "/signin-oidc"){
      if(!this.openIdConnectService.userAvailable){
        this.openIdConnectService.triggerSignIn();
      }
    }
  }
}
