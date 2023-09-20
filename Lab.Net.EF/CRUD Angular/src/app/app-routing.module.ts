import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//Componentes 
import { ListadoEmpleadosComponent } from './components/listado-empleados/listado-empleados.component';
import { AgregarEditarEmpleadoComponent } from './components/agregar-editar-empleado/agregar-editar-empleado.component';
import { VerEmpleadoComponent } from './components/ver-empleado/ver-empleado.component';
import { EliminarComponentComponent } from './components/eliminar-component/eliminar-component.component';

const routes: Routes = [
  {path:'', redirectTo:'listEmpleados', pathMatch:'full'},
  {path:'listEmpleados', component: ListadoEmpleadosComponent},
  {path:'agregarEmpleado', component: AgregarEditarEmpleadoComponent},
  {path:'verEmpleado/:id', component: VerEmpleadoComponent},
  {path:'editarEmpleado/:id', component: AgregarEditarEmpleadoComponent},
  {path:'**', redirectTo:'listEmpleados', pathMatch:'full'},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
