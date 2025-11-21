
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Product : BaseEntity<int>
    {

        //Empty Constructor
        public Product()
        {
        }

        //Constuctor with attributes
        public Product(int id, string name, string description, decimal price, decimal rating,
                       DateTime purchaseDate, Category category) : base(id)
        {
            Name = name;
            Description = description;
            Price = price;
            Rating = rating;
            PurchaseDate = purchaseDate;
            Category = category;
            Achivements = new List<Achivement>();
        }

        #region getters and setters
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Category Category { get; set; }
        public List<Achivement> Achivements { get; set; }
        #endregion

    }

    public class Achivement : BaseEntity<int>
    {

        //Empty Constructor 
        public Achivement()
        {
        }

        //Constuctor with attributes
        public Achivement(int id, string name, string description, bool isAchived) : base(id)
        {
            Name = name;
            Description = description;
            IsAchived = isAchived;
        }

        #region getters and setters
        public Product Product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAchived { get; set; }
        #endregion

    }

}

