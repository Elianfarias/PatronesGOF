using Factory.Enemies.Interfaces;

namespace Factory.Enemies
{
    public class Skeleton : IEnemy
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public int Difficulty { get; set; }
        public int Arrows { get; set; }
    }
}
