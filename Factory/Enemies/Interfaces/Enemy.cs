namespace Factory.Enemies.Interfaces
{
    public interface IEnemy
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public int Difficulty { get; set; }
    }
}
