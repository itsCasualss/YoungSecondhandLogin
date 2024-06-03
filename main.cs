using System;

class Program{
  public static void Main(string[] args){

    System.Console.WriteLine(SongOne ("Oh, well imagine", "As I'm pacing the pews in a church corridor","And I can't help but to hear","No, I can't help but to hear an exchanging of words..."));
  static string SongOne (string lineone, string linetwo, string linethree, string linefour){
    return lineone + "\n" + linetwo + "\n" + linethree + "\n"+ linefour + "\n";}
    
    System.Console.WriteLine(SongTwo("Oh-oh-oh-oh-oh,", "oh-oh-oh-oh,","oh-oh-oh","Caught in a bad romance..."));
    static string SongTwo (string lineone, string linetwo, string linethree, string linefour){
      return lineone +"\n"+ linetwo +"\n"+ linethree + "\n"+ linefour + "\n";}
    
    System.Console.WriteLine(SongThree("Coming out of my cage", "And I've been doing just fine","Gotta gotta be down","Because I want it all"));
    static string SongThree (string lineone, string linetwo, string linethree, string linefour){
      return lineone + "\n" + linetwo + "\n" + linethree + "\n"+ linefour + "\n";}
    
    System.Console.WriteLine(SongFour("Now, this is a story all about how", "My life got flipped-turned upside down","And I'd like to take a minute","Just sit right there", "I'll tell you how I became the prince of a town called Bel-Air"));
    static string SongFour (string lineone, string linetwo, string linethree, string linefour, string linefive){
      return lineone + "\n" + linetwo + "\n" + linethree + "\n"+ linefour + "\n" + linefive;}
    }

  }