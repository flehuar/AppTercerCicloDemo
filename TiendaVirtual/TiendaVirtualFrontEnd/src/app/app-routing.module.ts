import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [
  {
    path:'',
    loadChildren:()=> import("./pages/home/home.module").then(x => x.HomeModule)
  },
  {
    path:'auth',
    loadChildren:()=> import("./pages/auth/auth.module").then(x => x.AuthModule)
  },
  {
    path:'dashboard',
    loadChildren:()=> import("./pages/dashboard/dashboard.module").then(x => x.DashboardModule)
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes,{useHash:true})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
