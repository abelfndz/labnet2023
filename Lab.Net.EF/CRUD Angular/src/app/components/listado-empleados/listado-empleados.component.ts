import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { EmpleadoService } from 'src/app/services/empleado.service';
import { MatDialog } from '@angular/material/dialog';
import { EliminarComponentComponent } from '../eliminar-component/eliminar-component.component';
import { Empleado } from '../../interfaces/empleadoView';
import { MatSnackBar } from '@angular/material/snack-bar';


@Component({
  selector: 'app-listado-empleados',
  templateUrl: './listado-empleados.component.html',
  styleUrls: ['./listado-empleados.component.css']
})
export class ListadoEmpleadosComponent implements OnInit {

  displayedColumns: string[] = ['nombre', 'apellido', 'acciones'];
  dataSource = new MatTableDataSource();

  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _empleadoServicio: EmpleadoService, private dialog: MatDialog, private _snackbar: MatSnackBar) { }



  ngAfterViewInit() {
    this.dataSource.sort = this.sort;
  }

  cadenaBuscar(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  obtenerEmpleados() {

    this._empleadoServicio.getEmpleados().subscribe(empleados => {
      this.dataSource.data = empleados;
    })

  }



  eliminarEmpleado(id: number) {
    this._empleadoServicio.deleteEmpleado(id).subscribe({
      next: () => {
        this.obtenerEmpleados();
        this._snackbar.open('El empleado se Elimino con exito', undefined, { duration: 2000 });
      },
      error: err => {
        console.log('Error al eliminar el empleado: ', err);
        this._snackbar.open('No tiene permisos para eliminar ese registro u ocurrio un error', undefined, { duration: 2000 });
      }
    })
  }

  confirmDelete(id: number) {
    this._empleadoServicio.getEmpleado(id).subscribe(empleado => {
      const dialogRef = this.dialog.open(EliminarComponentComponent, {
        data: {
          empleado: empleado
        }
      });

      dialogRef.afterClosed().subscribe((result) => {
        if (result === 'confirm') {
          this.eliminarEmpleado(id);

        }
      });
    });
  }

  ngOnInit(): void {
    this.obtenerEmpleados();

  }




}
