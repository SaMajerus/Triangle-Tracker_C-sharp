using System;

/*    Business Logic    */
namespace Triangle
{
  public class Triangle
  {
    public int A { get; set; }
    public int B { get; set; }
    public int Hyp { get; set; }

    public Triangle(int a, int b, int hyp)
    {
      A = a;
      B = b;
      Hyp = hyp;
    }

    public string Classify()
    {
      if((A == Hyp)) 
      {
        if(!(A == B))
        {
          return "Isosceles"; //Isosceles
        }
        else
        {
          return "Equilateral"; //Equilateral
        }
      }
      else if (A + B > Hyp) 
      {  //If one side is <= the sum of the other two sides, then it is a valid Triangle, and thus, a scalene
        return "Scalene";
      }
      else 
      {
        return "Not a triangle"; //Is not a triangle
      }
    }

  }
}
