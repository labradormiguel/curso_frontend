import { Component, OnInit } from '@angular/core';
import { Producto } from '../producto';

@Component({
  selector: 'app-c5',
  templateUrl: './c5.component.html',
  styleUrls: ['./c5.component.css']
})
export class C5Component implements OnInit {

  //productos=[{1,"ordenador",200},{2,"tablet",100}];
  
  listaProductos:Producto[]=[];
  
  agregar(){

  }

  constructor() { 

    this.listaProductos.push(new Producto(1,"ordenador",200));
    this.listaProductos.push(new Producto(2,"tablet",150));

  }

  ngOnInit(): void {
  }

}
