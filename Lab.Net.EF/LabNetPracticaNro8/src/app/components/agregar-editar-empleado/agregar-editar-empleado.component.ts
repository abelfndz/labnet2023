import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EmpleadoService } from '../../services/empleado.service';
import { Empleado } from '../../interfaces/empleadoView';
import { ActivatedRoute, Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-agregar-editar-empleado',
  templateUrl: './agregar-editar-empleado.component.html',
  styleUrls: ['./agregar-editar-empleado.component.css']
})
export class AgregarEditarEmpleadoComponent implements OnInit {

  form: FormGroup;
  id: number;
  operacion: string;
  ocultarInputs: boolean;
  minDate: Date;
  constructor(private fb: FormBuilder, private _empleadoServicio: EmpleadoService,
    private router: Router, private _snackbar: MatSnackBar, private aRoute: ActivatedRoute) {
    this.form = this.fb.group({
      nombre: ['', [Validators.required, Validators.maxLength(10), Validators.pattern('^[a-zA-Z\\s]*$')]],
      apellido: ['', [Validators.required, Validators.maxLength(20), Validators.pattern('^[a-zA-Z\\s]*$')]],
      pais: ['', Validators.pattern('^[a-zA-Z\\s]*$')],
      ciudad: ['', Validators.pattern('^[a-zA-Z\\s]*$')],
      direccion: ['']
    })
    this.ocultarInputs = true;
    this.minDate = new Date(1950, 0, 1);
    this.operacion = 'Agregar';
    this.id = Number(this.aRoute.snapshot.paramMap.get('id'));
  }

  ngOnInit(): void {
    if (this.id != 0) {
      this.operacion = 'Editar';
      this.ocultarInputs = true;
      this.preCargarEmpleado(this.id);

    }
  }

  preCargarEmpleado(id: number) {
    this._empleadoServicio.getEmpleado(id).subscribe(data => {
      this.form.patchValue({
        nombre: data.Nombre,
        apellido: data.Apellido,
        pais: data.Pais,
        ciudad: data.Ciudad,
        direccion: data.Direccion

      })
    })
  }

  editarEmpleado(id: number, empleado: Empleado) {

    if (this.form.invalid) {
      this._snackbar.open('Los campos no aceptan numeros ni espacios vacios.', undefined, { duration: 2000 });
      return;
    }
    this._empleadoServicio.updateEmpleado(id, empleado).subscribe({
      next: () => {

        this.mensajeExito('modifico')
        this.router.navigate(['/listEmpleados'])

      }

    })


  }

  agregarEditarEmpleado() {

    const empleado: Empleado = {

      Nombre: this.form.value.nombre,
      Apellido: this.form.value.apellido,
      Pais: this.form.value.pais,
      Ciudad: this.form.value.ciudad,
      Direccion: this.form.value.direccion
      
    }

    if (this.id != 0) {
      empleado.Id = this.id;

      this.editarEmpleado(this.id, empleado);
    } else {

      this.agregarEmpleado(empleado);

    }
  }

  agregarEmpleado(empleado: Empleado) {
    if (this.form.invalid) {
      this._snackbar.open('Por favor ajuste los valores de los campos segun sea necesario', undefined, { duration: 2000 });
      return;
    }
    this._empleadoServicio.addEmpleado(empleado).subscribe({
      next: () => {

        this.mensajeExito('inserto')
        this.router.navigate(['/listEmpleados'])

      }

    })
  }

  mensajeExito(text: string) {
    this._snackbar.open(`El empleado se ${text} con exito`, '', {
      duration: 3000,
      horizontalPosition: 'right',
    })
  }

}
