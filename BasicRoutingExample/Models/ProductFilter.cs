namespace BasicRoutingExample.Models
{
    //these automatic properties are used to transfer the data purpose used.
    //one class to another clas we can transfer the data by usig this properties.
    public class ProductFilter
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
