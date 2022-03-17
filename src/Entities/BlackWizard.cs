namespace Jogo_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
            public BlackWizard(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints){}    

            public override string Attack()
            {
                return this.Name + " lançou magia negra.";
            }
    }
}
    
            