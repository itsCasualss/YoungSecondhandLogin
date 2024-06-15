public class Hurricane : IAssignment
{
    public void Run()
    {
               
        System.Console.Write("Please enter the wind speed (mph): ");

        double windspeed = System.Convert.ToDouble(System.Console.ReadLine()); //converts user input to integer

        if (windspeed >= 157) {
            System.Console.WriteLine("Category 5 Hurricane");
        } else if (156 > windspeed && windspeed >= 130){ 
            System.Console.WriteLine("Category 4 Hurricane");
        } else if (130 > windspeed && windspeed >= 111){
            System.Console.WriteLine("Category 3 Hurricane");
        } else if(111 > windspeed && windspeed >= 96){
            System.Console.WriteLine("Category 2 Hurricane");
        } else if (96 > windspeed && windspeed >= 74){
            System.Console.WriteLine("Category 1 Hurricane");       
        } else if (74 > windspeed){
            System.Console.WriteLine("Not a Hurricane");
        }
    }
} 

// 152 mph, 97.913 mph, 70.55 mph,  175.99 mph