namespace ManageAcademyWeb.Domain.Entity
{
    public abstract class BaseEntity
    {
        public DateTime? DataCreate { get; private set; }

        protected BaseEntity()
        {
            DataCreate = DateTime.Now;
        }
    }
}