import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MantProductoListComponent } from './producto/mant-producto-list/mant-producto-list.component';

const routes: Routes = [
  {
    path: 'producto',
    component: MantProductoListComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MantenimientoRoutingModule { }
