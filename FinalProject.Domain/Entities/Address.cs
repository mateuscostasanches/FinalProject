
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Address : BaseEntity<int>
    {

        //Empty Constructor
        public Address()
        {
        }

        //Constuctor with attributes
        public Address(int id, string country, string state, string city) : base(id)
        {
            Country = country;
            State = state;
            City = city;
        }

        #region getters and setters
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        #endregion

    }

}