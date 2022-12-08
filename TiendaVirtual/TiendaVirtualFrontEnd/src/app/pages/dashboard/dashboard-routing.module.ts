import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TemplateComponent } from './template/template.component';

const routes: Routes = [
  {
    path: '',
    component: TemplateComponent
    //rutas hijas
    , children: [
      {
        path: 'mantenimiento',
        loadChildren: () => import("./../mantenimiento/mantenimiento.module").then(x => x.MantenimientoModule)
      },
      {
        path: 'reportes',
        loadChildren: () => import("./../reportes/reportes.module").then(x => x.ReportesModule)
      },
      {
        path: 'ventas',
        loadChildren: () => import("./../ventas/ventas.module").then(x => x.VentasModule)
      }
    ]
  },


];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
