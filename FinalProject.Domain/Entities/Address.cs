
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Address : BaseEntity<int>
    {

        #region Empty Constructor
        public Address()
        {
        }
        #endregion

        #region Constructor
        public Address(int id, string state, string city) : base(id)
        {
            State = state;
            City = city;
        }
        #endregion 

        #region getters and setters
        public string State { get; set; }
        public string City { get; set; }

        public static implicit operator Address(string v)
        {
            throw new NotImplementedException();
        }
        #endregion

    }

}