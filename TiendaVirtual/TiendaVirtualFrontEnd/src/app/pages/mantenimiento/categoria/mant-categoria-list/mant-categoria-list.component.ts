import { Component, OnInit, TemplateRef } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import Swal from 'sweetalert2';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';

import { CategoriaResponse } from 'src/app/models/categoria-response';
import { CategoriaService } from 'src/app/service/categoria.service';

@Component({
  selector: 'app-mant-categoria-list',
  templateUrl: './mant-categoria-list.component.html',
  styleUrls: ['./mant-categoria-list.component.scss']
})
export class MantCategoriaListComponent implements OnInit {

  modalRef?: BsModalRef;
  tituloModal: string = "";
  listaCategoria: CategoriaResponse[] = [];
  categoria_seleccionada: CategoriaResponse = new CategoriaResponse();
  constructor(
    private _categoriaService: CategoriaService,
    private toastr: ToastrService,
    private modalService: BsModalService
  ) {

  }

  ngOnInit(): void {
    console.log("iniciando");
    this.getAllCategorias();
  }

  getAllCategorias() {
    this._categoriaService.getAll().subscribe(
      (data: CategoriaResponse[]) => {
        this.listaCategoria = data;
        console.log(this.listaCategoria);

      },
      err => {
        console.log("errorrrrrrr");

      },
      //cuando los pasos anteriores se hayan completado
      () => {
        console.log("3333333333333");
      }
    );
    console.log("esto está fuera - del servicio de categoría");
  }


  btnEliminar(obj: CategoriaResponse) {
    Swal.fire({
      title: "¿Está seguro de eliminar este registro?",
      text: 'Este proceso no es revertible',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Si, Eliminalo!'
    }).then((result) => {

      if (result.isConfirmed) {
        this.eliminarCategoria(obj.id);
      }
      else {
        console.log("no hacer nada");
      }

      return result.isConfirmed;
    }
    ).catch((er) => {
      console.log("ocurrio un error");
      return false;
    });
  }

  eliminarCategoria(id: number) {
    this._categoriaService.delete(id).subscribe(
      (data: number) => {
        this.toastr.success('Registro eliminado de forma satisfactoría', 'Felicitaciones!');
      },
      err => {
        this.toastr.error('Error!', 'No se pudo eliminar el registro correspondiente');
      },
      () => {
      }
    );
  }


  btnEditar(template: TemplateRef<any>, obj: CategoriaResponse) {
    this.tituloModal = "Editar Categoría";
    this.categoria_seleccionada = obj;
    console.log(this.categoria_seleccionada);
    
    this.openModal(template);

  }

  btnAgregar(template: TemplateRef<any>) {
    this.tituloModal = "Nueva Categoría";
    this.categoria_seleccionada = new CategoriaResponse();
    console.log(this.categoria_seleccionada);
    
    this.openModal(template);
  }


  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

}
