namespace BookManager.API.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
            UpdateAt = null;
            IsDeleted = false;
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsDeleted { get; private set; }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
