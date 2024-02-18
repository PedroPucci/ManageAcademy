using System.ComponentModel.DataAnnotations;

namespace ManageAcademyWeb.Domain.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; private set; }

        public DateTime? DataCreate { get; private set; }

        protected BaseEntity()
        {
            DataCreate = DateTime.Now;
        }
    }
}