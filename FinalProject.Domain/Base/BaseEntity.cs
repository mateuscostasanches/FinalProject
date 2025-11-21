
namespace FinalProject.Domain.Base
{

    public abstract class BaseEntity<TId> : IBaseEntity
    {
        //Empty Constructor
        public BaseEntity()
        {
        }

        //Constuctor with attributes
        public BaseEntity(TId id)
        {
            Id = id;
        }

        #region get and set
        public TId Id { get; set; }
        #endregion
    }

}
