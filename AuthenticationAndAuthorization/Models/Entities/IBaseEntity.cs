namespace AuthenticationAndAuthorization.Models.Entities
{

    public enum Status
    {
        Active = 1,
        Modified = 2,
        Passive = 3
    }

    public interface IBaseEntity
    {

        //public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

    }
}
