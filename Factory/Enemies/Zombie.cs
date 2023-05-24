using Factory.Enemies.Interfaces;

namespace Factory.Enemies
{
    public class Zombie : IEnemy
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public int Difficulty { get; set; }
    }
}
