import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-c3',
  templateUrl: './c3.component.html',
  styleUrls: ['./c3.component.css']
})
export class C3Component implements OnInit {

  numero: number = 0;

  constructor() {
  }

  sumar() {
    this.numero = this.numero + 1;
  }

  restar() {
    this.numero = this.numero - 1;
  }

  ngOnInit(): void {
  }

}
