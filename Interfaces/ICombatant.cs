namespace _06.Interfaces;

public interface ICombatant : ICharacter {
  int AttackPower { get; set; }

  void Attack();
  void Defend();
}
