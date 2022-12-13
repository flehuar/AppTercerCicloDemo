export class CategoriaRequest {
    id: number;
    nombre: string | null;
    descripcion: string | null;
    estado: boolean | null;
    codigo: string | null;
    constructor() {
        this.id = 0;
        this.nombre = "";
        this.descripcion = "";
        this.estado = true;
        this.codigo = "";
    }
}