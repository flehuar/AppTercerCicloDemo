import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { TemplateComponent } from './template/template.component';
import { TemplateHeaderComponent } from './template-header/template-header.component';
import { TemplateSidebarComponent } from './template-sidebar/template-sidebar.component';
import { TemplateFooterComponent } from './template-footer/template-footer.component';


@NgModule({
  declarations: [
    TemplateComponent,
    TemplateHeaderComponent,
    TemplateSidebarComponent,
    TemplateFooterComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule
  ]
})
export class DashboardModule { }
