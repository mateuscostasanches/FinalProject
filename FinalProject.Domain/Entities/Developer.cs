
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Developer : BaseEntity<int>
    {
        //Empty Constructor
        public Developer()
        {
        }

        //Constuctor with attributes
        public Developer(int id, string name, string email, string password, Address address, DateTime registerDate) : base(id)
        {
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            RegisterDate = registerDate;
        }

        #region getters and setters
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }
        #endregion

    }

}