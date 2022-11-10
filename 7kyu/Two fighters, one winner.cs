//Create a function that returns the name of the winner in a fight between two fighters.

//Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

//Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

//Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

//Your function also receives a third argument, a string, with the name of the fighter that attacks first.

namespace CodeWars_Katas._7kyu
{
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
    internal class Two_fighters__one_winner
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            // Your code goes here. Have fun!
            if (firstAttacker == fighter1.Name)
            {
                while (fighter1.Health > 0 || fighter2.Health > 0)
                {
                    fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                        return fighter1.Name;
                    else
                        fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                        return fighter2.Name;
                }
            }
            else if (firstAttacker == fighter2.Name)
            {
                while (fighter1.Health > 0 || fighter2.Health > 0)
                {
                    fighter1.Health = fighter1.Health - fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                        return fighter2.Name;
                    else
                        fighter2.Health = fighter2.Health - fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                        return fighter1.Name;
                }
            }
            return fighter1.Name;
        }
    }
}
