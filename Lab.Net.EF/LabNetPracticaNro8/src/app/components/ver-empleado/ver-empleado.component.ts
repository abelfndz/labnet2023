import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { EmpleadoService } from '../../services/empleado.service';
import { Empleado } from '../../interfaces/empleadoView';

@Component({
  selector: 'app-ver-empleado',
  templateUrl: './ver-empleado.component.html',
  styleUrls: ['./ver-empleado.component.css']
})
export class VerEmpleadoComponent implements OnInit {
 id:number;
 empleado!: Empleado;


  constructor(private _empleadoServicio: EmpleadoService,
    private aRoute: ActivatedRoute) {

      this.id = Number(this.aRoute.snapshot.paramMap.get('id'));
     }

  ngOnInit(): void {
    this.obtenerEmpleado();
  }

  obtenerEmpleado(){
    this._empleadoServicio.getEmpleado(this.id).subscribe(emp =>{
     this.empleado = emp;
 
 
    })
  }
}
