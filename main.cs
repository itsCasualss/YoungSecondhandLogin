using System;

class Program{
  public static void Main(string[] args){

    System.Console.WriteLine(UnitTestOne ("Lucinda Potter", "6/24/1992","000-000-0101","000-000-0189"));
  static string UnitTestOne (string name, string dob, string work, string cell){
    return name + "\n" + dob + "\n" + work + "\n"+ cell + "\n";}
    
    System.Console.WriteLine(UnitTestTwo("John Smith","8/15/1978","000-111-0101","000-111-0189"));
  static string UnitTestTwo (string name, string dob, string work, string cell){
    return name + "\n" + dob + "\n" + work + "\n"+ cell + "\n";}
    System.Console.WriteLine(UnitTestThree("Chris Johnson","12/01/1987","000-222-0101","000-222-0189"));
    static string UnitTestThree (string name, string dob, string work, string cell){
      return name + "\n" + dob + "\n" + work + "\n"+ cell + "\n";}
    System.Console.WriteLine(UnitTestFour("Robert Hall","2/27/1949","000-444-0101","000-444-0189"));
    static string UnitTestFour (string name, string dob, string work, string cell){
      return name + "\n" + dob + "\n" + work + "\n"+ cell;}
    }
  
  }
