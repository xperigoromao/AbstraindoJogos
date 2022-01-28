using abstraindo_jogo_rpg.Entities;

namespace abstraindo_jogo_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " atacou usando magia.";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " atacou usando magia super efetiva com bônus de " + Bonus;
            } else{
                return this.Name + " atacou usando magia fraca com bônus de " + Bonus;
            }
            
        }
    }
}