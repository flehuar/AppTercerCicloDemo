import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MantenimientoRoutingModule } from './mantenimiento-routing.module';
import { ModalModule } from 'ngx-bootstrap/modal';


import { MantProductoEditComponent } from './producto/mant-producto-edit/mant-producto-edit.component';
import { MantProductoListComponent } from './producto/mant-producto-list/mant-producto-list.component';
import { MantCategoriaListComponent } from './categoria/mant-categoria-list/mant-categoria-list.component';
import { MantCategoriaEditComponent } from './categoria/mant-categoria-edit/mant-categoria-edit.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [

    MantProductoEditComponent,
    MantProductoListComponent,
    MantCategoriaListComponent,
    MantCategoriaEditComponent
  ],
  imports: [
    CommonModule,
    MantenimientoRoutingModule,
    ModalModule.forRoot(),
    FormsModule,
    ReactiveFormsModule
  ]
})
export class MantenimientoModule { }
