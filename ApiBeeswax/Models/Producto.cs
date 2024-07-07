namespace ApiBeeswax.Models
{
   
    public class Producto
    {
        public int id { get; set; }
        public required string nombreProducto { get; set; }
        public required string descripcion { get; set; } 
        public  required float precio { get; set; }
        public required string categoria { get; set; }
        public int stock { get; set; }
        public string imagen { get; set; }

    }
}
