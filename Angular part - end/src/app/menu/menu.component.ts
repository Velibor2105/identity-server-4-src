import { Component, OnInit } from '@angular/core';
import { OpenIdConnectService } from '../shared/services/open-id-connect.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  constructor(private openIdConnectService: OpenIdConnectService) { }

  ngOnInit() {
  }

}
