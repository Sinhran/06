using _06.Classes;
using _06.Interfaces;

// IAnimal[] animals = {
//   new Dog(),
//   new Cat()
// };
//
// foreach (var a in animals) {
//   a.Speak();
//
//   if (a is Cat) {
//     ((Cat)a).Play(30);
//   } else if (a is Dog) {
//     Dog d = (Dog)a;
//     d.Play(30);
//   }
// }


ICombatant[] fighters = {
  new Warrior { Name = "Aragorn", Health = 100, AttackPower = 25 },
  new Mage { Name = "Merlin", Health = 80, AttackPower = 40 }
}; 

foreach (var fighter in fighters) {
  fighter.Attack();
  fighter.Defend();

  if (fighter is Mage mage) {
    mage.Heal(30);
  }
}

Knight knight = new Knight();

IAttack attack = knight;
attack.Attack();

IDefend defend = knight;
defend.Attack();
