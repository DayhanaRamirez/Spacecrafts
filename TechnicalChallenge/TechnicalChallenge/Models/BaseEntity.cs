namespace TechnicalChallenge.Models
{
    //Base class for all the domain entities
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public abstract string SelfDescription();
        public abstract string ShiftLength();
    }
}
