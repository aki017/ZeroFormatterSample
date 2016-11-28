using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using ZeroFormatter;

namespace ConsoleApplication
{
  namespace Data
  {
    [ZeroFormattable]
    public class Sample3
    {
      [Index(0)] public virtual string[]      MessageArray        { get; set; }
      [Index(1)] public virtual List<string>  MessageListGeneric  { get; set; }
      [Index(2)] public virtual IList<string> MessageIListGeneric { get; set; }

      public void Sample() {
        MessageArray        = new []{ "Hello", "Array" };
        MessageListGeneric  = new List<string>{ "Hello", "List",  "Generic" };
        MessageIListGeneric = new List<string>{ "Hello", "IList", "Generic" };
      }
    }
  }
}
