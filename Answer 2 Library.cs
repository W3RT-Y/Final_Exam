using System;

namespace MyApplication
{
  abstract class Person 
  {
    public abstract void IStudy();

  }
  
  class Student : Person 
  {
    public override void IStudy()
    {
      Console.WriteLine("I Study");
    }
    static void Main(string[] args)
    {
      Student std = new Student();
      std.IStudy();
      
    }
  }

}