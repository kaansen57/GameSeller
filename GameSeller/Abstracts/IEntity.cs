namespace GameSeller
{
     public interface IEntity
    {
        void Insert(IGamer gamer);
        void Delete(IGamer gamer);
        void Update(IGamer gamer);

    }
}