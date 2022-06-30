using HttpStatusCode.Models.Entities.Concrete;

namespace HttpStatusCode.Infrastucture.Repository.Abstract
{
    public interface ICategoryDAL : IBaseRepository<Category>
    {

        bool CheckName(string name);

    }
}
