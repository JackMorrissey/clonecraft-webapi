namespace CloneCraft.Models.Interfaces
{
    public interface IEntity : ICoordinate
    {
        int Id { get; }
        int Size { get; }
    }
}
