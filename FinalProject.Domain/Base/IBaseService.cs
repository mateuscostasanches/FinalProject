
using FluentValidation;

namespace FinalProject.Domain.Base
{

    public interface IBaseService<TEntity> where TEntity : IBaseEntity
    {

        #region Methods
        public void AttachObject(Object obj);

        TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputmodel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;

        void Delete(int id);

        IEnumerable<TOutputModel> Get<TOutputModel>(IList<string> includes = null) where TOutputModel : class;

        TOutputModel GetById<TOutputModel>(int id, IList<string>? includes = null) where TOutputModel : class;

        TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;

        #endregion

    }

}