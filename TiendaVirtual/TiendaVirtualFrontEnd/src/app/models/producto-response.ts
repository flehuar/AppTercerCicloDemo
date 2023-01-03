export class ProductoResponse {
    id: number;
    categoria: string | null;
    nombre: string | null;
    stock: number | null;
    fechaVencimiento: string | null;
    costoSinIgv: number | null;
    costoConIgv: number | null;
    constructor() {
        this.id = 0;
        this.categoria = "";
        this.nombre = "";
        this.stock = 0;
        this.fechaVencimiento = "";
        this.costoSinIgv = 0;
        this.costoConIgv = 0;
    }
}