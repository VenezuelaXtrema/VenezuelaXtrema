using Microsoft.AspNetCore.Identity;

namespace Store.Domain.Entities.User
{
    public class User : IdentityUser<Guid>
    {
        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid ModifiedBy { get; set; }

        public DateTime ModifiedAt { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        public bool IsDeleted { get; set; }
    }
}
