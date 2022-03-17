namespace Jogo_RPG.src.Entities
{
    public class Wizard : Hero  
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints){}

    public override string Attack()
    {
        return this.Name + " lançou magia.";
    }

    public string Attack(int Bonus)
        {
            if (Bonus > 6){
            return this.Name + " lançou magia super efetiva com bônus de " + Bonus;
        }else
            return this.Name + " lançou uma magia com força fraca com bônus de " + Bonus;
        }
    }
}