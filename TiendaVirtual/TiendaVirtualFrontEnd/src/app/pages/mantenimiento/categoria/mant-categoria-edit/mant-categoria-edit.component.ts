import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

import { CategoriaRequest } from 'src/app/models/categoria-request';
import { CategoriaResponse } from 'src/app/models/categoria-response';
import { CategoriaService } from 'src/app/service/categoria.service';

@Component({
  selector: 'app-mant-categoria-edit',
  templateUrl: './mant-categoria-edit.component.html',
  styleUrls: ['./mant-categoria-edit.component.scss']
})
export class MantCategoriaEditComponent implements OnInit {

  //FIXME: VARIABLES DE ENTRADA
  @Input() categoria: CategoriaResponse = new CategoriaResponse();

  //FIXME: VARIABLES DE SALIDA
  @Output() closeModalEmmit = new EventEmitter<boolean>();

  //FIXME: VARIABLES DE FORMULARIO
  myForm: FormGroup;
  //OTRAS VARIABLES
  categoriaRequest: CategoriaRequest = new CategoriaRequest();
  disabledButton: boolean = false;
  constructor(
    private fb: FormBuilder,
    private toastr: ToastrService,
    private _categoriaService: CategoriaService,
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
    //patch value, nos sirve para asignar valores a nuestro formulario
    this.myForm.patchValue(this.categoria);
  }


  btnGuardar() {
    this.disabledButton = true;
    this.categoriaRequest = this.myForm.getRawValue();
    /**
     * FIXME: ID = 0 ==> NUEVA CATEGORÍA | ELSE ==> ES EDICIÓN DE CATEGORÍA
     */

    // setTimeout(() => {
    if (this.categoriaRequest.id == 0) {
      this.crearCategoria();
    }
    else {
      this.editarCategoria();
    }

    // }, 2500);




  }


  crearCategoria() {
    //LLAMAR A NUESTRO SERVICIO
    this._categoriaService.create(this.categoriaRequest).subscribe(
      (result: CategoriaResponse) => {
        this.toastr.success('registro creado de forma satisfactoría', 'Felicitaciones!');
        console.log("Enviando valor de salida", true);

        this.closeModalEmmit.emit(true);
      },
      err => {
        this.toastr.error('error en la creación de nuestro registro', 'Error!');
      },
      //COMPLETE
      () => {
        this.toastr.warning('Operación Culminada', 'Felicitaciones!');
        this.disabledButton = false;
      }

    );
  }

  editarCategoria() {
    this._categoriaService.update(this.categoriaRequest).subscribe(
      (result: CategoriaResponse) => {
        this.toastr.success('Registro actualizado de forma satisfactoría', 'Felicitaciones!');
        console.log("Enviando valor de salida", true);

        this.closeModalEmmit.emit(true);
      },
      err => {
        this.toastr.error('error en la creación de nuestro registro', 'Error!');
      },
      //COMPLETE
      () => {
        this.toastr.warning('Operación Culminada', 'Felicitaciones!');
        this.disabledButton = false;
      }

    );
  }


  btnCancelar() {
    this.closeModalEmmit.emit(false);
  }
}