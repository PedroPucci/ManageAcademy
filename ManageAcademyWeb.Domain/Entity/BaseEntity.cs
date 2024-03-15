using System.ComponentModel.DataAnnotations;

namespace ManageAcademyWeb.Domain.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; private set; }

        public DateTime? CreateDate { get; private set; }
        public DateTime? ModificationDate { get; set; }

        protected BaseEntity()
        {
            CreateDate = DateTime.UtcNow;
        }
    }
}