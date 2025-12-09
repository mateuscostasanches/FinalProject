
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Product : BaseEntity<int>
    {

        #region Empty Constructor
        public Product()
        {
        }
        #endregion 

        #region Constuctor
        public Product(int id, string name, string description, decimal price,
                       DateTime releaseDate, Category category, Developer developer) : base(id)
        {
            Name = name;
            Description = description;
            Price = price;
            ReleaseDate = ReleaseDate;
            Category = category;
            Developer = developer;
        }
        #endregion 

        #region getters and setters
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Category Category { get; set; }
        public Developer Developer { get; set; }
        #endregion

    }

}

