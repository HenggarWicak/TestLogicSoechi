namespace _10112022_Soechi.Models
{
    public class FormModel
    {
        public string ItemDescription { get; set; }   
        public List<ItemList> uoms { get; set; }
        public int? Rate { get; set; }   
        public int? QTY { get; set; }    
        public int? QTYKecil { get; set; }   
        public decimal? UnitPrice { get; set; }
        public string Discount { get; set; } 
        public decimal DiscountAmt { get; set; }
        public decimal Total { get; set; } 
    }

    public class ItemList
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
