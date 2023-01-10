namespace WebApplication1.Model
{
    //T Puede tomar el objeto de cualquier clase
    // ==> fruta, categoria, producto, persona
    public class GenericFilterResponse<T>
    {
        /// <summary>
        /// Cantidad de elementos encontrados
        /// </summary>
        public int totalRecord { get; set; }
        /// <summary>
        /// Cantidad de paginas que vamos a encontrar 
        /// </summary>
        public int totalPage { get; set; }
        /// <summary>
        /// Lista encontrada
        /// </summary>
        public List<T> list { get; set; }
    }
}
