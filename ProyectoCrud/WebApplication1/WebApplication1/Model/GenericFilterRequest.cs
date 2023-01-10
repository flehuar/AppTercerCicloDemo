namespace WebApplication1.Model
{
    public class GenericFilterRequest
    {
        public int page { get; set; }
        public int quantity { get; set; }
        public List<ItemFilter> filters { get; set; }
    }

    public class ItemFilter
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
