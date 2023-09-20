import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';


import { AgregarEditarEmpleadoComponent } from './components/agregar-editar-empleado/agregar-editar-empleado.component';
import { EliminarComponentComponent } from './components/eliminar-component/eliminar-component.component';
import { ListadoEmpleadosComponent } from './components/listado-empleados/listado-empleados.component';
import { VerEmpleadoComponent } from './components/ver-empleado/ver-empleado.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { SharedModule } from './shared/shared.module';


//material


@NgModule({
  declarations: [
    AppComponent,
    AgregarEditarEmpleadoComponent,
    ListadoEmpleadosComponent,
    VerEmpleadoComponent,
    EliminarComponentComponent


  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
