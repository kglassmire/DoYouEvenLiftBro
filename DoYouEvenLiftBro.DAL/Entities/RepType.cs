namespace DoYouEvenLiftBro.DAL.Entities
{
    public class RepType : BaseEntity
    {
        public string Name { get; set; }
        public User User { get; set; }
    }
}