
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Category : BaseEntity<int>
    {

        #region Empty Constructor
        public Category()
        {
        }
        #endregion

        #region  Constructor with attributes
        public Category(int id, string name) : base(id)
        {
            Name = name;
        }
        #endregion 

        #region getters and setters
        public string Name { get; set; }
        #endregion

    }

}