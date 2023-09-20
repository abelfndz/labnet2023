import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';


@Component({
  selector: 'app-eliminar-component',
  templateUrl: './eliminar-component.component.html',
  styleUrls: ['./eliminar-component.component.css']
})
export class EliminarComponentComponent implements OnInit {

  empleado: any;

  constructor(
    private dialogRef: MatDialogRef<EliminarComponentComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { message: string, empleado: any }
  ) {
    this.empleado = data.empleado;
  }

  ngOnInit(): void {

  }


  confirm() {
    this.dialogRef.close('confirm');
  }

  cancel() {
    this.dialogRef.close('cancel');
  }
}
