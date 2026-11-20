using _06.Interfaces;

namespace _06.Classes;

public class Dog : IAnimal {
  public void Speak() {
    Console.WriteLine("Woof!");
  }

  public string Play(int minutes) {
    Console.WriteLine($"You can play with the dog for {minutes} minutes.");

    if (minutes >= 30) {
      return "Happy";
    } else {
      return "Sad";
    }
  }
}
