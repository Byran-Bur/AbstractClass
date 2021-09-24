using System;

namespace Jonhelloworld
{
    class Program
    {
        static void Main(string[] args)
        {
             Ford ford = new ford();

             ford.model = "pinto";
             ford.color = "yellow";
             ford.ShowColor();

             Dodge dodge = new Dodge();

             dodge.Start = "Ford";
             dodge.Drive = "Red";

             Vehicle f1 = new Ford();

            ((Ford)f1).ShowColor();
            f1.ShowColor();
        


        }
    }
}
