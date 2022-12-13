import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MantCategoriaEditComponent } from './mant-categoria-edit.component';

describe('MantCategoriaEditComponent', () => {
  let component: MantCategoriaEditComponent;
  let fixture: ComponentFixture<MantCategoriaEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MantCategoriaEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MantCategoriaEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
