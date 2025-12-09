
namespace FinalProject.App.ViewModel
{

    public class SaleViewModel
    {

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalSale { get; set; }
        public string Customer { get; set; }
    }

    public class SaleItemViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int DeveloperId { get; set; }
        public string Product { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Developer { get; set; }
    }

}
