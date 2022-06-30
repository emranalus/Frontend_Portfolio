namespace HttpStatusCode.Models.Entities.Abstract
{

    public enum Status
    {
        Active,
        Modified,
        Passive
    }

    public abstract class BaseEntity
    {

        public int Id { get; set; }

        // Encapsulation
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        // Encapsulation
        private Status _status = Status.Active;

        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }



    }
}
