using System;

class Program{
  public static void Main(string[] args){

    System.Console.WriteLine(ConcatName ("Lucinda Potter", "6/24/1992","000-000-0101","000-000-0189"));
  static string ConcatName (string name, string dob, string work, string cell){
    return name + "\n" + dob + "\n" + work + "\n"+ cell;}
    }
  }
