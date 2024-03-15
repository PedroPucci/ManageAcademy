namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }

        public DateTime? CreateDate { get; private set; }
        public DateTime? ModificationDate { get; set; }

        protected BaseEntity()
        {
            CreateDate = DateTime.UtcNow;
        }
    }
}