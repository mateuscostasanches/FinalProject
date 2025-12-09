
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Sale : BaseEntity<int>
    {

        # region Empty Constructor
        public Sale()
        {
            SaleItems = new List<SaleItem>();
        }
        #endregion 

        #region Constuctor
        public Sale(int id, DateTime saleDate, decimal totalSale, Customer customer) : base(id)
        {
            TotalSale = totalSale;
            SaleDate = saleDate;
            Customer = customer;
            SaleItems = new List<SaleItem>();
        }
        #endregion 

        #region getters and setters
        public DateTime SaleDate { get; set; }
        public decimal TotalSale { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        #endregion

    }

    public class SaleItem : BaseEntity<int>
    {

        # region Empty Constructor
        public SaleItem()
        {
        }
        #endregion 

        #region Constructor
        public SaleItem(int id, Sale sale, Product product, Developer developer, decimal unitPrice) : base(id)
        {   
            Sale = sale;
            Product = product;
            Developer = developer;
            UnitPrice = unitPrice;
        }
        #endregion

        #region getters and setters
        public Sale Sale { get; set; }
        public Developer Developer { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        #endregion

    }

}