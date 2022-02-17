namespace AbstraçãoRPG.Class
{
    public class Wizard : Hero
    {

        public Wizard(string name, int level, string heroType)
        {   
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            
        }
        public override string Attack()
        {
            return this.name + " lançou uma magia!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.name + " lançou uma magia com bonus de: "+bonus;
            }
            else if(bonus > 15)
            {
                return this.name + " lançou uma magia com bonus CRÍTICO de: "+bonus;
            }
            
            return Attack();
        }
    }
}