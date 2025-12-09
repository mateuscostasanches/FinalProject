
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Customer : BaseEntity<int>
    {

        #region Empty Constructor
        public Customer()
        {
        }
        #endregion

        #region Constuctor
        public Customer(int id, string name, string email, string password,
                        Address address, DateTime registerDate) : base(id)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            RegisterDate = registerDate;
        }
        #endregion 

        #region getters and setters
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public DateTime RegisterDate { get; set; }
        #endregion

    }

}