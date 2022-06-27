namespace TechnicalChallenge.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public abstract string SelfDescription();
        public abstract string ShiftLength();
    }
}
