namespace CoreIndustriaHuitzil.ModelsRequest
{
    public class SearchProductFilters
    {
        public string QueryString { get; set; }
        public string Sucursal { get; set; }
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public string Talla { get; set; }
        public string Ubicacion { get; set; }

        public string Categoria { get; set; }
        
        public int Page { get; set; }
        public int Size { get; set; }
    }
}