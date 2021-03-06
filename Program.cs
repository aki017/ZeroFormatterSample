﻿using System;
using System.IO;
using System.Reflection;
using ZeroFormatter;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var cwd = Directory.GetCurrentDirectory();
      var dir = new DirectoryInfo(Path.Combine(cwd, "Data"));
      var files = dir.GetFiles();
      foreach(var f in files) {
        var t = Type.GetType("ConsoleApplication.Data."+Path.GetFileNameWithoutExtension(f.Name));
        MethodInfo method = typeof(Program).GetMethod("Test", BindingFlags.Static | BindingFlags.Public );
        method.MakeGenericMethod(t).Invoke(null, null);
      }
    }

    public static void Test<T>() where T : new(){
      Console.WriteLine(typeof(T).Name);
      dynamic obj = new T();
      obj.Sample();
      var data = ZeroFormatterSerializer.Serialize<T>(obj);
      File.WriteAllBytes($"packed/{typeof(T).Name}.pack", data);
    }
  }
}
