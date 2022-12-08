import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MantenimientoRoutingModule } from './mantenimiento-routing.module';
import { MantProductoEditComponent } from './producto/mant-producto-edit/mant-producto-edit.component';
import { MantProductoListComponent } from './producto/mant-producto-list/mant-producto-list.component';


@NgModule({
  declarations: [
  
    MantProductoEditComponent,
       MantProductoListComponent
  ],
  imports: [
    CommonModule,
    MantenimientoRoutingModule
  ]
})
export class MantenimientoModule { }
