import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MantCategoriaListComponent } from './categoria/mant-categoria-list/mant-categoria-list.component';
import { MantProductoListComponent } from './producto/mant-producto-list/mant-producto-list.component';

const routes: Routes = [
  {
    path: 'producto',
    component: MantProductoListComponent
  },
  {
    path: 'categoria',
    component: MantCategoriaListComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MantenimientoRoutingModule { }
