using Microsoft.AspNetCore.Identity;

namespace AuthenticationAndAuthorization.Models.Entities
{
    public class AppUser : IdentityUser, IBaseEntity
    {
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        private Status _status = Status.Active;

        public Status Status
        {
            get => _status;
            set => _status = value;
        }

        public string? TcNo { get; set; }

    }
}
