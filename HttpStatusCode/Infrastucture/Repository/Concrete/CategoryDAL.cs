using HttpStatusCode.Infrastucture.Repository.Abstract;
using HttpStatusCode.Models.Entities.Concrete;

namespace HttpStatusCode.Infrastucture.Repository.Concrete
{
    public class CategoryDAL : RepositroyBase<Category>, ICategoryDAL
    {
        public bool CheckName(string name)
        {
            var result = base.FindAll(p => p.CategoryName == name);

            if (result.Count() > 0)
            {
                return true;
            }

            // else
            return false;
        }
    }
}
