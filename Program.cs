namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Angelica Lindström, Sundsvall .NET23
            

            //Declared an integer variable with the value of 33 and named it MyNumber
            int MyNumber = 11;  


            // Created an if-statement, that compares the value of my variable (MyNumber) to 10, is my variables value bigger or smaller than 10?
            if(MyNumber > 10)
            {
                Console.WriteLine("Talet är stort!");   // if bigger you´ll get this statement
            }
            else if (MyNumber < 10)
            {
                Console.WriteLine("Oj, lågt tal!");     // if smaller you´ll get this statement
            }
            else
            {
                Console.WriteLine($"Talet är detsamma ! Jag hade valt {MyNumber}");   // else (the same value)  you´ll get this statement
            }
          


            
            Console.WriteLine("Hej vad heter du?");
            string UserName = Console.ReadLine();    // saves the name from the userinput(name) in my declared string variable (UserName)
            Console.WriteLine($"Hej {UserName} !");  // Replys the User and says Hi + Name of the user ( by calling the stingvarible UserName)




            int counter = 0;   // Declclares an integer with the value of 0 and named it Counter

            while (counter < MyNumber)       // while loop that helps me write/count from 1 - the value of my interger MyNumber. While the Vulue of Counter is smaller than Mynumber.
            {

                counter++;
                Console.WriteLine(counter);

            }

            //Telling the user the while loop has ended when the value of the counter are the same as MyNumber.
            Console.WriteLine($"Nu kliver vi ut ur loopen då räknarens värde ( {counter} ) har uppnått samma värde som mitt nummer ( {MyNumber} ) som jag valde.");

        }
    }
}