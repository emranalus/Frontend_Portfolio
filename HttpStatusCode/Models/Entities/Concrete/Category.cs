using HttpStatusCode.Models.Entities.Abstract;

namespace HttpStatusCode.Models.Entities.Concrete
{
    public class Category : BaseEntity
    {

        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }

    }
}
