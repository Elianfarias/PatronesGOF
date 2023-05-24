using Factory.Enemies;
using Factory.Enemies.Interfaces;
using Factory.Factory.Interfaces;

namespace Factory.Factory
{
    public class RandomEnemyGenerator : IEnemyFactory
    {
        public IEnemy GetEnemy()
        {
            IDictionary<TypeEnemy, IEnemy> enemyGenerator = new Dictionary<TypeEnemy, IEnemy>
            {
                { TypeEnemy.ZOMBIE, new Zombie()},
                { TypeEnemy.SKELETON, new Skeleton()}
            };
            
            return enemyGenerator[GetRandomTypeEnemy()];
        }

        public void GetRandomEnemies(int cant)
        {
            IDictionary<TypeEnemy, string> enemyGenerator = new Dictionary<TypeEnemy, string>
            {
                { TypeEnemy.ZOMBIE, "Se ha generado un zombie!"},
                { TypeEnemy.SKELETON, "Se ha generado un esqueleto!" }
            };

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine(enemyGenerator[GetRandomTypeEnemy()]);
            }
        }

        private TypeEnemy GetRandomTypeEnemy()
        {
            var values = Enum.GetValues(typeof(TypeEnemy));
            Random random = new Random();
            int index = random.Next(values.Length);

            return (TypeEnemy)values.GetValue(index);
        }
    }
}
