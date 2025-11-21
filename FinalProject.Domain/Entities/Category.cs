
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Category : BaseEntity<int>
    {

        //Empty Constructor
        public Category()
        {
        }

        //Constructor with attributes
        public Category(int id, string name) : base(id)
        {
            Name = name;
        }

        #region getters and setters
        public string Name { get; set; }
        #endregion

    }

}