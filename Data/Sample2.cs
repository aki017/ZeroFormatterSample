using System;
using System.IO;
using ZeroFormatter;

namespace ConsoleApplication
{
  namespace Data
  {
    [ZeroFormattable]
    public class Sample2
    {
      [Index(0)]  public virtual string Message { get; set; }
      [Index(1)]  public virtual Sample2Child Child { get; set; }


      public void Sample() {
        Message = "Sample Message";
        Child = new Sample2Child(){
          Message = "Sample Child Message"
        };
      }
    }

    [ZeroFormattable]
    public class Sample2Child
    {
      [Index(0)]  public virtual string Message { get; set; }
    }
  }
}
