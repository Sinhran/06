using _06.Interfaces;

namespace _06.Classes;

public class Cat : IAnimal {
  public void Speak() {
    Console.WriteLine("Meow!");
  }
  
  public string Play(int minutes) {
    Console.WriteLine($"You played with the cat for {minutes} minutes.");
    return "Annoyed";
  }
}
