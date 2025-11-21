
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Sale : BaseEntity<int>
    {
        //Empty Constructor
        public Sale()
        {
        }

        //Constuctor with attributes
        public Sale(int id, DateTime saleDate, Developer developer, Customer customer) : base(id)
        {
            SaleDate = saleDate;
            Developer = developer;
            Customer = customer;
            SaleItems = new List<SaleItem>();
        }

        #region getters and setters
        public DateTime SaleDate { get; set; }
        public Developer Developer { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        #endregion

    }

    public class SaleItem : BaseEntity<int>
    {

        //Empty Constructor
        public SaleItem()
        {
        }

        //Constuctor with attributes
        public SaleItem(int id, Sale sale, Product product, decimal unityPrice, decimal totalPrice, decimal discount, int quantity) : base(id)
        {
            Sale = sale;
            Product = product;
            UnityPrice = unityPrice;
            TotalPrice = totalPrice;
            Discount = discount;
            Quantity = quantity;
            Quantity = quantity;
        }

        #region getters and setters
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal UnityPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        #endregion

    }

}