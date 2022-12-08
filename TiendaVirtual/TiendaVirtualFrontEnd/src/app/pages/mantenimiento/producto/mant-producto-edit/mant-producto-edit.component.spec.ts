import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MantProductoEditComponent } from './mant-producto-edit.component';

describe('MantProductoEditComponent', () => {
  let component: MantProductoEditComponent;
  let fixture: ComponentFixture<MantProductoEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MantProductoEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MantProductoEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
