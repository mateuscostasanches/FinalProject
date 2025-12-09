
namespace FinalProject.Domain.Base
{

    public abstract class BaseEntity<TId> : IBaseEntity

    {
        #region Constructors
        public BaseEntity()
        {
        }

        public BaseEntity(TId id)
        {
            Id = id;
        }
        #endregion 

        #region get and set
        public TId Id { get; set; }
        #endregion

    }

}
