using System.ComponentModel.DataAnnotations;

namespace ManageAcademyWeb.Domain.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; private set; }
        public DateTime DataCreate { get; set; }

        protected BaseEntity(int id)
        {
            Id = id;
            DataCreate = DateTime.Now;
        }
    }
}