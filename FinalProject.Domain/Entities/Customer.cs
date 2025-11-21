
using FinalProject.Domain.Base;

namespace FinalProject.Domain.Entities
{

    public class Customer : BaseEntity<int>
    {

        //Empty Constructor
        public Customer()
        {
        }

        //Constuctor with attributes
        public Customer(int id, string name, string nickname, string email, string description, string password,
                        Address address, DateTime registerDate, DateTime loginDate, bool isActive) : base(id)
        {
            Name = name;
            Nickname = nickname;
            Email = email;
            Description = description;
            Password = password;
            Address = address;
            RegisterDate = registerDate;
            LoginDate = loginDate;
            IsActive = isActive;
        }

        #region getters and setters
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

    }

}