public class Twitter : IAssignment
{
    public void Run()
    {
        
        System.Console.Write("Type your Tweet Here: ");
        
        string userinput = System.Console.ReadLine();

        if (userinput.Length <= 140)
        {
            System.Console.WriteLine("Posted!");
            }

        else{

            System.Console.WriteLine("Rejected!");
            
        }

        
    }
} 