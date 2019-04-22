using System;
using System.Collections.Generic;

class Triangle
{
  static void Main()
  {
    Console.WriteLine("Enter a number for one side of a triangle");
    string inputSideOne = Console.ReadLine();
    int sideOne = int.Parse(inputSideOne);

    Console.WriteLine("Enter a second number for another side of the triangle");
    string inputSideTwo = Console.ReadLine();
    int sideTwo = int.Parse(inputSideTwo);


    Console.WriteLine("Enter a third number for the last side of the triangle");
    string inputSideThree = Console.ReadLine();
    int sideThree = int.Parse(inputSideThree);

    if (sideOne <= (sideTwo + sideThree) && sideTwo <= (sideThree + sideOne) && sideThree <= (sideOne + sideTwo))

    {
       if (sideOne==sideTwo && sideTwo==sideThree)
      {
        Console.WriteLine("equilateral");

        } else if (sideOne==sideTwo || sideOne==sideThree || sideThree==sideTwo)
        {
          Console.WriteLine("isosceles");
        }
        else
        {
          Console.WriteLine("scalene");
        }
    } else {
      Console.WriteLine("Not a triangle");
    }

  }
}
