namespace Triangle
{
  public class Triangle
  {
    public bool IsTriangle(int a, int b, int c)
    {
      if((a == b) && (b==c))
      {
        if(c != a){
          return true; //Isosceles
        }else{
          return true; //Equilateral
        }
      }
      else 
      {
        return true; //Scalene(?)
      }
    }

  }
}
