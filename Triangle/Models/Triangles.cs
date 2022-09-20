namespace Triangle
{
  public class Triangle
  {
    public bool IsTriangle(int a, int b, int c)
    {
      if((a == c)) 
      {
        if(!(a == b))
        {
          return true; //Isosceles
        }
        else
        {
          return true; //Equilateral
        }
      }
      else if (a + b > c)
      {  //If one side is <= the sum of the other two sides, then it is a valid Triangle, and thus, a scalene
        return false;
      }
      else 
      {
        return true; //Is triangle
      }
    }

  }
}
