import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Empleado } from '../interfaces/empleadoView';

@Injectable({
  providedIn: 'root',
})
export class EmpleadoService {
  url: string = 'https://localhost:44380/api/Empleados';

  constructor(private http: HttpClient) {}

  getEmpleados(): Observable<Empleado[]> {
    return this.http.get<Empleado[]>(this.url);
  }
  getEmpleado(id: number): Observable<Empleado> {
    return this.http.get<Empleado>(`${this.url}/${id}`);
  }

  deleteEmpleado(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }

  addEmpleado(empleado: Empleado): Observable<Empleado> {
    return this.http.post<Empleado>(`${this.url}`, empleado);
  }
  updateEmpleado(id: number, empleado: Empleado): Observable<void> {
    return this.http.put<void>(`${this.url}/${id}`, empleado);
  }
}
