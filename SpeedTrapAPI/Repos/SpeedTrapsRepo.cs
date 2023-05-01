using SpeedTrapAPI.Model;
using System.Runtime.CompilerServices;

namespace SpeedTrapAPI.Repos
{
    public class SpeedTrapsRepo
    {
        public List<SpeedTrap> _items;
        public SpeedTrapsRepo() 
        {
            _items = new List<SpeedTrap>();
        }
        public List<SpeedTrap> GetAll()
        {
            return _items;
        }
        public void Create(SpeedTrap item) 
        {
            item.BustedAt = DateTime.Now;
            _items.Add(item);
        }
    }
}
