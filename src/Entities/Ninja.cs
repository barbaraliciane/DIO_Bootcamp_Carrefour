namespace Jogo_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints)
        {
        }

        public override string Attack()
            {
                return this.Name + " atacou com a kunai";
            }
    }
}