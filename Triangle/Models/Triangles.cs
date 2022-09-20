namespace Triangle
{
  public class Triangle
  {
    public string Classify(int a, int b, int hyp)
    {
      if((a == hyp)) 
      {
        if(!(a == b))
        {
          return "Isosceles"; //Isosceles
        }
        else
        {
          return "Equilateral"; //Equilateral
        }
      }
      else if (a + b > hyp) 
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
