using GameSeller.Abstracts;

namespace GameSeller
{
     public interface IGamerDatabaseManager
    {
        void Insert(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}