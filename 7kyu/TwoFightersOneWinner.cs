// Create a function that returns the name of the winner in a fight between two fighters.

// Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

// Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

// Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.
// Example:

//   declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"
  
//   Lew attacks Harry; Harry now has 3 health.
//   Harry attacks Lew; Lew now has 6 health.
//   Lew attacks Harry; Harry now has 1 health.
//   Harry attacks Lew; Lew now has 2 health.
//   Lew attacks Harry: Harry now has -1 health and is dead. Lew wins.

// public class Fighter {
//   public string Name;
//   public int Health, DamagePerAttack;
//   public Fighter(string name, int health, int damagePerAttack) {
//     this.Name = name;
//     this.Health = health;
//     this.DamagePerAttack = damagePerAttack;
//   }
// }

// my solution - larsa-mrp

public class Kata {
  public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker){
    bool firstAttack = fighter1.Name == firstAttacker; // which player is attacking first
    
    if(firstAttack){ // fighter 1 goes first
      do{
        fighter2.Health -= fighter1.DamagePerAttack;
        if(fighter2.Health <= 0){break;}
        fighter1.Health -= fighter2.DamagePerAttack;
      }while (fighter1.Health > 0 && fighter2.Health > 0);
    }
    else{ // fighter 2 goes first
      do{
        fighter1.Health -= fighter2.DamagePerAttack;
        fighter2.Health -= fighter1.DamagePerAttack;     
      }while (fighter1.Health > 0 && fighter2.Health > 0);
    }
    return fighter1.Health <= 0 ? fighter2.Name : fighter1.Name;
  }
}