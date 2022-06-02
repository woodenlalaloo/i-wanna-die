using System;
public class brokenDeath{
  public static void wrongAnswer(){
    Console.WriteLine("Wrong answer, telling your character to do something they can't is like telling a calculator to divide by 0. You just can't.");
    Console.WriteLine("The fabric of space and time rips apart at the seams and your character is sucked in, instantly killing them. Game over.");
    Console.WriteLine("Would you like to respawn? Type 1 to respawn, 2 to exit.");
    string respawnChoice = Console.ReadLine();
    if(respawnChoice == "1"){
      Console.WriteLine("Respawning...");
    }
    else if(respawnChoice == "2"){
      Console.WriteLine("Exiting...");
      Environment.Exit(0);
    }
    else{
      Console.WriteLine("Thats not funny.");
          Console.WriteLine("Would you like to respawn? Type 1 to respawn, 2 to exit.");
    string respawnChoice2 = Console.ReadLine();
    if(respawnChoice2 == "1"){
      Console.WriteLine("Respawning...");
    }
    else if(respawnChoice2 == "2"){
      Console.WriteLine("Exiting...");
      Environment.Exit(0);
    }
    else{
      Console.WriteLine("f**k you");
      Environment.Exit(0);
      }
    }
  }
}