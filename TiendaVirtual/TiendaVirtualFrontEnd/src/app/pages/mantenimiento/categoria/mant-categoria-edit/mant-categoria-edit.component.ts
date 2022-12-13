import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CategoriaResponse } from 'src/app/models/categoria-response';

@Component({
  selector: 'app-mant-categoria-edit',
  templateUrl: './mant-categoria-edit.component.html',
  styleUrls: ['./mant-categoria-edit.component.scss']
})
export class MantCategoriaEditComponent implements OnInit {

  //VARIABLES DE ENTRADA
  @Input() categoria:CategoriaResponse = new CategoriaResponse();
  myForm: FormGroup;


  constructor(
    private fb: FormBuilder,
  ) {
    this.myForm = this.fb.group({
      id: [{ value: 0, disabled: true }, [Validators.required]],
      nombre: [null, [Validators.required]],
      descripcion: [null, [Validators.required]],
      estado: [null, [Validators.required]],
      codigo: [null, [Validators.required]],
    });
  }

  ngOnInit(): void {
    this.myForm.patchValue(this.categoria);
    console.log("variable entrada ==> ", this.categoria);
    
  }

}