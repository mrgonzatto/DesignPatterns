namespace AbstractFactory.Common
{
    public abstract class LevelElementFactory
    {
        public abstract IEnemy CreateEnemy();
        public abstract IWeapon CreateWeapon();
        public abstract IPowerUp CreatePowerUp();

        public void SetupEnvironment()
        {
            var enemy = CreateEnemy();
            var weapon = CreateWeapon();
            var powerUp = CreatePowerUp();
        }
    }
}