using System;

using System.Windows.Forms;
public class redlightmain{

     static void Main(string[] args){

          System.Console.WriteLine("Welcome to the Main method of the redlight program.");
          redlightuserinterface redapplication = new redlightuserinterface();
          Application.Run(redapplication);
          System.Console.WriteLine("Main method will now shutdown.");

     }//End of Main

}//End of redlightmain
