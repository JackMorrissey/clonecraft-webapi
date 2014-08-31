namespace CloneCraft.Models.Interfaces
{
    public interface IEntity : ICoordinate
    {
        int Id { get; set; }
        int Size { get; }
    }
}
